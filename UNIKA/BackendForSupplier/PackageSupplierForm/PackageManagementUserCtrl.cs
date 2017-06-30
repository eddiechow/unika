using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System.Resources;
using BackendClassLibrary;
using System.ComponentModel;
using System.IO;
using System.Collections.Specialized;

namespace BackendForSupplier.PackageSupplierForm
{
    public partial class PackageManagementUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForSupplier.Properties.Resources", typeof(PackageManagementUserCtrl).Assembly);

        private static Properties.Settings setting = Properties.Settings.Default;
        StringCollection showedStockAlertPackage = setting.showedStockAlertPackage;

        private ProductPackageDA ppda = new ProductPackageDA();
        private string supplierID = null;
        private List<Package> productList = null;

        public PackageManagementUserCtrl(string supplierID)
        {
            InitializeComponent();

            this.supplierID = supplierID;
            productList = ppda.findProductPackagesBySupplierID(supplierID, Language.getLanguageCode(), conn);

            genPackageID();

            searchPriceFormTextBox.Text = "1";
            searchPriceToTextBox.Text = "300";

            searchReleaseFromDateTime.Value = DateTime.Now.Date.AddMonths(-18);
            searchReleaseToDateTime.Value = DateTime.Now.Date;
        }

        private void genPackageID()
        {
            string existPackage = null;
            Random rnd = new Random();
            string id = "PG" + rnd.Next(100000, 999999);
            Package p = ppda.getOneProductPackageByID(id, Language.getLanguageCode(), conn);
            existPackage = p.getProductID();
            Package dp = ppda.getOneDeletedPackageByID(id, Language.getLanguageCode(), conn);
            existPackage = dp.getProductID();

            if (existPackage != null)
                genPackageID();
            else
                packageIdTextBox.Text = id;
        }

