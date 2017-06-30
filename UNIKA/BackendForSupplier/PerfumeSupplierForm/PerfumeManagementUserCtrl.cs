using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System.Resources;
using BackendClassLibrary;
using System.IO;
using System.Collections.Specialized;

namespace BackendForSupplier.PerfumeSupplierForm
{
    public partial class PerfumeManagementUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForSupplier.Properties.Resources", typeof(PerfumeManagementUserCtrl).Assembly);

        private static Properties.Settings setting = Properties.Settings.Default;
        StringCollection showedStockAlertPerfume = setting.showedStockAlertPerfume;

        private ProductPerfumeDA ppda = new ProductPerfumeDA();
        private string supplierID = null;
        private List<Perfume> productList = null;

        public PerfumeManagementUserCtrl(string supplierID)
        {
            InitializeComponent();

            this.supplierID = supplierID;
            productList = ppda.findProductPerfumeBySupplierID(this.supplierID, Language.getLanguageCode(), conn);

            setCategoriesComboBox(categoryComboBox);
            setCategoriesComboBox(searchCategoryComboBox);

            searchPriceFormTextBox.Text = "1";
            searchPriceToTextBox.Text = "100";

            searchReleaseFromDateTime.Value = DateTime.Now.Date.AddMonths(-18);
            searchReleaseToDateTime.Value = DateTime.Now.Date;
        }

        public void setCategoriesComboBox(MetroComboBox comboBox)
        {
            //Create a Categories list
            BindingList<KeyValuePair<string, string>> categoriesList = new BindingList<KeyValuePair<string, string>>();

            //Clear the combox
            comboBox.DataSource = null;
            comboBox.Items.Clear();

            //Bind the combobox
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
            comboBox.DataSource = categoriesList;

            if (comboBox.Name.Equals("searchCategoryComboBox"))
                categoriesList.Add(new KeyValuePair<string, string>(rs.GetString("allText"), ""));

            //Get Categories form Database
            Dictionary<string, string> categoriesMap = ppda.getAllCategories(Language.getLanguageCode(), conn);
            foreach (var pair in categoriesMap)
                categoriesList.Add(new KeyValuePair<string, string>(pair.Key, pair.Value));

            if (comboBox.Name.Equals("searchCategoryComboBox"))
                comboBox.SelectedItem = "";
            else
                comboBox.SelectedItem = null;
        }

