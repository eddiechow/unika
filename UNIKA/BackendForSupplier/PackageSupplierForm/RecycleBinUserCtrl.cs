using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System.Resources;
using System.Collections.Specialized;

namespace BackendForSupplier.PackageSupplierForm
{
    public partial class RecycleBinUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForSupplier.Properties.Resources", typeof(RecycleBinUserCtrl).Assembly);

        private static Properties.Settings setting = Properties.Settings.Default;
        private StringCollection showedDeletedAlertPackage = setting.showedDeletedAlertPackage;
        private StringCollection showedStockAlertPackage = setting.showedStockAlertPackage;

        private ProductPackageDA ppda = new ProductPackageDA();
        private string supplierID = null;
        List<Package> productList = null;

        public RecycleBinUserCtrl(string supplierID)
        {
            InitializeComponent();

            this.supplierID = supplierID;
            productList = ppda.getAllDeletedProductPackages(Language.getLanguageCode(), conn);

            deleteFromDateTime.Value = DateTime.Now.Date.AddMonths(-18);
            deleteToDateTime.Value = DateTime.Now.Date;

            input_SearchChanged(null, null);
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
            packageIdTextBox.Text = "";
            keywordTextBox.Text = "";
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
            packageListDataGridView.Rows.Clear();
            packageListDataGridView.Refresh();

            if (productList != null)
                foreach (Package package in productList)
                    if (((package.getProductID().ToUpper()).Contains(packageIdTextBox.Text.ToUpper()) || string.IsNullOrWhiteSpace(packageIdTextBox.Text)) &&
                        ((package.getProductNameEnUs().ToLower()).Contains(keywordTextBox.Text.ToLower()) ||
                         (package.getProductNameZhHant()).Contains(keywordTextBox.Text) ||
                         (package.getDescriptionEnUs().ToLower()).Contains(keywordTextBox.Text.ToLower()) ||
                         (package.getDescriptionZhHant()).Contains(keywordTextBox.Text) ||
                          string.IsNullOrWhiteSpace(keywordTextBox.Text)) &&
                         ((deleteDateRangeRadioButton.Checked && deleteFromDateTime.Value.Date <= package.getDateDeleted().Date && deleteToDateTime.Value.Date >= package.getDateDeleted().Date) ||
                           deleteDateAllRadioButton.Checked)
                       )
                        packageListDataGridView.Rows.Add(
                            false,
                            package.getProductID(),
                            package.getProductNameEnUs(),
                            package.getProductNameZhHant(),
                            package.getDescriptionEnUs(),
                            package.getDescriptionZhHant(),
                            package.getQtyInStock(),
                            rs.GetString("hkdText") + package.getPrice().ToString(),
                            package.getReleaseDate().ToLongDateString(),
                            package.getDateDeleted().ToLongDateString());

            packageListDataGridView.ClearSelection();

            if (packageListDataGridView.Rows.Count > 0)
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
            foreach (DataGridViewRow row in packageListDataGridView.Rows)
            {
                if (!(bool)row.Cells["selectedProductColumn"].Value)
                {
                    row.Cells["selectedProductColumn"].Value = true;
                }
            }
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in packageListDataGridView.Rows)
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

            for (int i = packageListDataGridView.Rows.Count - 1; i >= 0; i--)
            {
                bool delete = (bool)packageListDataGridView.Rows[i].Cells["selectedProductColumn"].Value;
                if (delete == true)
                {
                    ppda.undelete((string)packageListDataGridView.Rows[i].Cells["packageIdColumn"].Value, conn);
                    showedDeletedAlertPackage.Remove((string)packageListDataGridView.Rows[i].Cells["packageIdColumn"].Value);
                    setting.Save();
                    packageListDataGridView.Rows.Remove(packageListDataGridView.Rows[i]);
                    count++;
                }
            }

            if (count == 0)
                MessageBox.Show(rs.GetString("selectProcuctDeletedMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (packageListDataGridView.Rows.Count > 0)
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

                packageListDataGridView.ClearSelection();

                productList = null;
                productList = ppda.getAllDeletedProductPackages(Language.getLanguageCode(), conn);

                MessageBox.Show(rs.GetString("deletedProcuctRecoverMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void permanentlyDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(rs.GetString("deletePermanentlyYesNoMsg"), rs.GetString("deleteTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = 0;

                for (int i = packageListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)packageListDataGridView.Rows[i].Cells["selectedProductColumn"].Value;
                    if (delete == true)
                    {
                        ppda.permanentlyDelete((string)packageListDataGridView.Rows[i].Cells["packageIdColumn"].Value, conn);
                        showedDeletedAlertPackage.Remove((string)packageListDataGridView.Rows[i].Cells["packageIdColumn"].Value);
                        setting.Save();
                        showedStockAlertPackage.Remove((string)packageListDataGridView.Rows[i].Cells["packageIdColumn"].Value);
                        setting.Save();
                        packageListDataGridView.Rows.Remove(packageListDataGridView.Rows[i]);
                        count++;
                    }
                }

                if (count == 0)
                    MessageBox.Show(rs.GetString("selectProcuctDeletedMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (packageListDataGridView.Rows.Count > 0)
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

                    packageListDataGridView.ClearSelection();

                    productList = null;
                    productList = ppda.getAllDeletedProductPackages(Language.getLanguageCode(), conn);

                    MessageBox.Show(rs.GetString("deletePermanentlyMsg"));
                }
            }
        }
    }
}
