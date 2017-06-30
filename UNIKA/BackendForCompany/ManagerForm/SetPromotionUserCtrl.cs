using BackendClassLibrary;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Resources;

namespace BackendForCompany.ManagerForm
{
    public partial class SetPromotionUserCtrl : MetroUserControl
    {
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(SetPromotionUserCtrl).Assembly);

        private MySqlConnection conn = Database.getConnection();

        private DiscountDA dda = new DiscountDA();
        private ProductBottleDiscountDA pbdda = new ProductBottleDiscountDA();
        private ProductPackageDiscountDA ppgdda = new ProductPackageDiscountDA();
        private ProductPerfumeDiscountDA ppdda = new ProductPerfumeDiscountDA();

        private ProductBottleDA pbda = new ProductBottleDA();
        private ProductPackageDA ppgda = new ProductPackageDA();
        private ProductPerfumeDA ppda = new ProductPerfumeDA();

        private string staffID = null;

        private string selectedDiscountCode = null;

        private string comboxCurrentSelectedPerfumeCategory = "";

        public SetPromotionUserCtrl(string staffID)
        {
            InitializeComponent();
            this.staffID = staffID;

            setProductCategoriesComboBox();
            setPerfumeCategoriesComboBox();

            startDateTime.MaxDate = DateTime.Now.Date;
            startDateTime.Value = startDateTime.MaxDate;
            endDateTime.MinDate = DateTime.Now.Date.AddDays(2).AddMilliseconds(-1);
            endDateTime.Value = endDateTime.MinDate;
        }

        public void setProductCategoriesComboBox()
        {
            //Create a Categories list
            BindingList<KeyValuePair<string, string>> categoriesList = new BindingList<KeyValuePair<string, string>>();

            //Clear the combox
            productCategoriesComboBox.DataSource = null;
            productCategoriesComboBox.Items.Clear();

            //Bind the combobox
            productCategoriesComboBox.DisplayMember = "Key";
            productCategoriesComboBox.ValueMember = "Value";
            productCategoriesComboBox.DataSource = categoriesList;

            //Set Product Categories
            categoriesList.Add(new KeyValuePair<string, string>(rs.GetString("perfumeText"), "perfume"));
            categoriesList.Add(new KeyValuePair<string, string>(rs.GetString("bottleText"), "bottle"));
            categoriesList.Add(new KeyValuePair<string, string>(rs.GetString("packageText"), "package"));

            productCategoriesComboBox.SelectedValue = "perfume";
        }