        private void genPerfumeID(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(categoryComboBox.Text))
            {
                string existPerfume = null;
                Random rnd = new Random();
                string id = categoryComboBox.SelectedValue.ToString() + rnd.Next(100000, 999999);
                Perfume p = ppda.getOneProductPerfumeByID(id, Language.getLanguageCode(), conn);
                existPerfume = p.getProductID();
                Perfume dp = ppda.getOneDeletedProductPerfumeByID(id, Language.getLanguageCode(), conn);
                existPerfume = dp.getProductID();

                if (existPerfume != null)
                    genPerfumeID(null, null);
                else
                    perfumeIdTextBox.Text = id;
            }
        }

        private bool isInputCorrect()
        {
            bool correct = true;

            if (string.IsNullOrWhiteSpace(categoryComboBox.Text))
            {
                categoryErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                categoryErrorLabel.Visible = false;
            }

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

            if (string.IsNullOrWhiteSpace(quantityTextBox.Text) || !(int.Parse(quantityTextBox.Text) >= 500))
            {
                quantityErrorLabel.ForeColor = Color.Red;
                correct = false;
            }
            else
            {
                quantityErrorLabel.ForeColor = SystemColors.ControlText;
            }

            if (string.IsNullOrWhiteSpace(priceTextBox.Text) || !(int.Parse(priceTextBox.Text) > 0 && int.Parse(priceTextBox.Text) <= 100))
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
            perfumeListDataGridView.ClearSelection();
            categoryComboBox.Enabled = true;
            addButton.Enabled = true;
            updateButton.Enabled = false;
            perfumeIdTextBox.Clear();
            englishNameTextBox.Clear();
            tChineseNameTextBox.Clear();
            quantityTextBox.Clear();
            priceTextBox.Clear();
            engDescTextBox.Clear();
            tChiDescTextBox.Clear();
            productPhotoBox.Image = null;
            productPhotoBox.Invalidate();
            categoryComboBox.SelectedItem = null;
            pefumeIdHintLabel.Visible = true;

            categoryErrorLabel.Visible = false;
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
                Perfume p = new Perfume();
                p.setProductID(perfumeIdTextBox.Text.Trim());
                p.setProductNameEnUs(englishNameTextBox.Text.Trim());
                p.setProductNameZhHant(tChineseNameTextBox.Text.Trim());
                p.setDescriptionEnUs(engDescTextBox.Text.Trim());
                p.setDescriptionZhHant(tChiDescTextBox.Text.Trim());
                p.setPhoto(productPhotoBox.Image);
                p.setSupplierID(supplierID);
                p.setQtyInStock(int.Parse(quantityTextBox.Text.Trim()));
                p.setPrice(int.Parse(priceTextBox.Text.Trim()));
                p.setCategoryCode(categoryComboBox.SelectedValue.ToString());
                p.setReleaseDate(DateTime.Now.Date);

                int i = ppda.insert(p, conn);
                if (i > 0)
                {
                    perfumeListDataGridView.Rows.Add(
                        false,
                        p.getProductID(),
                        p.getProductNameEnUs(),
                        p.getProductNameZhHant(),
                        p.getDescriptionEnUs(),
                        p.getDescriptionZhHant(),
                        categoryComboBox.Text,
                        p.getQtyInStock().ToString() + " " + rs.GetString("mlText"),
                        rs.GetString("hkdText") + p.getPrice().ToString(),
                        p.getReleaseDate().ToLongDateString());

                    perfumeListDataGridView.ClearSelection();
                    foreach (DataGridViewRow row in perfumeListDataGridView.Rows)
                    {
                        if (perfumeIdTextBox.Text.Equals(row.Cells["perfumeIdColumn"].Value.ToString()))
                        {
                            row.Selected = true;
                            perfumeListDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        }
                    }

                    perfumeDataResetButton.Enabled = true;
                    deleteButton.Enabled = true;
                    deselectAllButton.Enabled = true;
                    selectAllButton.Enabled = true;

                    categoryComboBox.Enabled = false;
                    addButton.Enabled = false;
                    updateButton.Enabled = true;
                    pefumeIdHintLabel.Visible = false;

                    productList.Clear();
                    productList = null;
                    productList = ppda.findProductPerfumeBySupplierID(supplierID, Language.getLanguageCode(), conn);

                    MessageBox.Show(rs.GetString("addNewProductSuccessMsg"));
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
                Perfume p = ppda.getOneProductPerfumeByID(perfumeIdTextBox.Text, Language.getLanguageCode(), conn);
                p.setProductNameEnUs(englishNameTextBox.Text.Trim());
                p.setProductNameZhHant(tChineseNameTextBox.Text.Trim());
                p.setDescriptionEnUs(engDescTextBox.Text.Trim());
                p.setDescriptionZhHant(tChiDescTextBox.Text.Trim());
                p.setPhoto(productPhotoBox.Image);
                p.setSupplierID(supplierID);
                p.setQtyInStock(int.Parse(quantityTextBox.Text.Trim()));
                p.setPrice(int.Parse(priceTextBox.Text.Trim()));
                p.setCategoryCode(categoryComboBox.SelectedValue.ToString());

                int i = ppda.update(p, conn);
                if (i > 0)
                {
                    foreach (DataGridViewRow row in perfumeListDataGridView.Rows)
                    {
                        if (perfumeIdTextBox.Text.Equals(row.Cells["perfumeIdColumn"].Value.ToString()))
                        {
                            row.Cells["engNameColumn"].Value = englishNameTextBox.Text;
                            row.Cells["tChiNameColumn"].Value = tChineseNameTextBox.Text;
                            row.Cells["engDescriptionColumn"].Value = engDescTextBox.Text;
                            row.Cells["tChiDescriptionColumn"].Value = tChiDescTextBox.Text;
                            row.Cells["quantityColumn"].Value = quantityTextBox.Text + " " + rs.GetString("mlText");
                            row.Cells["priceColumn"].Value = rs.GetString("hkdText") + priceTextBox.Text;
                        }
                    }

                    showedStockAlertPerfume.Remove(p.getProductID());
                    setting.Save();

                    productList.Clear();
                    productList = null;
                    productList = ppda.findProductPerfumeBySupplierID(supplierID, Language.getLanguageCode(), conn);

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
                    if (int.Parse(searchPriceToTextBox.Text) > 100 || string.IsNullOrWhiteSpace(searchPriceToTextBox.Text))
                        searchPriceToTextBox.Text = "100";
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
            searchPerfumeIdTextBox.Text = "";
            searchCategoryComboBox.SelectedValue = "";

            searchPriceFormTextBox.Text = "1";
            searchPriceToTextBox.Text = "300";
            searchPriceToLabel.Enabled = false;
            searchPriceFormTextBox.Enabled = false;
            searchPriceToTextBox.Enabled = false;
            searchPriceRangeRadioButton.Checked = false;
            searchPriceAllRadioButton.Checked = true;

            searchQtyBelow50CheckBox.Checked = false;
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

            perfumeListDataGridView.Rows.Clear();
            perfumeListDataGridView.Refresh();

            if (productList != null)
                foreach (Perfume perfume in productList)
                    if ((searchCategoryComboBox.Text.Equals(perfume.getCategory()) || string.IsNullOrWhiteSpace((string)searchCategoryComboBox.SelectedValue)) &&
                        (perfume.getProductID().ToUpper()).Contains(searchPerfumeIdTextBox.Text.ToUpper()) &&
                        ((perfume.getProductNameEnUs().ToLower()).Contains(searchKeywordTextBox.Text.ToLower()) ||
                        (perfume.getProductNameZhHant()).Contains(searchKeywordTextBox.Text) ||
                        (perfume.getDescriptionEnUs().ToLower()).Contains(searchKeywordTextBox.Text.ToLower()) ||
                        (perfume.getDescriptionZhHant()).Contains(searchKeywordTextBox.Text)) &&
                        ((searchReleaseDateRangeRadioButton.Checked && searchReleaseFromDateTime.Value.Date <= perfume.getReleaseDate().Date && searchReleaseToDateTime.Value.Date >= perfume.getReleaseDate().Date) ||
                        searchReleaseDateAllRadioButton.Checked) &&
                        ((searchPriceRangeRadioButton.Checked && int.Parse(searchPriceFormTextBox.Text) <= perfume.getPrice() && int.Parse(searchPriceToTextBox.Text) >= perfume.getPrice()) ||
                        searchPriceAllRadioButton.Checked) &&
                        ((perfume.getQtyInStock() < 50 && searchQtyBelow50CheckBox.Checked) || (perfume.getQtyInStock() >= 50 && !searchQtyBelow50CheckBox.Checked)))
                    {
                        perfumeListDataGridView.Rows.Add(
                            false,
                            perfume.getProductID(),
                            perfume.getProductNameEnUs(),
                            perfume.getProductNameZhHant(),
                            perfume.getDescriptionEnUs(),
                            perfume.getDescriptionZhHant(),
                            perfume.getCategory(),
                            perfume.getQtyInStock().ToString() + " " + rs.GetString("mlText"),
                            rs.GetString("hkdText") + perfume.getPrice().ToString(),
                            perfume.getReleaseDate().ToLongDateString());
                    }

            perfumeListDataGridView.ClearSelection();

            if (perfumeListDataGridView.Rows.Count > 0)
            {
                perfumeDataResetButton.Enabled = true;
                deleteButton.Enabled = true;
                deselectAllButton.Enabled = true;
                selectAllButton.Enabled = true;

                foreach (DataGridViewRow row in perfumeListDataGridView.Rows)
                {
                    if (perfumeIdTextBox.Text.Equals(row.Cells["perfumeIdColumn"].Value.ToString()))
                        row.Selected = true;
                }
            }
            else
            {
                perfumeDataResetButton.Enabled = false;
                deleteButton.Enabled = false;
                deselectAllButton.Enabled = false;
                selectAllButton.Enabled = false;
            }

        }

        private void perfumeListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                categoryComboBox.Enabled = false;
                addButton.Enabled = false;
                updateButton.Enabled = true;
                pefumeIdHintLabel.Visible = false;
                Perfume p = ppda.getOneProductPerfumeByID(perfumeListDataGridView.Rows[e.RowIndex].Cells["perfumeIdColumn"].Value.ToString(), Language.getLanguageCode(), conn);
                categoryComboBox.Text = p.getCategory();
                perfumeIdTextBox.Text = p.getProductID();
                englishNameTextBox.Text = p.getProductNameEnUs();
                tChineseNameTextBox.Text = p.getProductNameZhHant();
                quantityTextBox.Text = p.getQtyInStock().ToString();
                priceTextBox.Text = p.getPrice().ToString();
                engDescTextBox.Text = p.getDescriptionEnUs();
                tChiDescTextBox.Text = p.getDescriptionZhHant();
                productPhotoBox.Image = p.getPhoto();
            }
        }

        private void perfumeDataResetButton_Click(object sender, EventArgs e)
        {
            perfumeListDataGridView.Rows.Clear();
            perfumeListDataGridView.Refresh();

            perfumeDataResetButton.Enabled = false;
            deleteButton.Enabled = false;
            deselectAllButton.Enabled = false;
            selectAllButton.Enabled = false;
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in perfumeListDataGridView.Rows)
            {
                if (!(bool)row.Cells["selectedProductColumn"].Value)
                {
                    row.Cells["selectedProductColumn"].Value = true;
                }
            }
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in perfumeListDataGridView.Rows)
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

                for (int i = perfumeListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)perfumeListDataGridView.Rows[i].Cells["selectedProductColumn"].Value;
                    if (delete == true)
                    {
                        ppda.delete((string)perfumeListDataGridView.Rows[i].Cells["perfumeIdColumn"].Value, conn);
                        perfumeListDataGridView.Rows.Remove(perfumeListDataGridView.Rows[i]);
                        count++;
                    }
                }

                if (count == 0)
                    MessageBox.Show(rs.GetString("selectProcuctMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (perfumeListDataGridView.Rows.Count > 0)
                    {
                        perfumeDataResetButton.Enabled = true;
                        deleteButton.Enabled = true;
                        deselectAllButton.Enabled = true;
                        selectAllButton.Enabled = true;
                    }
                    else
                    {
                        perfumeDataResetButton.Enabled = false;
                        deleteButton.Enabled = false;
                        deselectAllButton.Enabled = false;
                        selectAllButton.Enabled = false;
                    }

                    perfumeListDataGridView.ClearSelection();

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