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

namespace BackendForSupplier.BottleSupplierForm
{
    public partial class BottleManagementUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForSupplier.Properties.Resources", typeof(BottleManagementUserCtrl).Assembly);

        private static Properties.Settings setting = Properties.Settings.Default;
        StringCollection showedStockAlertBottle = setting.showedStockAlertBottle;

        private ProductBottleDA pbda = new ProductBottleDA();
        private string supplierID = null;
        private List<Bottle> productList = null;

        public BottleManagementUserCtrl(string supplierID)
        {
            InitializeComponent();

            this.supplierID = supplierID;
            productList = pbda.findProductBottlesBySupplierID(supplierID, Language.getLanguageCode(), conn);

            genBottleID();

            searchPriceFormTextBox.Text = "1";
            searchPriceToTextBox.Text = "300";

            searchCapacityFormTextBox.Text = "5";
            searchCapacityToTextBox.Text = "200";

            searchReleaseFromDateTime.Value = DateTime.Now.Date.AddMonths(-18);
            searchReleaseToDateTime.Value = DateTime.Now.Date;
        }

        private void genBottleID()
        {
            string existBottle = null;
            Random rnd = new Random();
            string id = "BL" + rnd.Next(100000, 999999);
            Bottle p = pbda.getOneProductBottleByID(id, Language.getLanguageCode(), conn);
            existBottle = p.getProductID();
            Bottle db = pbda.getOneDeletedBottleByID(id, Language.getLanguageCode(), conn);
            existBottle = db.getProductID();

            if (existBottle != null)
                genBottleID();
            else
                bottleIdTextBox.Text = id;
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

            if (string.IsNullOrWhiteSpace(capacityTextBox.Text) || !(int.Parse(capacityTextBox.Text) >= 5 && int.Parse(capacityTextBox.Text) <= 200))
            {
                capacityErrorLabel.ForeColor = Color.Red;
                correct = false;
            }
            else
            {
                capacityErrorLabel.ForeColor = SystemColors.ControlText;
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
            bottleListDataGridView.ClearSelection();
            addButton.Enabled = true;
            updateButton.Enabled = false;
            genBottleID();
            englishNameTextBox.Clear();
            tChineseNameTextBox.Clear();
            quantityTextBox.Clear();
            priceTextBox.Clear();
            capacityTextBox.Clear();
            engDescTextBox.Clear();
            tChiDescTextBox.Clear();
            productPhotoBox.Image = null;
            productPhotoBox.Invalidate();
            bottleIdHintLabel.Visible = true;

            englishNameErrorLabel.Visible = false;
            tChineseNameErrorLabel.Visible = false;
            quantityErrorLabel.ForeColor = SystemColors.ControlText;
            priceErrorLabel.ForeColor = SystemColors.ControlText;
            capacityErrorLabel.ForeColor = SystemColors.ControlText;
            engDescErrorLabel.Visible = false;
            tChiDescErrorLabel.Visible = false;
            photoErrorLabel.ForeColor = SystemColors.ControlText;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool isInputCorrect = this.isInputCorrect();

            if (isInputCorrect)
            {
                Bottle b = new Bottle();
                b.setProductID(bottleIdTextBox.Text);
                b.setProductNameEnUs(englishNameTextBox.Text);
                b.setProductNameZhHant(tChineseNameTextBox.Text);
                b.setDescriptionEnUs(engDescTextBox.Text);
                b.setDescriptionZhHant(tChiDescTextBox.Text);
                b.setPhoto(productPhotoBox.Image);
                b.setSupplierID(supplierID);
                b.setQtyInStock(Convert.ToInt32(quantityTextBox.Text));
                b.setPrice(Convert.ToInt32(priceTextBox.Text));
                b.setBottleCapacity(Convert.ToInt32(capacityTextBox.Text));
                b.setReleaseDate(DateTime.Now);

                int i = pbda.insert(b, conn);
                if (i > 0)
                {
                    bottleListDataGridView.Rows.Add(
                        false,
                        b.getProductID(),
                        b.getProductNameEnUs(),
                        b.getProductNameZhHant(),
                        b.getDescriptionEnUs(),
                        b.getDescriptionZhHant(),
                        b.getBottleCapacity().ToString() + " " + rs.GetString("mlText"),
                        b.getQtyInStock(),
                        rs.GetString("hkdText") + b.getPrice().ToString(),
                        b.getReleaseDate().ToLongDateString());

                    bottleListDataGridView.ClearSelection();
                    foreach (DataGridViewRow row in bottleListDataGridView.Rows)
                    {
                        if (bottleIdTextBox.Text.Equals(row.Cells["bottleIdColumn"].Value.ToString()))
                        {
                            row.Selected = true;
                            bottleListDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        }
                    }

                    addButton.Enabled = false;
                    updateButton.Enabled = true;

                    productList.Clear();
                    productList = null;
                    productList = pbda.findProductBottlesBySupplierID(supplierID, Language.getLanguageCode(), conn);

                    MessageBox.Show(rs.GetString("addNewProductSuccessMsg"));

                    bottleDataResetButton.Enabled = true;
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
                Bottle b = pbda.getOneProductBottleByID(bottleIdTextBox.Text, Language.getLanguageCode(), conn);
                b.setProductNameEnUs(englishNameTextBox.Text);
                b.setProductNameZhHant(tChineseNameTextBox.Text);
                b.setDescriptionEnUs(engDescTextBox.Text);
                b.setDescriptionZhHant(tChiDescTextBox.Text);
                b.setPhoto(productPhotoBox.Image);
                b.setSupplierID(supplierID);
                b.setQtyInStock(Convert.ToInt32(quantityTextBox.Text));
                b.setPrice(Convert.ToInt32(priceTextBox.Text));
                b.setBottleCapacity(Convert.ToInt32(capacityTextBox.Text));

                int i = pbda.update(b, conn);
                if (i > 0)
                {
                    foreach (DataGridViewRow row in bottleListDataGridView.Rows)
                    {
                        if (bottleIdTextBox.Text.Equals(row.Cells["bottleIdColumn"].Value.ToString()))
                        {
                            row.Cells["engNameColumn"].Value = englishNameTextBox.Text;
                            row.Cells["tChiNameColumn"].Value = tChineseNameTextBox.Text;
                            row.Cells["engDescriptionColumn"].Value = engDescTextBox.Text;
                            row.Cells["tChiDescriptionColumn"].Value = tChiDescTextBox.Text;
                            row.Cells["capacityColumn"].Value = capacityTextBox.Text+ " " + rs.GetString("mlText");
                            row.Cells["quantityColumn"].Value = quantityTextBox.Text;
                            row.Cells["priceColumn"].Value = rs.GetString("hkdText") + priceTextBox.Text;
                        }
                    }

                    showedStockAlertBottle.Remove(b.getProductID());
                    setting.Save();

                    productList.Clear();
                    productList = null;
                    productList = pbda.findProductBottlesBySupplierID(supplierID, Language.getLanguageCode(), conn);
                    
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



        private void searchCapacityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((MetroRadioButton)sender).Name.Equals("searchCapacityRangeRadioButton"))
            {
                searchCapacityToLabel.Enabled = true;
                searchCapacityFormTextBox.Enabled = true;
                searchCapacityToTextBox.Enabled = true;
            }
            else if (((MetroRadioButton)sender).Name.Equals("searchCapacityAllRadioButton"))
            {
                searchCapacityToLabel.Enabled = false;
                searchCapacityFormTextBox.Enabled = false;
                searchCapacityToTextBox.Enabled = false;
            }
        }

        private void searchCapacityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchCapacityFormTextBox.Text) && !string.IsNullOrWhiteSpace(searchCapacityToTextBox.Text))
            {
                if (((MetroTextBox)sender).Name.Equals("searchCapacityFormTextBox"))
                    if (int.Parse(searchCapacityFormTextBox.Text) < 5 || string.IsNullOrWhiteSpace(searchCapacityFormTextBox.Text))
                        searchCapacityFormTextBox.Text = "5";
                    else if (int.Parse(searchCapacityFormTextBox.Text) > int.Parse(searchCapacityToTextBox.Text))
                        searchCapacityFormTextBox.Text = searchCapacityToTextBox.Text;

                if (((MetroTextBox)sender).Name.Equals("searchCapacityToTextBox"))
                    if (int.Parse(searchCapacityToTextBox.Text) > 200 || string.IsNullOrWhiteSpace(searchCapacityToTextBox.Text))
                        searchCapacityToTextBox.Text = "200";
                    else if (int.Parse(searchCapacityToTextBox.Text) < int.Parse(searchCapacityFormTextBox.Text))
                        searchCapacityToTextBox.Text = searchCapacityFormTextBox.Text;
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

        }

        private void searchResetButton_Click(object sender, EventArgs e)
        {
            searchBottleIdTextBox.Text = "";

            searchPriceFormTextBox.Text = "1";
            searchPriceToTextBox.Text = "300";
            searchPriceToLabel.Enabled = false;
            searchPriceFormTextBox.Enabled = false;
            searchPriceToTextBox.Enabled = false;
            searchPriceRangeRadioButton.Checked = false;
            searchPriceAllRadioButton.Checked = true;

            searchCapacityFormTextBox.Text = "5";
            searchCapacityToTextBox.Text = "200";
            searchCapacityToLabel.Enabled = false;
            searchCapacityFormTextBox.Enabled = false;
            searchCapacityToTextBox.Enabled = false;
            searchCapacityRangeRadioButton.Checked = false;
            searchCapacityAllRadioButton.Checked = true;

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
            bottleListDataGridView.Rows.Clear();
            bottleListDataGridView.Refresh();

            if (productList != null)
                foreach (Bottle bottle in productList)
                    if ((bottle.getProductID().ToUpper()).Contains(searchBottleIdTextBox.Text.ToUpper()) &&
                        ((bottle.getProductNameEnUs().ToLower()).Contains(searchKeywordTextBox.Text.ToLower()) ||
                        (bottle.getProductNameZhHant()).Contains(searchKeywordTextBox.Text) ||
                        (bottle.getDescriptionEnUs().ToLower()).Contains(searchKeywordTextBox.Text.ToLower()) ||
                        (bottle.getDescriptionZhHant()).Contains(searchKeywordTextBox.Text)) &&
                        ((searchReleaseDateRangeRadioButton.Checked && searchReleaseFromDateTime.Value.Date <= bottle.getReleaseDate().Date && searchReleaseToDateTime.Value.Date >= bottle.getReleaseDate().Date) ||
                        searchReleaseDateAllRadioButton.Checked) &&
                        ((searchPriceRangeRadioButton.Checked && int.Parse(searchPriceFormTextBox.Text) <= bottle.getPrice() && int.Parse(searchPriceToTextBox.Text) >= bottle.getPrice()) ||
                        searchPriceAllRadioButton.Checked) &&
                        ((searchPriceRangeRadioButton.Checked && int.Parse(searchCapacityFormTextBox.Text) <= bottle.getPrice() && int.Parse(searchCapacityToTextBox.Text) >= bottle.getPrice()) ||
                        searchPriceAllRadioButton.Checked))
                    {
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
                            bottle.getReleaseDate().ToLongDateString());
                    }

            bottleListDataGridView.ClearSelection();

            if (bottleListDataGridView.Rows.Count > 0)
            {
                bottleDataResetButton.Enabled = true;
                deleteButton.Enabled = true;
                deselectAllButton.Enabled = true;
                selectAllButton.Enabled = true;

                foreach (DataGridViewRow row in bottleListDataGridView.Rows)
                {
                    if (bottleIdTextBox.Text.Equals(row.Cells["bottleIdColumn"].Value.ToString()))
                        row.Selected = true;
                }
            }
            else
            {
                bottleDataResetButton.Enabled = false;
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
                Bottle p = pbda.getOneProductBottleByID(bottleListDataGridView.Rows[e.RowIndex].Cells["bottleIdColumn"].Value.ToString(), Language.getLanguageCode(), conn);
                bottleIdTextBox.Text = p.getProductID();
                englishNameTextBox.Text = p.getProductNameEnUs();
                tChineseNameTextBox.Text = p.getProductNameZhHant();
                quantityTextBox.Text = p.getQtyInStock().ToString();
                priceTextBox.Text = p.getPrice().ToString();
                capacityTextBox.Text = p.getBottleCapacity().ToString();
                engDescTextBox.Text = p.getDescriptionEnUs();
                tChiDescTextBox.Text = p.getDescriptionZhHant();
                productPhotoBox.Image = p.getPhoto();
            }
        }

