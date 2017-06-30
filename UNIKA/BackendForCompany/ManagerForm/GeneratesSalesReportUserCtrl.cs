using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BackendForCompany.ManagerForm
{
    public partial class GeneratesSalesReportUserCtrl : UserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private MySqlCommand sqlCommand;
        private MySqlDataAdapter sqlDataAdapter;
        private string first_date;
        private string second_date;
        private DataTable dt;
        private string staffID = null;
        private DataTable foroutput;


        public GeneratesSalesReportUserCtrl(string staffID)
        {
            InitializeComponent();

            this.staffID = staffID;
        }

        private void SelectLocation_Click(object sender, EventArgs e)
        {
            using (var fdg = new FolderBrowserDialog())
            {
                if(fdg.ShowDialog() == DialogResult.OK)
                {
                    location.Text = fdg.SelectedPath;
                }
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            try
            {
                saleslist.Rows.Clear();
                saleslist.Refresh();

                dt = new DataTable();
                first_date = "";
                second_date = "";
                first_date = startdate.Value.ToString("yyyy-MM-dd") + " 00:00:00";
                second_date = enddate.Value.ToString("yyyy-MM-dd HH:mm:ss");
                conn.Open();
                sqlCommand = new MySqlCommand("Select `order`.`Order_ID`, `order`.`Customer_ID`, `order`.`Order_date`, `order`.`PayPal_Transaction_ID`, `product_package`.`Product_Name_en-US` AS `package_name`, Round(package_order_line.Unit_Price*IFNULL((1-(package_order_line.Discount/100)),1)) AS `package_price`, `package_order_line`.`Unit_Price` AS `package_unit_price`, `package_order_line`.`Discount` AS `package_discount`, `product_bottle`.`Product_Name_en-US` AS `bottle_name`, Round(bottle_order_line.Unit_Price*IFNULL((1-(bottle_order_line.Discount/100)),1)) AS `bottle_price`, `bottle_order_line`.`Unit_Price` AS `bottle_unit_price`, `bottle_order_line`.`Discount` AS `bottle_discount`, `product_perfume`.`Product_Name_en-US` AS `perfume_name`, Round(perfume_order_line.Unit_Price*IFNULL((1-(perfume_order_line.Discount/100)),1)*perfume_order_line.Qty) AS `perfume_price`, `perfume_order_line`.`Unit_Price` AS `perfume_unit_price`, `perfume_order_line`.`Qty`, `perfume_order_line`.`Discount` AS `perfume_discount`, `perfume_order_line`.`Note` from `order` INNER JOIN `package_order_line` ON `order`.`Order_ID` = `package_order_line`.`Order_ID` INNER JOIN `bottle_order_line` ON `order`.`Order_ID` = `bottle_order_line`.`Order_ID` INNER JOIN `perfume_order_line` ON `order`.`Order_ID` = `perfume_order_line`.`Order_ID` INNER JOIN `product_package` ON `package_order_line`.`Product_ID` = `product_package`.`Product_ID` INNER JOIN `product_bottle` ON `bottle_order_line`.`Product_ID` = `product_bottle`.`Product_ID` INNER JOIN `product_perfume` ON `perfume_order_line`.`Product_ID` = `product_perfume`.`Product_ID` where Order_date >= @first_date and order_date <= @second_date AND Approved_By IS NOT NULL AND package_order_line.Order_ID = `order`.`Order_ID`", conn);

                sqlCommand.Parameters.AddWithValue("@first_date", first_date);
                sqlCommand.Parameters.AddWithValue("@second_date", second_date);
                sqlDataAdapter = new MySqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dt);
                conn.Close();

                foroutput = Dedup(dt, "Order_ID");
                saleslist.DataSource = foroutput;

            }
            catch (Exception)
            {
                conn.Close();
            }
        }

        public static DataTable Dedup(DataTable dt, string columnName)
        {
            for (int rowIndex = dt.Rows.Count - 1; rowIndex >= 1; rowIndex--)
            {
                var row = dt.Rows[rowIndex][columnName];
                var previousRow = dt.Rows[rowIndex - 1][columnName];

                if (row.ToString() == previousRow.ToString())
                {
                    dt.Rows[rowIndex][0] = DBNull.Value;
                    dt.Rows[rowIndex][1] = DBNull.Value;
                    dt.Rows[rowIndex][2] = DBNull.Value;
                    dt.Rows[rowIndex][3] = DBNull.Value;
                    dt.Rows[rowIndex][4] = DBNull.Value;
                    dt.Rows[rowIndex][5] = "0";
                    dt.Rows[rowIndex][6] = DBNull.Value;
                    dt.Rows[rowIndex][7] = DBNull.Value;
                    dt.Rows[rowIndex][8] = DBNull.Value;
                    dt.Rows[rowIndex][9] = "0";
                    dt.Rows[rowIndex][10] = DBNull.Value;
                    dt.Rows[rowIndex][12] = DBNull.Value;
                }
            }

            return dt;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            try
            {
                if (location.Text != "" && dt.Rows.Count != 0)
                {
                    var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);

                    string date = (DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss_")).ToString();
                    string locat = location.Text + "\\" + date + "SalesReport.pdf";
                    Document doc = new Document(iTextSharp.text.PageSize.A4.Rotate(), 10, 10, 42, 35);
                    PdfWriter pw = PdfWriter.GetInstance(doc, new FileStream(locat, FileMode.Create));

                    doc.Open();

                    //logo part
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("unika.png");
                    logo.ScalePercent(75f);
                    logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                    doc.Add(logo);

                    var header = new Phrase(new Chunk("\n\nSales Report", boldFont));

                    Paragraph para = new Paragraph(header);
                    para.Alignment = Element.ALIGN_CENTER;
                    doc.Add(para);

                    doc.Add(Chunk.NEWLINE);

                    string spaces = new string(' ', 25);
                    var temp_date_range = new Phrase(new Chunk(spaces + "From " + first_date + " to " + second_date));
                    Paragraph start_end = new Paragraph(temp_date_range);
                    doc.Add(start_end);

                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    PdfPTable table = new PdfPTable(dt.Columns.Count);

                    for (int i = 0; i < saleslist.ColumnCount; i++)
                    {
                        table.AddCell(new Phrase(saleslist.Columns[i].HeaderText));
                    }

                    table.HeaderRows = 1;

                    for (int i = 0; i < saleslist.RowCount; i++)
                    {
                        for (int k = 0; k < saleslist.ColumnCount; k++)
                        {
                            if (saleslist[k, i].Value != null)
                            {
                                table.AddCell(new Phrase(saleslist[k, i].Value.ToString()));
                            }
                        }
                    }

                    doc.Add(table);

                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    double sum = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        sum += Convert.ToDouble(dr[5]);
                        sum += Convert.ToDouble(dr[9]);
                        sum += Convert.ToDouble(dr[13]);
                    }

                    string spaces2 = new string(' ', 15);
                    var subtotal = new Phrase(new Chunk("Subtotal : $" + sum.ToString() + spaces2, boldFont));

                    Paragraph sub = new Paragraph(subtotal);
                    sub.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(sub);

                    doc.Close();
                    MessageBox.Show("Sales report generated successfully.\nThe location of the Sales report is : " + location.Text + "\nThe name of the Sales report is : " + date + "SalesReport.pdf\n銷售報告已成功生成\n銷售報告的位置在 : " + location.Text + "\n銷售報告的名稱是 : " + date);
                }
                else
                {
                    MessageBox.Show("You have not select the path to be genrate sales report or the sales order are missing.\n你沒有選擇路徑去生成銷售報告或銷售訂單是空的");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void startdate_ValueChanged(object sender, EventArgs e)
        {
            if (startdate.Value > enddate.Value)
            {
                startdate.Value = enddate.Value.AddDays(-1);
            }
        }

        private void enddate_ValueChanged(object sender, EventArgs e)
        {
            if (enddate.Value < startdate.Value)
            {
                enddate.Value = startdate.Value.AddDays(+1);
            }
        }
    }
}