        private bool isInputCorrect()
        {
            bool correct = true;

            if (string.IsNullOrWhiteSpace(englishNameTextBox.Text))
            {
                englishNameErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                englishNameErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(tChineseNameTextBox.Text) || !FormatChecker.includeChineseChar(tChineseNameTextBox.Text))
            {
                tChineseNameErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                tChineseNameErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(quantityTextBox.Text) || !(int.Parse(quantityTextBox.Text) >= 1))
            {
                quantityErrorLabel.ForeColor = Color.Red;
                correct = false;
            }
            else
            {
                quantityErrorLabel.ForeColor = SystemColors.ControlText;
            }

            if (string.IsNullOrWhiteSpace(priceTextBox.Text) || !(int.Parse(priceTextBox.Text) > 0 && int.Parse(priceTextBox.Text) <= 300))
            {
                priceErrorLabel.ForeColor = Color.Red;
                correct = false;
            }
            else
            {
                priceErrorLabel.ForeColor = SystemColors.ControlText;
            }

            if (string.IsNullOrWhiteSpace(engDescTextBox.Text))
            {
                engDescErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                engDescErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(tChiDescTextBox.Text) || !FormatChecker.includeChineseChar(tChiDescTextBox.Text))
            {
                tChiDescErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                tChiDescErrorLabel.Visible = false;
            }

            if (productPhotoBox.Image == null)
            {
                photoErrorLabel.ForeColor = Color.Red;
                correct = false;
            }
            else
            {
                photoErrorLabel.ForeColor = SystemColors.ControlText;
            }

            return correct;
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
                if (size <= 1048576 && uploadImage.Width == 512 && uploadImage.Height == 512)
                    productPhotoBox.Image = uploadImage;
                else
                {
                    MessageBox.Show(rs.GetString("uploadPhotoErrorMsg"), rs.GetString("attentionText"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    browsePhotoButton_Click(null, null);
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            packageListDataGridView.ClearSelection();
            addButton.Enabled = true;
            updateButton.Enabled = false;
            genPackageID();
            englishNameTextBox.Clear();
            tChineseNameTextBox.Clear();
            quantityTextBox.Clear();
            priceTextBox.Clear();
            engDescTextBox.Clear();
            tChiDescTextBox.Clear();
            productPhotoBox.Image = null;
            productPhotoBox.Invalidate();
            packageIdHintLabel.Visible = true;
            
            englishNameErrorLabel.Visible = false;
            tChineseNameErrorLabel.Visible = false;
            quantityErrorLabel.ForeColor = SystemColors.ControlText;
            priceErrorLabel.ForeColor = SystemColors.ControlText;
            engDescErrorLabel.Visible = false;
            tChiDescErrorLabel.Visible = false;
            photoErrorLabel.ForeColor = SystemColors.ControlText;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool isInputCorrect = this.isInputCorrect();

            if (isInputCorrect)
            {
                Package p = new Package();
                p.setProductID(packageIdTextBox.Text);
                p.setProductNameEnUs(englishNameTextBox.Text);
                p.setProductNameZhHant(tChineseNameTextBox.Text);
                p.setDescriptionEnUs(engDescTextBox.Text);
                p.setDescriptionZhHant(tChiDescTextBox.Text);
                p.setPhoto(productPhotoBox.Image);
                p.setSupplierID(supplierID);
                p.setQtyInStock(int.Parse(quantityTextBox.Text));
                p.setPrice(int.Parse(priceTextBox.Text));
                p.setReleaseDate(DateTime.Now.Date);

                int i = ppda.insert(p, conn);
                if (i > 0)
                {
                    packageListDataGridView.Rows.Add(
                        false,
                        p.getProductID(),
                        p.getProductNameEnUs(),
                        p.getProductNameZhHant(),
                        p.getDescriptionEnUs(),
                        p.getDescriptionZhHant(),
                        p.getQtyInStock(),
                        rs.GetString("hkdText") + p.getPrice().ToString(),
                        p.getReleaseDate().ToLongDateString());

                    packageListDataGridView.ClearSelection();
                    foreach (DataGridViewRow row in packageListDataGridView.Rows)
                    {
                        if (packageIdTextBox.Text.Equals(row.Cells["packageIdColumn"].Value.ToString()))
                        {
                            row.Selected = true;
                            packageListDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        }
                    }

                    addButton.Enabled = false;
                    updateButton.Enabled = true;

                    productList.Clear();
                    productList = null;
                    productList = ppda.findProductPackagesBySupplierID(supplierID, Language.getLanguageCode(), conn);

                    MessageBox.Show(rs.GetString("addNewProductSuccessMsg"));

                    packageDataResetButton.Enabled = true;
                    deleteButton.Enabled = true;
                    deselectAllButton.Enabled = true;
                    selectAllButton.Enabled = true;
                }
                else
                    MessageBox.Show(rs.GetString("addNewProductFailMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            bool isInputCorrect = this.isInputCorrect();

            if (isInputCorrect)
            {
                Package p = ppda.getOneProductPackageByID(packageIdTextBox.Text, Language.getLanguageCode(), conn);
                p.setProductNameEnUs(englishNameTextBox.Text);
                p.setProductNameZhHant(tChineseNameTextBox.Text);
                p.setDescriptionEnUs(engDescTextBox.Text);
                p.setDescriptionZhHant(tChiDescTextBox.Text);
                p.setPhoto(productPhotoBox.Image);
                p.setSupplierID(supplierID);
                p.setQtyInStock(int.Parse(quantityTextBox.Text));
                p.setPrice(int.Parse(priceTextBox.Text));

                int i = ppda.update(p, conn);
                if (i > 0)
                {
                    foreach (DataGridViewRow row in packageListDataGridView.Rows)
                    {
                        if (packageIdTextBox.Text.Equals(row.Cells["packageIdColumn"].Value.ToString()))
                        {
                            row.Cells["engNameColumn"].Value = englishNameTextBox.Text;
                            row.Cells["tChiNameColumn"].Value = tChineseNameTextBox.Text;
                            row.Cells["engDescriptionColumn"].Value = engDescTextBox.Text;
                            row.Cells["tChiDescriptionColumn"].Value = tChiDescTextBox.Text;
                            row.Cells["quantityColumn"].Value = quantityTextBox.Text;
                            row.Cells["priceColumn"].Value = rs.GetString("hkdText") + priceTextBox.Text;
                        }
                    }

                    showedStockAlertPackage.Remove(p.getProductID());
                    setting.Save();

                    productList.Clear();
                    productList = null;
                    productList = ppda.findProductPackagesBySupplierID(supplierID, Language.getLanguageCode(), conn);

                    MessageBox.Show(rs.GetString("updateProductSuccessMsg"));
                }
                else
                    MessageBox.Show(rs.GetString("updateProductFailMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchPriceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((MetroRadioButton)sender).Name.Equals("searchPriceRangeRadioButton"))
            {
                searchPriceToLabel.Enabled = true;
                searchPriceFormTextBox.Enabled = true;
                searchPriceToTextBox.Enabled = true;
            }
            else if (((MetroRadioButton)sender).Name.Equals("searchPriceAllRadioButton"))
            {
                searchPriceToLabel.Enabled = false;
                searchPriceFormTextBox.Enabled = false;
                searchPriceToTextBox.Enabled = false;
            }
        }

        private void searchPriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchPriceFormTextBox.Text) && !string.IsNullOrWhiteSpace(searchPriceToTextBox.Text))
            {
                if (((MetroTextBox)sender).Name.Equals("searchPriceFormTextBox"))
                    if (int.Parse(searchPriceFormTextBox.Text) <= 0 || string.IsNullOrWhiteSpace(searchPriceFormTextBox.Text))
                        searchPriceFormTextBox.Text = "1";
                    else if (int.Parse(searchPriceFormTextBox.Text) > int.Parse(searchPriceToTextBox.Text))
                        searchPriceFormTextBox.Text = searchPriceToTextBox.Text;

                if (((MetroTextBox)sender).Name.Equals("searchPriceToTextBox"))
                    if (int.Parse(searchPriceToTextBox.Text) > 300 || string.IsNullOrWhiteSpace(searchPriceToTextBox.Text))
                        searchPriceToTextBox.Text = "300";
                    else if (int.Parse(searchPriceToTextBox.Text) < int.Parse(searchPriceFormTextBox.Text))
                        searchPriceToTextBox.Text = searchPriceFormTextBox.Text;
            }
        }

        private void searchReleaseDateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((MetroRadioButton)sender).Name.Equals("searchReleaseDateRangeRadioButton"))
            {
                searchReleaseToLabel.Enabled = true;
                searchReleaseFromDateTime.Enabled = true;
                searchReleaseToDateTime.Enabled = true;
            }
            else if (((MetroRadioButton)sender).Name.Equals("searchReleaseDateAllRadioButton"))
            {
                searchReleaseToLabel.Enabled = false;
                searchReleaseFromDateTime.Enabled = false;
                searchReleaseToDateTime.Enabled = false;
            }
        }

        private void searchReleaseDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (searchReleaseFromDateTime.Value.Date > searchReleaseToDateTime.Value.Date)
            {
                if (((MetroDateTime)sender).Name.Equals("searchReleaseFromDateTime"))
                    searchReleaseFromDateTime.Value = searchReleaseToDateTime.Value.Date;
                else if (((MetroDateTime)sender).Name.Equals("searchReleaseToDateTime"))
                    searchReleaseToDateTime.Value = searchReleaseFromDateTime.Value.Date;
            }
        }

        private void searchResetButton_Click(object sender, EventArgs e)
        {
            searchPackageIdTextBox.Text = "";

            searchPriceFormTextBox.Text = "1";
            searchPriceToTextBox.Text = "300";
            searchPriceToLabel.Enabled = false;
            searchPriceFormTextBox.Enabled = false;
            searchPriceToTextBox.Enabled = false;
            searchPriceRangeRadioButton.Checked = false;
            searchPriceAllRadioButton.Checked = true;

            searchKeywordTextBox.Text = "";

            searchReleaseFromDateTime.Value = DateTime.Now.Date.AddMonths(-18);
            searchReleaseToDateTime.Value = DateTime.Now.Date;
            searchReleaseToLabel.Enabled = false;
            searchReleaseFromDateTime.Enabled = false;
            searchReleaseToDateTime.Enabled = false;
            searchReleaseDateRangeRadioButton.Checked = false;
            searchReleaseDateAllRadioButton.Checked = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            packageListDataGridView.Rows.Clear();
            packageListDataGridView.Refresh();

            if (productList != null)
                foreach (Package package in productList)
                    if ((package.getProductID().ToUpper()).Contains(searchPackageIdTextBox.Text.ToUpper()) &&
                        ((package.getProductNameEnUs().ToLower()).Contains(searchKeywordTextBox.Text.ToLower()) ||
                        (package.getProductNameZhHant()).Contains(searchKeywordTextBox.Text) ||
                        (package.getDescriptionEnUs().ToLower()).Contains(searchKeywordTextBox.Text.ToLower()) ||
                        (package.getDescriptionZhHant()).Contains(searchKeywordTextBox.Text)) &&
                        ((searchReleaseDateRangeRadioButton.Checked && searchReleaseFromDateTime.Value.Date <= package.getReleaseDate().Date && searchReleaseToDateTime.Value.Date >= package.getReleaseDate().Date) ||
                        searchReleaseDateAllRadioButton.Checked) &&
                        ((searchPriceRangeRadioButton.Checked && int.Parse(searchPriceFormTextBox.Text) <= package.getPrice() && int.Parse(searchPriceToTextBox.Text) >= package.getPrice()) ||
                        searchPriceAllRadioButton.Checked))
                    {
                        packageListDataGridView.Rows.Add(
                            false,
                            package.getProductID(),
                            package.getProductNameEnUs(),
                            package.getProductNameZhHant(),
                            package.getDescriptionEnUs(),
                            package.getDescriptionZhHant(),
                            package.getQtyInStock(),
                            rs.GetString("hkdText") + package.getPrice().ToString(),
                            package.getReleaseDate().ToLongDateString());
                    }

            packageListDataGridView.ClearSelection();

            if (packageListDataGridView.Rows.Count > 0)
            {
                packageDataResetButton.Enabled = true;
                deleteButton.Enabled = true;
                deselectAllButton.Enabled = true;
                selectAllButton.Enabled = true;

                foreach (DataGridViewRow row in packageListDataGridView.Rows)
                {
                    if (packageIdTextBox.Text.Equals(row.Cells["packageIdColumn"].Value.ToString()))
                        row.Selected = true;
                }
            }
            else
            {
                packageDataResetButton.Enabled = false;
                deleteButton.Enabled = false;
                deselectAllButton.Enabled = false;
                selectAllButton.Enabled = false;
            }
        }

        private void packageListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                addButton.Enabled = false;
                updateButton.Enabled = true;
                Package p = ppda.getOneProductPackageByID(packageListDataGridView.Rows[e.RowIndex].Cells["packageIdColumn"].Value.ToString(), Language.getLanguageCode(), conn);
                packageIdTextBox.Text = p.getProductID();
                englishNameTextBox.Text = p.getProductNameEnUs();
                tChineseNameTextBox.Text = p.getProductNameZhHant();
                quantityTextBox.Text = p.getQtyInStock().ToString();
                priceTextBox.Text = p.getPrice().ToString();
                engDescTextBox.Text = p.getDescriptionEnUs();
                tChiDescTextBox.Text = p.getDescriptionZhHant();
                productPhotoBox.Image = p.getPhoto();
            }
        }

        private void packageDataResetButton_Click(object sender, EventArgs e)
        {
            packageListDataGridView.Rows.Clear();
            packageListDataGridView.Refresh();

            packageDataResetButton.Enabled = false;
            deleteButton.Enabled = false;
            deselectAllButton.Enabled = false;
            selectAllButton.Enabled = false;
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(rs.GetString("deleteYesNoMsg"), rs.GetString("deleteTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = 0;

                for (int i = packageListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)packageListDataGridView.Rows[i].Cells["selectedProductColumn"].Value;
                    if (delete == true)
                    {
                        ppda.delete((string)packageListDataGridView.Rows[i].Cells["packageIdColumn"].Value, conn);
                        packageListDataGridView.Rows.Remove(packageListDataGridView.Rows[i]);
                        count++;
                    }
                }

                if (count == 0)
                    MessageBox.Show(rs.GetString("selectProcuctMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (packageListDataGridView.Rows.Count > 0)
                    {
                        packageDataResetButton.Enabled = false;
                        deleteButton.Enabled = true;
                        deselectAllButton.Enabled = true;
                        selectAllButton.Enabled = true;
                    }
                    else
                    {
                        packageDataResetButton.Enabled = false;
                        deleteButton.Enabled = false;
                        deselectAllButton.Enabled = false;
                        selectAllButton.Enabled = false;
                    }

                    packageListDataGridView.ClearSelection();

                    resetButton_Click(null, null);

                    MessageBox.Show(rs.GetString("deleteMsg"));
                }
            }
        }

        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }
    }
}