        public void setPerfumeCategoriesComboBox()
        {
            //Create a Categories list
            BindingList<KeyValuePair<string, string>> categoriesList = new BindingList<KeyValuePair<string, string>>();

            //Clear the combox
            perfumeCategoriesComboBox.DataSource = null;
            perfumeCategoriesComboBox.Items.Clear();

            //Bind the combobox
            perfumeCategoriesComboBox.DisplayMember = "Key";
            perfumeCategoriesComboBox.ValueMember = "Value";
            perfumeCategoriesComboBox.DataSource = categoriesList;

            //Get Categories form Database
            categoriesList.Add(new KeyValuePair<string, string>(rs.GetString("allText"), ""));

            Dictionary<string, string> categoriesMap = ppda.getAllCategories(Language.getLanguageCode(), conn);
            foreach (var pair in categoriesMap)
                categoriesList.Add(new KeyValuePair<string, string>(pair.Key, pair.Value));

            perfumeCategoriesComboBox.SelectedValue = "";
        }

        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            if (((MetroDateTime)sender).Name == "startDateTime")
            {
                endDateTime.MinDate = startDateTime.Value.Date.AddDays(2).AddMilliseconds(-1);
            }
            else if (((MetroDateTime)sender).Name == "endDateTime")
            {
                startDateTime.MaxDate = endDateTime.Value.Date.AddDays(-1);
            }
        }

        private bool isInputCorrect()
        {
            bool correct = true;

            Regex titleFormat = new Regex("^[ a-zA-Z0-9,.():]+$");

            if (string.IsNullOrWhiteSpace(engTitleTextBox.Text) || !titleFormat.IsMatch(engTitleTextBox.Text))
            {
                engTitleHintLabel.ForeColor = Color.Red;
                correct = false;
            }
            else
            {
                engTitleHintLabel.ForeColor = SystemColors.ControlText;
            }

            if (string.IsNullOrWhiteSpace(tradChiTitleTextBox.Text) || !FormatChecker.includeChineseChar(tradChiTitleTextBox.Text))
            {
                tradChiTitleHintLabel.ForeColor = Color.Red;
                correct = false;
            }
            else
            {
                tradChiTitleHintLabel.ForeColor = SystemColors.ControlText;
            }

            int discountRate;
            if (string.IsNullOrWhiteSpace(discountRateTextBox.Text) || !int.TryParse(discountRateTextBox.Text, out discountRate) || int.Parse(discountRateTextBox.Text) < 5 || int.Parse(discountRateTextBox.Text) > 90)
            {
                discountRateHintLabel.ForeColor = Color.Red;
                correct = false;
            }
            else
            {
                discountRateHintLabel.ForeColor = SystemColors.ControlText;
            }

            return correct;
        }

        private void resetFormButton_Click(object sender, EventArgs e)
        {
            engTitleHintLabel.ForeColor = SystemColors.ControlText;
            tradChiTitleHintLabel.ForeColor = SystemColors.ControlText;
            discountRateHintLabel.ForeColor = SystemColors.ControlText;

            addButton.Enabled = true;
            updateButton.Enabled = false;

            discountListDataGridView.ClearSelection();

            selectedDiscountCode = null;
            engTitleTextBox.Clear();
            tradChiTitleTextBox.Clear();
            discountRateTextBox.Clear();
            startDateTime.MaxDate = DateTime.Now.Date;
            startDateTime.Value = startDateTime.MaxDate;
            endDateTime.MinDate = DateTime.Now.Date.AddDays(2).AddMilliseconds(-1);
            endDateTime.Value = endDateTime.MinDate;

            productCategoriesComboBox.SelectedValue = "perfume";
            perfumeCategoriesComboBox.SelectedValue = "";

            nonDiscountProductDataGridView.Rows.Clear();
            nonDiscountProductDataGridView.Refresh();
            nonDiscountProductDataGridView.ClearSelection();

            discountProductDataGridView.Rows.Clear();
            discountProductDataGridView.Refresh();
            discountProductDataGridView.ClearSelection();

            productCategoriesComboBox.Enabled = false;
            perfumeCategoriesComboBox.Enabled = false;

            nonDiscountProductDataGridView.Enabled = false;
            nonDiscountSelectAllButton.Enabled = false;
            nonDiscountDeselectAllButton.Enabled = false;
            nonDiscountAddButton.Enabled = false;

            discountProductDataGridView.Enabled = false;
            discountSelectAllButton.Enabled = false;
            discountDeselectAllButton.Enabled = false;
            discountDeleteButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isInputCorrect())
            {
                Random rnd = new Random();

                Discount discount = new Discount();
                discount.setDiscountCode("D"+ rnd.Next(100000000, 999999999));
                discount.setTitleEnUs(engTitleTextBox.Text);
                discount.setTitleZhHant(tradChiTitleTextBox.Text);
                discount.setDiscount(int.Parse(discountRateTextBox.Text));
                discount.setStartDate(startDateTime.Value.Date);
                discount.setEndDate(endDateTime.Value.Date.AddDays(1).AddMilliseconds(-1));

                selectedDiscountCode = discount.getDiscountCode();

                int i = dda.insert(discount, conn);
                if (i > 0)
                {
                    discountListDataGridView.Rows.Add(false, discount.getDiscountCode(), discount.getTitleEnUs(), discount.getTitleZhHant(),
                        discount.getDiscount() + "% OFF", discount.getStartDate().ToShortDateString(), discount.getEndDate().ToShortDateString());

                    discountListDataGridView.ClearSelection();
                    foreach (DataGridViewRow row in discountListDataGridView.Rows)
                    {
                        if (selectedDiscountCode.Equals(row.Cells["discountCodeColumn"].Value.ToString()))
                        {
                            row.Selected = true;
                            discountListDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        }
                    }

                    discountListSelectAllButton.Enabled = true;
                    discountListDeselectAllButton.Enabled = true;
                    discountListDeleteButton.Enabled = true;

                    addButton.Enabled = false;
                    updateButton.Enabled = true;

                    MessageBox.Show(rs.GetString("addSuccessMsg"));
                }
                else
                    MessageBox.Show(rs.GetString("failToAddMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (isInputCorrect())
            {
                Discount discount = dda.getOneDiscountByCode(selectedDiscountCode, Language.getLanguageCode(), conn);
                discount.setTitleEnUs(engTitleTextBox.Text);
                discount.setTitleZhHant(tradChiTitleTextBox.Text);
                discount.setDiscount(int.Parse(discountRateTextBox.Text));
                discount.setStartDate(startDateTime.Value.Date);
                discount.setEndDate(endDateTime.Value.Date.AddDays(1).AddMilliseconds(-1));

                int i = dda.update(discount, conn);
                if (i > 0)
                {
                    foreach (DataGridViewRow row in discountListDataGridView.Rows)
                    {
                        if (row.Cells["discountCodeColumn"].Value.ToString().Equals(selectedDiscountCode))
                        {
                            row.Cells["engTitleColumn"].Value = discount.getTitleEnUs();
                            row.Cells["tradChiTitleColumn"].Value = discount.getTitleZhHant();
                            row.Cells["discountRateColumn"].Value = discount.getDiscount()+"% OFF";
                            row.Cells["startDateColumn"].Value = discount.getStartDate().ToShortDateString();
                            row.Cells["endDateColumn"].Value = discount.getEndDate().ToShortDateString();
                        }
                    }
                    MessageBox.Show(rs.GetString("updateSuccessMsg"));
                }
            }
            else
                MessageBox.Show(rs.GetString("failToUpdateMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            discountListDataGridView.Rows.Clear();
            discountListDataGridView.Refresh();

            List<Discount> discountList = dda.getAllDiscount(Language.getLanguageCode(), conn);
            foreach (Discount discount in discountList)
                if (!string.IsNullOrWhiteSpace(keywordTextBox.Text) && ((discount.getTitleEnUs().ToLower()).Contains(keywordTextBox.Text.ToLower()) || discount.getTitleZhHant().Contains(keywordTextBox.Text)))
                    discountListDataGridView.Rows.Add(false, discount.getDiscountCode(), discount.getTitleEnUs(), discount.getTitleZhHant(),
                        discount.getDiscount() + "% OFF", discount.getStartDate().ToShortDateString(), discount.getEndDate().ToShortDateString());


            discountListDataGridView.ClearSelection();

            if (discountListDataGridView.Rows.Count > 0)
            {
                discountListSelectAllButton.Enabled = true;
                discountListDeselectAllButton.Enabled = true;
                discountListDeleteButton.Enabled = true;

                foreach (DataGridViewRow row in discountListDataGridView.Rows)
                {
                    if (row.Cells["discountCodeColumn"].Value.ToString().Equals(selectedDiscountCode))
                        row.Selected = true;
                }
            }
            else
            {
                discountListSelectAllButton.Enabled = false;
                discountListDeselectAllButton.Enabled = false;
                discountListDeleteButton.Enabled = false;
            }
        }

        private void searchAllButton_Click(object sender, EventArgs e)
        {
            discountListDataGridView.Rows.Clear();
            discountListDataGridView.Refresh();

            List<Discount> discountList = dda.getAllDiscount(Language.getLanguageCode(), conn);
            foreach (Discount discount in discountList)
                discountListDataGridView.Rows.Add(false, discount.getDiscountCode(), discount.getTitleEnUs(), discount.getTitleZhHant(),
                    discount.getDiscount() + "% OFF", discount.getStartDate().ToShortDateString(), discount.getEndDate().ToShortDateString());


            discountListDataGridView.ClearSelection();

            if (discountListDataGridView.Rows.Count > 0)
            {
                discountListSelectAllButton.Enabled = true;
                discountListDeselectAllButton.Enabled = true;
                discountListDeleteButton.Enabled = true;

                foreach (DataGridViewRow row in discountListDataGridView.Rows)
                {
                    if (row.Cells["discountCodeColumn"].Value.ToString().Equals(selectedDiscountCode))
                        row.Selected = true;
                }
            }
            else
            {
                discountListSelectAllButton.Enabled = false;
                discountListDeselectAllButton.Enabled = false;
                discountListDeleteButton.Enabled = false;
            }
        }

        private void discountListResetButton_Click(object sender, EventArgs e)
        {
            discountListDataGridView.Rows.Clear();
            discountListDataGridView.Refresh();
            discountListDataGridView.ClearSelection();
            keywordTextBox.Clear();
        }

        private void discountListSelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in discountListDataGridView.Rows)
            {
                if (!(bool)row.Cells["selectedDiscountColumn"].Value)
                    row.Cells["selectedDiscountColumn"].Value = true;
            }
        }

        private void discountListDeselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in discountListDataGridView.Rows)
            {
                if ((bool)row.Cells["selectedDiscountColumn"].Value)
                    row.Cells["selectedDiscountColumn"].Value = false;
            }
        }

        private void discountListDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(rs.GetString("deleteDiscountYesNoMsg"), rs.GetString("deleteTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = 0;

                for (int i = discountListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)discountListDataGridView.Rows[i].Cells["selectedDiscountColumn"].Value;
                    if (delete == true)
                    {
                        dda.delete(discountListDataGridView.Rows[i].Cells["discountCodeColumn"].Value.ToString(), conn);
                        discountListDataGridView.Rows.Remove(discountListDataGridView.Rows[i]);
                        count++;
                    }
                }

                if (count == 0)
                    MessageBox.Show(rs.GetString("selectDiscountMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (discountListDataGridView.Rows.Count > 0)
                    {
                        discountListSelectAllButton.Enabled = true;
                        discountListDeselectAllButton.Enabled = true;
                        discountListDeleteButton.Enabled = true;
                    }
                    else
                    {
                        discountListSelectAllButton.Enabled = false;
                        discountListDeselectAllButton.Enabled = false;
                        discountListDeleteButton.Enabled = false;
                    }

                    discountListDataGridView.ClearSelection();

                    resetFormButton_Click(null, null);

                    MessageBox.Show(rs.GetString("deleteDiscountMsg"));
                }
            }
        }

        private void discountListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Discount discount = dda.getOneDiscountByCode(discountListDataGridView.Rows[e.RowIndex].Cells["discountCodeColumn"].Value.ToString(), Language.getLanguageCode(), conn);
                selectedDiscountCode = discount.getDiscountCode();
                engTitleTextBox.Text = discount.getTitleEnUs();
                tradChiTitleTextBox.Text = discount.getTitleZhHant();
                discountRateTextBox.Text = discount.getDiscount().ToString();
                startDateTime.MaxDate = discount.getStartDate();
                startDateTime.Value = startDateTime.MaxDate;
                endDateTime.MinDate = discount.getEndDate();
                endDateTime.Value = endDateTime.MinDate;

                addButton.Enabled = false;
                updateButton.Enabled = true;

                productCategoriesComboBox.SelectedValue = "perfume";
                perfumeCategoriesComboBox.SelectedValue = "";

                productCategoriesComboBox.Enabled = true;
                perfumeCategoriesComboBox.Enabled = true;

                nonDiscountProductDataGridView.Enabled = true;
                nonDiscountSelectAllButton.Enabled = true;
                nonDiscountDeselectAllButton.Enabled = true;
                nonDiscountAddButton.Enabled = true;

                discountProductDataGridView.Enabled = true;
                discountSelectAllButton.Enabled = true;
                discountDeselectAllButton.Enabled = true;
                discountDeleteButton.Enabled = true;

                productCategoriesComboBox_SelectedIndexChanged(null, null);
            }
        }

        private void productCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productCategoriesComboBox.SelectedValue.Equals("perfume"))
            {
                perfumeCategoriesComboBox.SelectedValue = comboxCurrentSelectedPerfumeCategory;
                perfumeCategoryLabel.Enabled = true;
                perfumeCategoriesComboBox.Enabled = true;
                perfumeCategoriesComboBox_SelectedIndexChanged(null, null);
            }
            else
            {
                perfumeCategoriesComboBox.SelectedValue = "";
                perfumeCategoryLabel.Enabled = false;
                perfumeCategoriesComboBox.Enabled = false;

                nonDiscountProductDataGridView.Rows.Clear();
                nonDiscountProductDataGridView.Refresh();

                List<ProductDiscount> discountList = null;
                if (productCategoriesComboBox.SelectedValue.Equals("bottle"))
                {
                    if (!string.IsNullOrEmpty(selectedDiscountCode))
                    {
                        discountList = pbdda.getOneProductDiscountByCode(selectedDiscountCode, Language.getLanguageCode(), conn);
                        List<Bottle> list = pbda.getAllProductBottles(Language.getLanguageCode(), conn);
                        foreach (Bottle bottle in list)
                        {
                            int discountIndex = discountList.FindIndex(pd => bottle.getProductID().Equals(pd.getProductID()));
                            if (discountIndex == -1)
                                nonDiscountProductDataGridView.Rows.Add(false, bottle.getProductID(), bottle.getProductName());
                        }
                    }

                }
                else if (productCategoriesComboBox.SelectedValue.Equals("package"))
                {
                    if (!string.IsNullOrEmpty(selectedDiscountCode))
                    {
                        discountList = ppgdda.getOneProductDiscountByCode(selectedDiscountCode, Language.getLanguageCode(), conn);
                        List<Package> list = ppgda.getAllProductPackages(Language.getLanguageCode(), conn);
                        foreach (Package package in list)
                        {
                            int discountIndex = discountList.FindIndex(pd =>package.getProductID().Equals(pd.getProductID()));
                            if (discountIndex==-1)
                                nonDiscountProductDataGridView.Rows.Add(false, package.getProductID(), package.getProductName());
                        }
                    }
                }

                if (nonDiscountProductDataGridView.Rows.Count > 0)
                {
                    nonDiscountSelectAllButton.Enabled = true;
                    nonDiscountDeselectAllButton.Enabled = true;
                    nonDiscountAddButton.Enabled = true;
                }
                else
                {
                    nonDiscountSelectAllButton.Enabled = false;
                    nonDiscountDeselectAllButton.Enabled = false;
                    nonDiscountAddButton.Enabled = false;
                }

                nonDiscountProductDataGridView.ClearSelection();

                //=======================================
                discountProductDataGridView.Rows.Clear();
                discountProductDataGridView.Refresh();

                if (productCategoriesComboBox.SelectedValue.Equals("bottle"))
                {
                    if (!string.IsNullOrEmpty(selectedDiscountCode))
                    {
                        foreach (ProductDiscount bottle in discountList)
                            discountProductDataGridView.Rows.Add(false, bottle.getProductID(), bottle.getProductName());
                    }
                }
                else if (productCategoriesComboBox.SelectedValue.Equals("package"))
                {
                    if (!string.IsNullOrEmpty(selectedDiscountCode))
                    {
                        foreach (ProductDiscount package in discountList)
                            discountProductDataGridView.Rows.Add(false, package.getProductID(), package.getProductName());
                    }
                }

                if (discountProductDataGridView.Rows.Count > 0)
                {
                    discountSelectAllButton.Enabled = true;
                    discountDeselectAllButton.Enabled = true;
                    discountDeleteButton.Enabled = true;
                }
                else
                {
                    discountSelectAllButton.Enabled = false;
                    discountDeselectAllButton.Enabled = false;
                    discountDeleteButton.Enabled = false;
                }

                discountProductDataGridView.ClearSelection();
            }
        }

        private void perfumeCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productCategoriesComboBox.SelectedValue.Equals("perfume"))
                comboxCurrentSelectedPerfumeCategory = (string)perfumeCategoriesComboBox.SelectedValue;

            nonDiscountProductDataGridView.Rows.Clear();
            nonDiscountProductDataGridView.Refresh();

            List<Perfume> list = ppda.getAllProductPerfume(Language.getLanguageCode(), conn);
            List<ProductDiscount> discountList = null;
            if (!string.IsNullOrEmpty(selectedDiscountCode))
            {
                discountList = ppdda.getOneProductDiscountByCode(selectedDiscountCode, Language.getLanguageCode(), conn);
                foreach (Perfume perfume in list)
                    if (perfumeCategoriesComboBox.SelectedValue.Equals("") || perfume.getCategory().Equals(perfumeCategoriesComboBox.Text))
                    {
                        int discountIndex = discountList.FindIndex(pd => perfume.getProductID().Equals(pd.getProductID()));
                        if (discountIndex==-1)
                            nonDiscountProductDataGridView.Rows.Add(false, perfume.getProductID(), perfume.getProductName());
                    }
            }


            if (nonDiscountProductDataGridView.Rows.Count > 0)
            {
                nonDiscountSelectAllButton.Enabled = true;
                nonDiscountDeselectAllButton.Enabled = true;
                nonDiscountAddButton.Enabled = true;
            }
            else
            {
                nonDiscountSelectAllButton.Enabled = false;
                nonDiscountDeselectAllButton.Enabled = false;
                nonDiscountAddButton.Enabled = false;
            }

            nonDiscountProductDataGridView.ClearSelection();

            //=======================================
            discountProductDataGridView.Rows.Clear();
            discountProductDataGridView.Refresh();

            if (!string.IsNullOrEmpty(selectedDiscountCode))
            {
                foreach (ProductDiscount perfume in discountList)
                    if (perfumeCategoriesComboBox.SelectedValue.Equals("") || perfume.getPerfumeCategory().Equals(perfumeCategoriesComboBox.Text))
                    {
                        discountProductDataGridView.Rows.Add(
                            false,
                            perfume.getProductID(),
                            perfume.getProductName());
                    }
            }

            if (discountProductDataGridView.Rows.Count > 0)
            {
                discountSelectAllButton.Enabled = true;
                discountDeselectAllButton.Enabled = true;
                discountDeleteButton.Enabled = true;
            }
            else
            {
                discountSelectAllButton.Enabled = false;
                discountDeselectAllButton.Enabled = false;
                discountDeleteButton.Enabled = false;
            }

            discountProductDataGridView.ClearSelection();
        }

        private void nonDiscountSelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in nonDiscountProductDataGridView.Rows)
            {
                if (!(bool)row.Cells["selectedNonDiscountProduct"].Value)
                    row.Cells["selectedNonDiscountProduct"].Value = true;
            }
        }

        private void nonDiscountDeselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in nonDiscountProductDataGridView.Rows)
            {
                if ((bool)row.Cells["selectedNonDiscountProduct"].Value)
                    row.Cells["selectedNonDiscountProduct"].Value = false;
            }
        }

        private void nonDiscountAddButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = nonDiscountProductDataGridView.Rows.Count - 1; i >= 0; i--)
            {
                bool select = (bool)nonDiscountProductDataGridView.Rows[i].Cells["selectedNonDiscountProduct"].Value;
                if (select == true)
                {
                    ProductDiscount pd = new ProductDiscount();
                    pd.setDiscountCode(selectedDiscountCode);
                    pd.setProductID(nonDiscountProductDataGridView.Rows[i].Cells["nonDiscountProductIdColumn"].Value.ToString());

                    if (productCategoriesComboBox.SelectedValue.Equals("bottle"))
                        pbdda.insert(pd, conn);
                    else if (productCategoriesComboBox.SelectedValue.Equals("package"))
                        ppgdda.insert(pd, conn);
                    else if (productCategoriesComboBox.SelectedValue.Equals("perfume"))
                        ppdda.insert(pd, conn);

                    nonDiscountProductDataGridView.Rows.Remove(nonDiscountProductDataGridView.Rows[i]);
                    count++;
                }
            }

            if (count == 0)
                MessageBox.Show(rs.GetString("selectProductMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (nonDiscountProductDataGridView.Rows.Count > 0)
                {
                    nonDiscountSelectAllButton.Enabled = true;
                    nonDiscountDeselectAllButton.Enabled = true;
                    nonDiscountAddButton.Enabled = true;
                }
                else
                {
                    nonDiscountSelectAllButton.Enabled = false;
                    nonDiscountDeselectAllButton.Enabled = false;
                    nonDiscountAddButton.Enabled = false;
                }

                nonDiscountProductDataGridView.ClearSelection();

                productCategoriesComboBox_SelectedIndexChanged(null, null);
            }
        }

        private void discountSelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in discountProductDataGridView.Rows)
            {
                if (!(bool)row.Cells["selectedDiscountProduct"].Value)
                    row.Cells["selectedDiscountProduct"].Value = true;
            }
        }

        private void discountDeselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in discountProductDataGridView.Rows)
            {
                if ((bool)row.Cells["selectedDiscountProduct"].Value)
                    row.Cells["selectedDiscountProduct"].Value = false;
            }
        }

        private void discountDeleteButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = discountProductDataGridView.Rows.Count - 1; i >= 0; i--)
            {
                bool select = (bool)discountProductDataGridView.Rows[i].Cells["selectedDiscountProduct"].Value;
                if (select == true)
                {
                    ProductDiscount pd = new ProductDiscount();
                    pd.setDiscountCode(selectedDiscountCode);
                    pd.setProductID(discountProductDataGridView.Rows[i].Cells["discountProductIdColumn"].Value.ToString());

                    if (productCategoriesComboBox.SelectedValue.Equals("bottle"))
                        pbdda.permanentlyDelete(pd, conn);
                    else if (productCategoriesComboBox.SelectedValue.Equals("package"))
                        ppgdda.permanentlyDelete(pd, conn);
                    else if (productCategoriesComboBox.SelectedValue.Equals("perfume"))
                        ppdda.permanentlyDelete(pd, conn);

                    discountProductDataGridView.Rows.Remove(discountProductDataGridView.Rows[i]);
                    count++;
                }
            }

            if (count == 0)
                MessageBox.Show(rs.GetString("selectProductMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (discountProductDataGridView.Rows.Count > 0)
                {
                    discountSelectAllButton.Enabled = true;
                    discountDeselectAllButton.Enabled = true;
                    discountDeleteButton.Enabled = true;
                }
                else
                {
                    discountSelectAllButton.Enabled = false;
                    discountDeselectAllButton.Enabled = false;
                    discountDeleteButton.Enabled = false;
                }

                discountProductDataGridView.ClearSelection();

                productCategoriesComboBox_SelectedIndexChanged(null, null);
            }
        }
    }
}
