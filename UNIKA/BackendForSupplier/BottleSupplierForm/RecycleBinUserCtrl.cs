using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System.Resources;
using System.ComponentModel;
using System.Collections.Specialized;

namespace BackendForSupplier.BottleSupplierForm
{
    public partial class RecycleBinUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForSupplier.Properties.Resources", typeof(RecycleBinUserCtrl).Assembly);

        private static Properties.Settings setting = Properties.Settings.Default;
        private StringCollection showedDeletedAlertBottle = setting.showedDeletedAlertBottle;
        private StringCollection showedStockAlertBottle = setting.showedStockAlertBottle;

        private ProductBottleDA pbda = new ProductBottleDA();
        private string supplierID = null;
        List<Bottle> productList = null;

        public RecycleBinUserCtrl(string supplierID)
        {
            InitializeComponent();

            this.supplierID = supplierID;
            productList = pbda.findDeletedProductBottlesBySupplierID(this.supplierID, Language.getLanguageCode(), conn);

            capacityFormTextBox.Text = "5";
            capacityToTextBox.Text = "200";

            deleteFromDateTime.Value = DateTime.Now.Date.AddMonths(-18);
            deleteToDateTime.Value = DateTime.Now.Date;

            input_SearchChanged(null, null);
        }

        private void capacityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((MetroRadioButton)sender).Name.Equals("capacityRangeRadioButton"))
            {
                capacityToLabel.Enabled = true;
                capacityFormTextBox.Enabled = true;
                capacityToTextBox.Enabled = true;
            }
            else if (((MetroRadioButton)sender).Name.Equals("capacityAllRadioButton"))
            {
                capacityToLabel.Enabled = false;
                capacityFormTextBox.Enabled = false;
                capacityToTextBox.Enabled = false;
            }

            input_SearchChanged(sender, e);
        }

        private void capacityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (((MetroTextBox)sender).Name.Equals("capacityFormTextBox"))
                if (int.Parse(capacityFormTextBox.Text) < 5 || string.IsNullOrWhiteSpace(capacityFormTextBox.Text))
                    capacityFormTextBox.Text = "5";
                else if (int.Parse(capacityFormTextBox.Text) > int.Parse(capacityToTextBox.Text))
                    capacityFormTextBox.Text = capacityToTextBox.Text;

            if (((MetroTextBox)sender).Name.Equals("capacityToTextBox"))
                if (int.Parse(capacityToTextBox.Text) > 200 || string.IsNullOrWhiteSpace(capacityToTextBox.Text))
                    capacityToTextBox.Text = "200";
                else if (int.Parse(capacityToTextBox.Text) < int.Parse(capacityFormTextBox.Text))
                    capacityToTextBox.Text = capacityFormTextBox.Text;
        }

        private void deleteDateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((MetroRadioButton)sender).Name.Equals("deleteDateRangeRadioButton"))
            {
                deleteDateToLabel.Enabled = true;
                deleteFromDateTime.Enabled = true;
                deleteToDateTime.Enabled = true;
            }
            else if (((MetroRadioButton)sender).Name.Equals("deleteDateAllRadioButton"))
            {
                deleteDateToLabel.Enabled = false;
                deleteFromDateTime.Enabled = false;
                deleteToDateTime.Enabled = false;
            }
            input_SearchChanged(sender, e);
        }

        private void deleteDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (deleteFromDateTime.Value.Date > deleteToDateTime.Value.Date)
            {
                if (((MetroDateTime)sender).Name.Equals("deleteFromDateTime"))
                {
                    deleteFromDateTime.Value = deleteToDateTime.Value.Date;
                }
                else if (((MetroDateTime)sender).Name.Equals("deleteToDateTime"))
                {
                    deleteToDateTime.Value = deleteFromDateTime.Value.Date;
                }
            }
            input_SearchChanged(sender, e);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            bottleIdTextBox.Clear();
            keywordTextBox.Clear();

            capacityRangeRadioButton.Checked = false;
            capacityAllRadioButton.Checked = true;
            capacityToLabel.Enabled = false;
            capacityFormTextBox.Enabled = false;
            capacityToTextBox.Enabled = false;
            capacityFormTextBox.Text = "5";
            capacityToTextBox.Text = "200";


            deleteDateRangeRadioButton.Checked = false;
            deleteDateAllRadioButton.Checked = true;
            deleteDateToLabel.Enabled = false;
            deleteFromDateTime.Enabled = false;
            deleteToDateTime.Enabled = false;
            deleteFromDateTime.Value = DateTime.Now.Date.AddMonths(-18);
            deleteToDateTime.Value = DateTime.Now.Date;
        }

        private void input_SearchChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(capacityFormTextBox.Text))
                capacityFormTextBox.Text = "5";

            if (string.IsNullOrWhiteSpace(capacityToTextBox.Text))
                capacityToTextBox.Text = "200";


            bottleListDataGridView.Rows.Clear();
            bottleListDataGridView.Refresh();

            if (productList != null)
                foreach (Bottle bottle in productList)
                    if (((bottle.getProductID().ToUpper()).Contains(bottleIdTextBox.Text.ToUpper()) || string.IsNullOrWhiteSpace(bottleIdTextBox.Text)) &&
                        ((bottle.getProductNameEnUs().ToLower()).Contains(keywordTextBox.Text.ToLower()) ||
                         (bottle.getProductNameZhHant()).Contains(keywordTextBox.Text) ||
                         (bottle.getDescriptionEnUs().ToLower()).Contains(keywordTextBox.Text.ToLower()) ||
                         (bottle.getDescriptionZhHant()).Contains(keywordTextBox.Text) ||
                          string.IsNullOrWhiteSpace(keywordTextBox.Text)) &&
                        ((capacityRangeRadioButton.Checked && int.Parse(capacityFormTextBox.Text) <= bottle.getBottleCapacity() && int.Parse(capacityToTextBox.Text) >= bottle.getBottleCapacity()) ||
                          capacityAllRadioButton.Checked) &&
                        ((deleteDateRangeRadioButton.Checked && deleteFromDateTime.Value.Date <= bottle.getDateDeleted().Date && deleteToDateTime.Value.Date >= bottle.getDateDeleted().Date) ||
                           deleteDateAllRadioButton.Checked))
                        bottleListDataGridView.Rows.Add(
                            false,
                            bottle.getProductID(),
                            bottle.getProductNameEnUs(),
                            bottle.getProductNameZhHant(),
                            bottle.getDescriptionEnUs(),
                            bottle.getDescriptionZhHant(),
                            bottle.getBottleCapacity().ToString() + " " + rs.GetString("mlText"),
                            bottle.getQtyInStock(),
                            rs.GetString("hkdText") + bottle.getPrice().ToString(),
                            bottle.getReleaseDate().ToLongDateString(),
                            bottle.getDateDeleted().ToLongDateString());

            bottleListDataGridView.ClearSelection();

            if (bottleListDataGridView.Rows.Count > 0)
            {
                permanentlyDeleteButton.Enabled = true;
                recoverButton.Enabled = true;
                deselectAllButton.Enabled = true;
                selectAllButton.Enabled = true;
            }
            else
            {
                permanentlyDeleteButton.Enabled = false;
                recoverButton.Enabled = false;
                deselectAllButton.Enabled = false;
                selectAllButton.Enabled = false;
            }
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in bottleListDataGridView.Rows)
            {
                if (!(bool)row.Cells["selectedProductColumn"].Value)
                {
                    row.Cells["selectedProductColumn"].Value = true;
                }
            }
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in bottleListDataGridView.Rows)
            {
                if ((bool)row.Cells["selectedProductColumn"].Value)
                {
                    row.Cells["selectedProductColumn"].Value = false;
                }
            }
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = bottleListDataGridView.Rows.Count - 1; i >= 0; i--)
            {
                bool delete = (bool)bottleListDataGridView.Rows[i].Cells["selectedProductColumn"].Value;
                if (delete == true)
                {
                    pbda.undelete((string)bottleListDataGridView.Rows[i].Cells["bottleIdColumn"].Value, conn);
                    showedDeletedAlertBottle.Remove((string)bottleListDataGridView.Rows[i].Cells["bottleIdColumn"].Value);
                    setting.Save();
                    bottleListDataGridView.Rows.Remove(bottleListDataGridView.Rows[i]);
                    count++;
                }
            }

            if (count == 0)
                MessageBox.Show(rs.GetString("selectProcuctDeletedMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (bottleListDataGridView.Rows.Count > 0)
                {
                    permanentlyDeleteButton.Enabled = true;
                    recoverButton.Enabled = true;
                    deselectAllButton.Enabled = true;
                    selectAllButton.Enabled = true;
                }
                else
                {
                    permanentlyDeleteButton.Enabled = false;
                    recoverButton.Enabled = false;
                    deselectAllButton.Enabled = false;
                    selectAllButton.Enabled = false;
                }

                bottleListDataGridView.ClearSelection();

                productList.Clear();
                productList = null;
                productList = pbda.findDeletedProductBottlesBySupplierID(supplierID, Language.getLanguageCode(), conn);


         
                MessageBox.Show(rs.GetString("deletedProcuctRecoverMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void permanentlyDeleteButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(rs.GetString("deletePermanentlyYesNoMsg"), rs.GetString("deleteTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = 0;

                for (int i = bottleListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)bottleListDataGridView.Rows[i].Cells["selectedProductColumn"].Value;
                    if (delete == true)
                    {
                        pbda.permanentlyDelete((string)bottleListDataGridView.Rows[i].Cells["bottleIdColumn"].Value, conn);
                        showedDeletedAlertBottle.Remove((string)bottleListDataGridView.Rows[i].Cells["bottleIdColumn"].Value);
                        setting.Save();
                        showedStockAlertBottle.Remove((string)bottleListDataGridView.Rows[i].Cells["bottleIdColumn"].Value);
                        setting.Save();
                        bottleListDataGridView.Rows.Remove(bottleListDataGridView.Rows[i]);
                        count++;
                    }
                }

                if (count == 0)
                    MessageBox.Show(rs.GetString("selectProcuctDeletedMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (bottleListDataGridView.Rows.Count > 0)
                    {
                        permanentlyDeleteButton.Enabled = true;
                        recoverButton.Enabled = true;
                        deselectAllButton.Enabled = true;
                        selectAllButton.Enabled = true;
                    }
                    else
                    {
                        permanentlyDeleteButton.Enabled = false;
                        recoverButton.Enabled = false;
                        deselectAllButton.Enabled = false;
                        selectAllButton.Enabled = false;
                    }

                    bottleListDataGridView.ClearSelection();

                    MessageBox.Show(rs.GetString("deletePermanentlyMsg"));
                }
            }
        }

        private void RecycleBinUserCtrl_Load(object sender, EventArgs e)
        {

        }
    }
}
