using System;
using System.Collections.Generic;
using MetroFramework.Controls;
using BackendClassLibrary.Data;
using MySql.Data.MySqlClient;
using System.Resources;
using BackendClassLibrary.DataAccess;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.IO;
using System.ComponentModel;

namespace BackendForCompany.StaffForm
{
    public partial class ReportProblemUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(ReportProblemUserCtrl).Assembly);

        private PhotoBoxForm pbf = null;

        private ProductBottleDA pbda = new ProductBottleDA();
        private ProductPackageDA ppgda = new ProductPackageDA();
        private ProductPerfumeDA ppda = new ProductPerfumeDA();
        private OrderDA oda = new OrderDA();
        private Order orderDetail = null;

        private ProblemReportDA prda = new ProblemReportDA();

        private string staffID = null;

        public ReportProblemUserCtrl(string staffID)
        {
            this.staffID = staffID;

            InitializeComponent();

            BindingList<KeyValuePair<string, string>> reasonList = new BindingList<KeyValuePair<string, string>>();
            reasonComboBox.DataSource = null;
            reasonComboBox.Items.Clear();
            reasonComboBox.DisplayMember = "Key";
            reasonComboBox.ValueMember = "Value";
            reasonComboBox.DataSource = reasonList;

            reasonList.Add(new KeyValuePair<string, string>(rs.GetString("productDamagedText"), "Product has been damaged"));
            reasonList.Add(new KeyValuePair<string, string>(rs.GetString("productNotMatch"), "Product does not match order"));
            reasonList.Add(new KeyValuePair<string, string>(rs.GetString("expressPackageDamaged"), "Express package has been opened/damaged"));

            reasonComboBox.SelectedIndex = -1;

            searchChange_TextChanged(null, null);

            orderFormDateTime.Value = DateTime.Now.Date.AddMonths(-1);
            orderToDateTime.Value = DateTime.Now.Date;

            showReportDateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void searchChange_TextChanged(object sender, EventArgs e)
        {
            orderDataGridView.Rows.Clear();
            orderDataGridView.Refresh();

            List<Order> list = oda.getAllOrders(conn);
            foreach (Order order in list)
                if (((order.getOrderID().ToString()).Contains(orderIdTextBox.Text)) &&
                    (order.getOrderDate().Date >= orderFormDateTime.Value.Date && order.getOrderDate().Date <= orderToDateTime.Value.Date))
                {
                    orderDataGridView.Rows.Add(
                        order.getOrderID(),
                        order.getOrderDate(),
                        order.getCustName());
                }

            orderDataGridView.ClearSelection();
            foreach (DataGridViewRow row in orderDataGridView.Rows)
            {
                if (showOrderIdLabel.Text.Equals(row.Cells["orderIdColumn"].Value.ToString()))
                    row.Selected = true;
            }
        }

        private void orderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                OrderLineDA olda = new OrderLineDA();

                orderDetail = null;
                orderDetail = oda.getOneOrderByID(orderDataGridView.Rows[e.RowIndex].Cells["orderIdColumn"].Value.ToString(), conn);

                showOrderIdLabel.Text = orderDetail.getOrderID().ToString();
                showOrderDateLabel.Text = orderDetail.getOrderDate().Date.ToLongDateString();
                showNameLabel.Text = orderDetail.getCustName();
                showAddressLabel.Text = orderDetail.getCustAddress();
                showEmailLabel.Text = orderDetail.getCustEmail();
                showMobileNoLabel.Text = orderDetail.getCustMobilePhoneNo();

                OrderLine packageOl = olda.getPackageOrderLine(showOrderIdLabel.Text, Language.getLanguageCode(), conn);
                if (!string.IsNullOrEmpty(packageOl.getProductID()))
                {
                    showPackageIdLabel.Text = packageOl.getProductID();
                    showPackageNameLabel.Text = packageOl.getProductName();
                }
                else
                {
                    showPackageIdLabel.Text = " ";
                    showPackageNameLabel.Text = " ";
                }

                OrderLine bottleOl = olda.getBottleOrderLine(showOrderIdLabel.Text, Language.getLanguageCode(), conn);
                if (!string.IsNullOrEmpty(bottleOl.getProductID()))
                {
                    showBottleIdLabel.Text = bottleOl.getProductID();
                    showBottleNameLabel.Text = bottleOl.getProductName();
                    showBottleCapacityLabel.Text = bottleOl.getBottleCapacity().ToString() + rs.GetString("mlText");
                }
                else
                {
                    showBottleIdLabel.Text = " ";
                    showBottleNameLabel.Text = " ";
                    showBottleCapacityLabel.Text = " ";
                }

                List<OrderLine> perfumeOlList = olda.getPerfumeOrderLine(showOrderIdLabel.Text, Language.getLanguageCode(), conn);

                if (perfumeOlList.Count > 0)
                {
                    showPerfumeId0Label.Text = perfumeOlList.ElementAt(0).getProductID();
                    showPerfumeName0Label.Text = perfumeOlList.ElementAt(0).getProductName();
                    showPerfumeNote0Label.Text = rs.GetString(perfumeOlList.ElementAt(0).getNote() + "Text");
                    showPerfumeQty0Label.Text = perfumeOlList.ElementAt(0).getQty().ToString();
                }
                else
                {
                    showPerfumeId0Label.Text = " ";
                    showPerfumeName0Label.Text = " ";
                    showPerfumeNote0Label.Text = " ";
                    showPerfumeQty0Label.Text = " ";
                }

                if (perfumeOlList.Count > 1)
                {
                    showPerfumeId1Label.Text = perfumeOlList.ElementAt(1).getProductID();
                    showPerfumeName1Label.Text = perfumeOlList.ElementAt(1).getProductName();
                    showPerfumeNote1Label.Text = rs.GetString(perfumeOlList.ElementAt(1).getNote() + "Text");
                    showPerfumeQty1Label.Text = perfumeOlList.ElementAt(1).getQty().ToString();
                }
                else
                {
                    showPerfumeId1Label.Text = " ";
                    showPerfumeName1Label.Text = " ";
                    showPerfumeNote1Label.Text = " ";
                    showPerfumeQty1Label.Text = " ";
                }

                if (perfumeOlList.Count > 2)
                {
                    showPerfumeId2Label.Text = perfumeOlList.ElementAt(2).getProductID();
                    showPerfumeName2Label.Text = perfumeOlList.ElementAt(2).getProductName();
                    showPerfumeNote2Label.Text = rs.GetString(perfumeOlList.ElementAt(2).getNote() + "Text");
                    showPerfumeQty2Label.Text = perfumeOlList.ElementAt(2).getQty().ToString();
                }
                else
                {
                    showPerfumeId2Label.Text = " ";
                    showPerfumeName2Label.Text = " ";
                    showPerfumeNote2Label.Text = " ";
                    showPerfumeQty2Label.Text = " ";
                }

                if (perfumeOlList.Count > 3)
                {
                    showPerfumeId3Label.Text = perfumeOlList.ElementAt(3).getProductID();
                    showPerfumeName3Label.Text = perfumeOlList.ElementAt(3).getProductName();
                    showPerfumeNote3Label.Text = rs.GetString(perfumeOlList.ElementAt(3).getNote() + "Text");
                    showPerfumeQty3Label.Text = perfumeOlList.ElementAt(3).getQty().ToString();
                }
                else
                {
                    showPerfumeId3Label.Text = " ";
                    showPerfumeName3Label.Text = " ";
                    showPerfumeNote3Label.Text = " ";
                    showPerfumeQty3Label.Text = " ";
                }

                if (perfumeOlList.Count > 4)
                {
                    showPerfumeId4Label.Text = perfumeOlList.ElementAt(4).getProductID();
                    showPerfumeName4Label.Text = perfumeOlList.ElementAt(4).getProductName();
                    showPerfumeNote4Label.Text = rs.GetString(perfumeOlList.ElementAt(4).getNote() + "Text");
                    showPerfumeQty4Label.Text = perfumeOlList.ElementAt(4).getQty().ToString();
                }
                else
                {
                    showPerfumeId4Label.Text = " ";
                    showPerfumeName4Label.Text = " ";
                    showPerfumeNote4Label.Text = " ";
                    showPerfumeQty4Label.Text = " ";
                }

                if (perfumeOlList.Count > 4)
                {
                    showPerfumeId5Label.Text = perfumeOlList.ElementAt(5).getProductID();
                    showPerfumeName5Label.Text = perfumeOlList.ElementAt(5).getProductName();
                    showPerfumeNote5Label.Text = rs.GetString(perfumeOlList.ElementAt(5).getNote() + "Text");
                    showPerfumeQty5Label.Text = perfumeOlList.ElementAt(5).getQty().ToString();
                }
                else
                {
                    showPerfumeId5Label.Text = " ";
                    showPerfumeName5Label.Text = " ";
                    showPerfumeNote5Label.Text = " ";
                    showPerfumeQty5Label.Text = " ";
                }

                reportDataGridView.Rows.Clear();
                reportDataGridView.Refresh();
                List<ProblemReport> list = prda.getReportsByOrderID(ulong.Parse(orderDataGridView.Rows[e.RowIndex].Cells["orderIdColumn"].Value.ToString()), conn);

                foreach (ProblemReport pr in list)
                    reportDataGridView.Rows.Add(pr.getProblemID(), pr.getReportDate().ToLongDateString()+", "+ pr.getReportDate().ToLongTimeString());
                reportDataGridView.ClearSelection();

                showReportDateLabel.Enabled = true;
                reasonComboBox.Enabled = true;
                reasonComboBox.SelectedIndex = -1;
                reasonHintLabel.Enabled = true;
                reasonHintLabel.ForeColor = SystemColors.ControlText;
                photoBox.Enabled = true;
                photoBox.Image = null;
                browsePhotoButton.Enabled = true;
                zoomPhotoButton.Enabled = false;
                photoHintLabel.Enabled = true;
                photoHintLabel.ForeColor = SystemColors.ControlText;
                naReturnDateCheckBox.Enabled = true;
                naReturnDateCheckBox.Checked = true;
                returnDateTime.Enabled = false;
                addButton.Enabled = true;
                recordReturnDateButton.Enabled = false;
            }
        }

        private void reportDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ProblemReport pr = prda.getOneReportByID((int)reportDataGridView.Rows[e.RowIndex].Cells["problemIdColumn"].Value, conn);
                showReportDateLabel.Text = pr.getReportDate().ToLongDateString();
                reasonComboBox.SelectedValue = pr.getReason();
                photoBox.Image = pr.getPhoto();

                showReportDateLabel.Enabled = false;
                reasonComboBox.Enabled = false;
                reasonHintLabel.Enabled = false;
                photoBox.Enabled = false;
                browsePhotoButton.Enabled = false;
                zoomPhotoButton.Enabled = true;
                photoHintLabel.Enabled = false;
                if (pr.getReturnDate()==null)
                {
                    naReturnDateCheckBox.Checked = true;
                    naReturnDateCheckBox.Enabled = true;
                    returnDateTime.Enabled = false;
                }
                else
                {
                    naReturnDateCheckBox.Checked = false;
                    naReturnDateCheckBox.Enabled = false;
                    returnDateTime.Enabled = false;
                }

                addButton.Enabled = false;
                recordReturnDateButton.Enabled = false;
            }
        }

        private void browsePhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = rs.GetString("choosePhotoText") + " (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            opf.Multiselect = false;

            if (opf.ShowDialog() == DialogResult.OK)
            {
                Image uploadImage = Image.FromFile(opf.FileName);
                long size = new FileInfo(opf.FileName).Length;
                if (size <= 6291456)
                {
                    photoBox.Image = uploadImage;
                    zoomPhotoButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show(rs.GetString("uploadProblemPhotoErrorMsg"), rs.GetString("attentionText"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    browsePhotoButton_Click(null, null);
                }
            }
        }

        private void zoomPhotoButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            pbf = new PhotoBoxForm(photoBox.Image);
            pbf.FormClosed += new FormClosedEventHandler(photoForm_Closed);
            pbf.ShowDialog();
        }

        private void photoForm_Closed(object sender, EventArgs e)
        {
            pbf = null;
            Enabled = true;
        }

        private void naShippingFeeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (naReturnDateCheckBox.Checked)
            {
                returnDateTime.Enabled = false;
                if(reportDataGridView.SelectedRows.Count == 1)
                    recordReturnDateButton.Enabled = false;
            }
            else if (!naReturnDateCheckBox.Checked)
            {
                returnDateTime.Enabled = true;
                if (reportDataGridView.SelectedRows.Count == 1)
                    recordReturnDateButton.Enabled = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (string.IsNullOrWhiteSpace(reasonComboBox.Text))
            {
                reasonHintLabel.ForeColor = Color.Red;
                error = true;
            }
            else
                reasonHintLabel.ForeColor = SystemColors.ControlText;

            if (photoBox.Image == null)
            {
                photoHintLabel.ForeColor = Color.Red;
                error = true;
            }
            else
                photoHintLabel.ForeColor = SystemColors.ControlText;

            if (!error)
            {
                if (MessageBox.Show((!naReturnDateCheckBox.Checked) ? rs.GetString("askAddReportDialogbox") : rs.GetString("askAddReportExceptReturnDateDialogbox"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProblemReport pr = new ProblemReport();
                    pr.setOrderID(orderDetail.getOrderID());

                    pr.setReportDate(DateTime.Now);
                    showReportDateLabel.Enabled = false;

                    pr.setReason(reasonComboBox.SelectedValue.ToString());
                    reasonComboBox.Enabled = false;
                    reasonHintLabel.Enabled = false;

                    pr.setPhoto(photoBox.Image);
                    photoBox.Enabled = false;
                    browsePhotoButton.Enabled = false;
                    photoHintLabel.Enabled = false;

                    if (!naReturnDateCheckBox.Checked)
                    {
                        pr.setReturnDate(returnDateTime.Value);
                        naReturnDateCheckBox.Checked = false;
                        naReturnDateCheckBox.Enabled = false;
                        returnDateTime.Enabled = false;
                        recordReturnDateButton.Enabled = false;
                    }

                    addButton.Enabled = false;
                    int i = prda.insert(pr, conn);

                    MessageBox.Show(rs.GetString("addNewReportSuccessMsg"));

                    reportDataGridView.Rows.Add(pr.getProblemID(), pr.getReportDate().ToLongDateString() + ", " + pr.getReportDate().ToLongTimeString());

                    reportDataGridView.ClearSelection();
                    foreach (DataGridViewRow row in reportDataGridView.Rows)
                    {
                        if ((pr.getProblemID().ToString()).Equals(row.Cells["problemIdColumn"].Value.ToString()))
                        {
                            row.Selected = true;
                            reportDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        }
                    }
                }
            }
        }

        private void recordReturnDateButton_Click(object sender, EventArgs e)
        {
            if (!naReturnDateCheckBox.Checked)
            {
                if (MessageBox.Show(rs.GetString("askRecordReturnDateDialogbox"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProblemReport pr = prda.getOneReportByID((int)reportDataGridView.Rows[reportDataGridView.CurrentCell.RowIndex].Cells["problemIdColumn"].Value, conn);
                    pr.setReturnDate(returnDateTime.Value);
                    naReturnDateCheckBox.Checked = false;
                    naReturnDateCheckBox.Enabled = false;
                    returnDateTime.Enabled = false;

                    recordReturnDateButton.Enabled = false;

                    prda.update(pr, conn);

                    MessageBox.Show(rs.GetString("recordReturnDateSuccessMsg"));
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reportDataGridView.ClearSelection();
            reportDataGridView.FirstDisplayedScrollingRowIndex = 0;
            showReportDateLabel.Enabled = true;
            reasonComboBox.Enabled = true;
            reasonComboBox.SelectedIndex = -1;
            reasonHintLabel.Enabled = true;
            reasonHintLabel.ForeColor = SystemColors.ControlText;
            photoBox.Enabled = true;
            photoBox.Image = null;
            browsePhotoButton.Enabled = true;
            zoomPhotoButton.Enabled = false;
            photoHintLabel.Enabled = true;
            photoHintLabel.ForeColor = SystemColors.ControlText;
            naReturnDateCheckBox.Enabled = true;
            naReturnDateCheckBox.Checked = true;
            returnDateTime.Enabled = false;
            addButton.Enabled = true;
            recordReturnDateButton.Enabled = false;
        }
    }
}
