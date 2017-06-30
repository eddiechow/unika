using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System.Resources;
using System.Collections.Specialized;

namespace BackendForSupplier.PerfumeSupplierForm
{
    public partial class RecycleBinUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForSupplier.Properties.Resources", typeof(RecycleBinUserCtrl).Assembly);

        private static Properties.Settings setting = Properties.Settings.Default;
        private StringCollection showedDeletedAlertPerfume = setting.showedDeletedAlertPerfume;
        private StringCollection showedStockAlertPerfume = setting.showedStockAlertPerfume;

        private ProductPerfumeDA ppda = new ProductPerfumeDA();
        private string supplierID = null;
        private List<Perfume> pruductList = null;

        public RecycleBinUserCtrl(string supplierID)
        {
            InitializeComponent();

            this.supplierID = supplierID;
            pruductList = ppda.findDeletedProductPerfumeBySupplierID(this.supplierID, Language.getLanguageCode(), conn);

            //Set Category Combo Box
            BindingList<KeyValuePair<string, string>> categoriesList = new BindingList<KeyValuePair<string, string>>();
            categoryComboBox.DataSource = null;
            categoryComboBox.Items.Clear();
            categoryComboBox.DisplayMember = "Key";
            categoryComboBox.ValueMember = "Value";
            categoryComboBox.DataSource = categoriesList;

            categoriesList.Add(new KeyValuePair<string, string>(rs.GetString("allText"), ""));
            Dictionary<string, string> categoriesMap = ppda.getAllCategories(Language.getLanguageCode(), conn);
            foreach (var pair in categoriesMap)
                categoriesList.Add(new KeyValuePair<string, string>(pair.Key, pair.Value));

            categoryComboBox.SelectedIndex = 0;
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
            categoryComboBox.SelectedIndex = 0;
            perfumeIdTextBox.Text = "";
            keywordTextBox.Text = "";
            deleteDateRangeRadioButton.Checked = false;
            deleteDateAllRadioButton.Checked = true;
            deleteDateToLabel.Enabled = false;
            deleteFromDateTime.Enabled = false;
            deleteToDateTime.Enabled = false;
            deleteFromDateTime.Value = DateTime.Now.Date.AddMonths(-18);
            deleteToDateTime.Value = DateTime.Now.Date;
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

        private void input_SearchChanged(object sender, EventArgs e)
        {
            perfumeListDataGridView.Rows.Clear();
            perfumeListDataGridView.Refresh();

            if (pruductList != null)
                foreach (Perfume perfume in pruductList)
                    if ((((string)categoryComboBox.SelectedValue).Equals(perfume.getCategoryCode()) || ((string)categoryComboBox.SelectedValue).Equals("")) &&
                        ((perfume.getProductID().ToUpper()).Contains(perfumeIdTextBox.Text.ToUpper()) || string.IsNullOrWhiteSpace(perfumeIdTextBox.Text)) &&
                        ((perfume.getProductNameEnUs().ToLower()).Contains(keywordTextBox.Text.ToLower()) ||
                         (perfume.getProductNameZhHant()).Contains(keywordTextBox.Text) ||
                         (perfume.getDescriptionEnUs().ToLower()).Contains(keywordTextBox.Text.ToLower()) ||
                         (perfume.getDescriptionZhHant()).Contains(keywordTextBox.Text) ||
                         string.IsNullOrWhiteSpace(keywordTextBox.Text)) &&
                        ((deleteDateRangeRadioButton.Checked && deleteFromDateTime.Value.Date <= perfume.getDateDeleted().Date && deleteToDateTime.Value.Date >= perfume.getDateDeleted().Date) ||
                         deleteDateAllRadioButton.Checked)
                       )
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
                            perfume.getReleaseDate().ToLongDateString(),
                            perfume.getDateDeleted().ToLongDateString());

            perfumeListDataGridView.ClearSelection();

            if (perfumeListDataGridView.Rows.Count > 0)
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

        private void recoverButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = perfumeListDataGridView.Rows.Count - 1; i >= 0; i--)
            {
                bool delete = (bool)perfumeListDataGridView.Rows[i].Cells["selectedProductColumn"].Value;
                if (delete == true)
                {
                    ppda.undelete((string)perfumeListDataGridView.Rows[i].Cells["perfumeIdColumn"].Value, conn);
                    showedDeletedAlertPerfume.Remove((string)perfumeListDataGridView.Rows[i].Cells["perfumeIdColumn"].Value);
                    setting.Save();
                    perfumeListDataGridView.Rows.Remove(perfumeListDataGridView.Rows[i]);
                    count++;
                }
            }

            if (count == 0)
                MessageBox.Show(rs.GetString("selectProcuctDeletedMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (perfumeListDataGridView.Rows.Count > 0)
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

                perfumeListDataGridView.ClearSelection();

                pruductList = null;
                pruductList = ppda.findDeletedProductPerfumeBySupplierID(supplierID, Language.getLanguageCode(), conn);

                MessageBox.Show(rs.GetString("deletedProcuctRecoverMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void permanentlyDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(rs.GetString("deletePermanentlyYesNoMsg"), rs.GetString("deleteTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = 0;

                for (int i = perfumeListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)perfumeListDataGridView.Rows[i].Cells["selectedProductColumn"].Value;
                    if (delete == true)
                    {
                        ppda.permanentlyDelete((string)perfumeListDataGridView.Rows[i].Cells["perfumeIdColumn"].Value, conn);
                        showedDeletedAlertPerfume.Remove((string)perfumeListDataGridView.Rows[i].Cells["perfumeIdColumn"].Value);
                        setting.Save();
                        showedStockAlertPerfume.Remove((string)perfumeListDataGridView.Rows[i].Cells["perfumeIdColumn"].Value);
                        setting.Save();
                        perfumeListDataGridView.Rows.Remove(perfumeListDataGridView.Rows[i]);
                        count++;
                    }
                }

                if (count == 0)
                    MessageBox.Show(rs.GetString("selectProcuctDeletedMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (perfumeListDataGridView.Rows.Count > 0)
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

                    perfumeListDataGridView.ClearSelection();

                    pruductList = null;
                    pruductList = ppda.findDeletedProductPerfumeBySupplierID(supplierID, Language.getLanguageCode(), conn);

                    MessageBox.Show(rs.GetString("deletePermanentlyMsg"));
                }
            }
        }
    }
}