        private void bottleDataResetButton_Click(object sender, EventArgs e)
        {
            bottleListDataGridView.Rows.Clear();
            bottleListDataGridView.Refresh();

            bottleListDataGridView.Enabled = false;
            deleteButton.Enabled = false;
            deselectAllButton.Enabled = false;
            selectAllButton.Enabled = false;
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(rs.GetString("deleteYesNoMsg"), rs.GetString("deleteTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = 0;

                for (int i = bottleListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)bottleListDataGridView.Rows[i].Cells["selectedProductColumn"].Value;
                    if (delete == true)
                    {
                        pbda.delete((string)bottleListDataGridView.Rows[i].Cells["bottleIdColumn"].Value, conn);
                        bottleListDataGridView.Rows.Remove(bottleListDataGridView.Rows[i]);
                        count++;
                    }
                }

                if (count == 0)
                    MessageBox.Show(rs.GetString("selectProcuctMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (bottleListDataGridView.Rows.Count > 0)
                    {
                        bottleDataResetButton.Enabled = true;
                        deleteButton.Enabled = true;
                        deselectAllButton.Enabled = true;
                        selectAllButton.Enabled = true;
                    }
                    else
                    {
                        bottleDataResetButton.Enabled = false;
                        deleteButton.Enabled = false;
                        deselectAllButton.Enabled = false;
                        selectAllButton.Enabled = false;
                    }

                    bottleListDataGridView.ClearSelection();

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
