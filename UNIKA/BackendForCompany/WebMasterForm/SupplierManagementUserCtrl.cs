using BackendClassLibrary;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;
using MetroFramework.Controls;
using System.Resources;

namespace BackendForCompany.WebMasterForm
{
    public partial class SupplierManagementUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private SupplierDA sda = new SupplierDA();
        private string staffID = null;

        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(SupplierManagementUserCtrl).Assembly);

        private Regex nameFormat = new Regex("^([A-Z][a-z]{1,}(\\.)?)(\\s[A-Z][a-z]{1,}(\\.)?){0,}");
        private Regex phoneFormat = new Regex("^(\\+[0-9]{3,4})(\\-[0-9]{4,})");

        public SupplierManagementUserCtrl(string staffID)
        {
            InitializeComponent();

            this.staffID = staffID;

            List<Supplier> allSauppliers = sda.getAllSuppliers(conn);
            AutoCompleteStringCollection supplierIdCollection = new AutoCompleteStringCollection();
            foreach (Supplier supplier in allSauppliers)
                supplierIdCollection.Add(supplier.getSupplierID());
            searchSupplierIdTextBox.AutoCompleteCustomSource = supplierIdCollection;
        }

        private void bottleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string randId = "BO" + Security.getToken();
            Supplier sup = sda.getOneSupplierByID(randId, conn);
            Supplier deletedSup = sda.getOneDeletedSupplierByID(randId, conn);
            while ((!string.IsNullOrWhiteSpace(sup.getSupplierID()) && sup.getSupplierID().Equals(randId)) || (!string.IsNullOrWhiteSpace(deletedSup.getSupplierID()) && deletedSup.getSupplierID().Equals(randId)))
            {
                randId = "BO" + Security.getToken();
            }
            idTextBox.Text = randId;
        }

        private void packageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string randId = "PA" + Security.getToken();
            Supplier sup = sda.getOneSupplierByID(randId, conn);
            Supplier deletedSup = sda.getOneDeletedSupplierByID(randId, conn);
            while ((!string.IsNullOrWhiteSpace(sup.getSupplierID()) && sup.getSupplierID().Equals(randId)) || (!string.IsNullOrWhiteSpace(deletedSup.getSupplierID()) && deletedSup.getSupplierID().Equals(randId)))
            {
                randId = "PA" + Security.getToken();
            }
            idTextBox.Text = randId;
        }

        private void perfumeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string randId = "PE" + Security.getToken();
            Supplier sup = sda.getOneSupplierByID(randId, conn);
            Supplier deletedSup = sda.getOneDeletedSupplierByID(randId, conn);
            while ((!string.IsNullOrWhiteSpace(sup.getSupplierID()) && sup.getSupplierID().Equals(randId)) || (!string.IsNullOrWhiteSpace(deletedSup.getSupplierID()) && deletedSup.getSupplierID().Equals(randId)))
            {
                randId = "PE" + Security.getToken();
            }
            idTextBox.Text = randId;
        }

        private bool isInputCorrect()
        {
            bool correct = true;

            if (!perfumeRadioButton.Checked && !packageRadioButton.Checked && !bottleRadioButton.Checked)
            {
                supplierTypeErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                supplierTypeErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(supplierNameTextBox.Text) || !nameFormat.IsMatch(supplierNameTextBox.Text))
            {
                supplierNameErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                supplierNameErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(supplierContactNoTextBox.Text) || !phoneFormat.IsMatch(supplierContactNoTextBox.Text))
            {
                supplierContactNoErrorLabel.ForeColor = Color.Red;
                correct = false;
            }
            else
            {
                supplierContactNoErrorLabel.ForeColor = SystemColors.ControlText;
            }

            if (string.IsNullOrWhiteSpace(emailTextBox.Text) || !FormatChecker.isValidEmail(emailTextBox.Text))
            {
                emailErrorLabel.Text = rs.GetString("inputValidEmail");
                emailErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                bool emailExist = false;
                List<Supplier> suppliers = sda.getAllSuppliers(conn);
                List<Supplier> deletedSuppliers = sda.getAllDeletedSuppliers(conn);
                if (!emailExist)
                    foreach (Supplier sup in suppliers)
                        if (!string.IsNullOrWhiteSpace(sup.getEmail()) && sup.getEmail().Equals(emailTextBox.Text))
                            if (!string.IsNullOrWhiteSpace(sup.getSupplierID()) && !sup.getSupplierID().Equals(idTextBox.Text))
                            {
                                emailExist = true;
                                break;
                            }
                if (!emailExist)
                    foreach (Supplier sup in deletedSuppliers)
                        if (!string.IsNullOrWhiteSpace(sup.getEmail()) && sup.getEmail().Equals(emailTextBox.Text))
                            if (!string.IsNullOrWhiteSpace(sup.getSupplierID()) && !sup.getSupplierID().Equals(idTextBox.Text))
                            {
                                emailExist = true;
                                break;
                            }

                if (emailExist)
                {
                    emailErrorLabel.Text = rs.GetString("emailExists");
                    emailErrorLabel.Visible = true;
                    correct = false;
                }
                else
                {
                    emailErrorLabel.Text = " ";
                    emailErrorLabel.Visible = false;
                }
            }

            if (string.IsNullOrWhiteSpace(supplierAddressTextBox.Text))
            {
                supplierAddressErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                supplierAddressErrorLabel.Visible = false;
            }

            return correct;
        }

        private void resetFormButton_Click(object sender, EventArgs e)
        {
            supplierListDataGridView.ClearSelection();
            supplierTypeErrorLabel.Visible = false;
            supplierNameErrorLabel.Visible = false;
            supplierContactNoErrorLabel.ForeColor = SystemColors.ControlText;
            emailErrorLabel.Text = " ";
            emailErrorLabel.Visible = false;
            passwordHintLabel.ForeColor = SystemColors.ControlText;
            supplierAddressErrorLabel.Visible = false;

            perfumeRadioButton.Enabled = true;
            packageRadioButton.Enabled = true;
            bottleRadioButton.Enabled = true;
            perfumeRadioButton.Checked = false;
            packageRadioButton.Checked = false;
            bottleRadioButton.Checked = false;
            idTextBox.Clear();
            supplierNameTextBox.Clear();
            supplierContactNoTextBox.Clear();
            emailTextBox.Clear();
            passwordTextBox.Enabled = true;
            passwordHintLabel.Visible = true;
            supplierAddressTextBox.Clear();

            addButton.Enabled = true;
            updateButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool passwordStrong = true;
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || !FormatChecker.checkPasswdFormat(passwordTextBox.Text))
            {
                passwordHintLabel.ForeColor = Color.Red;
                passwordStrong = false;
            }
            else
            {
                passwordHintLabel.ForeColor = SystemColors.ControlText;
            }

            if (isInputCorrect() && passwordStrong)
            {
                Supplier sup = new Supplier();
                sup.setSupplierID(idTextBox.Text);
                sup.setSupplierName(supplierNameTextBox.Text);
                sup.setContectNo(supplierContactNoTextBox.Text);
                sup.setEmail(emailTextBox.Text);
                sup.setAddress(supplierAddressTextBox.Text);
                sup.setPassword(Security.getHash(passwordTextBox.Text, "SHA512", null));
                if (perfumeRadioButton.Checked)
                    sup.setProductCategory("Perfume");
                else if (packageRadioButton.Checked)
                    sup.setProductCategory("Package");
                else if (bottleRadioButton.Checked)
                    sup.setProductCategory("Bottle");

                int i = sda.insert(sup, conn);
                if (i>0)
                {
                    supplierListDataGridView.Rows.Add(false, sup.getSupplierID(), sup.getSupplierName(), 
                        ((sup.getProductCategory().Equals("Perfume")) ? rs.GetString("perfumeText") : ((sup.getProductCategory().Equals("Package")) ? rs.GetString("packageText") : rs.GetString("bottleText"))), 
                        sup.getContectNo(), sup.getEmail(), sup.getAddress());

                    supplierListDataGridView.ClearSelection();
                    foreach (DataGridViewRow row in supplierListDataGridView.Rows)
                    {
                        if (idTextBox.Text.Equals(row.Cells["supplierIDColumn"].Value.ToString()))
                        {
                            row.Selected = true;
                            supplierListDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        }
                    }

                    deleteButton.Enabled = true;
                    deselectAllButton.Enabled = true;
                    selectAllButton.Enabled = true;

                    addButton.Enabled = false;
                    updateButton.Enabled = true;
                    staffIdHintLabel.Visible = false;

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
                Supplier sup = sda.getOneSupplierByID(idTextBox.Text, conn);
                sup.setSupplierName(supplierNameTextBox.Text);
                sup.setContectNo(supplierContactNoTextBox.Text);
                sup.setEmail(emailTextBox.Text);
                sup.setAddress(supplierAddressTextBox.Text);

                int i = sda.update(sup, idTextBox.Text, conn);
                if (i > 0)
                {
                    foreach (DataGridViewRow row in supplierListDataGridView.Rows)
                    {
                        if (idTextBox.Text.Equals(row.Cells["staffIdColumn"].Value.ToString()))
                        {
                            row.Cells["supplierNameColumn"].Value = sup.getSupplierName();
                            row.Cells["supplierContactNoColumn"].Value = sup.getContectNo();
                            row.Cells["supplierEmailColumn"].Value = sup.getEmail();
                            row.Cells["supplierAddressColumn"].Value = sup.getAddress();
                        }
                    }
                    MessageBox.Show(rs.GetString("updateSuccessMsg"));
                }
                else
                    MessageBox.Show(rs.GetString("failToUpdateMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            supplierListDataGridView.Rows.Clear();
            supplierListDataGridView.Refresh();

            List<Supplier> suppliers = sda.getAllSuppliers(conn);
            foreach (Supplier sup in suppliers)
                if (sup.getSupplierID().Equals(searchSupplierIdTextBox.Text.ToUpper()))
                {
                    supplierListDataGridView.Rows.Add(false, sup.getSupplierID(), sup.getSupplierName(),
                        ((sup.getProductCategory().Equals("Perfume")) ? rs.GetString("perfumeText") : ((sup.getProductCategory().Equals("Package")) ? rs.GetString("packageText") : rs.GetString("bottleText"))),
                        sup.getContectNo(), sup.getEmail(), sup.getAddress());
                }

            supplierListDataGridView.ClearSelection();

            if (supplierListDataGridView.Rows.Count > 0)
            {
                deleteButton.Enabled = true;
                deselectAllButton.Enabled = true;
                selectAllButton.Enabled = true;

                foreach (DataGridViewRow row in supplierListDataGridView.Rows)
                {
                    if (idTextBox.Text.Equals(row.Cells["supplierIDColumn"].Value.ToString()))
                        row.Selected = true;
                }
            }
            else
            {
                deleteButton.Enabled = false;
                deselectAllButton.Enabled = false;
                selectAllButton.Enabled = false;
            }
        }

        private void searchAllButton_Click(object sender, EventArgs e)
        {
            supplierListDataGridView.Rows.Clear();
            supplierListDataGridView.Refresh();

            List<Supplier> suppliers = sda.getAllSuppliers(conn);
            foreach (Supplier sup in suppliers)
                supplierListDataGridView.Rows.Add(false, sup.getSupplierID(), sup.getSupplierName(),
                    ((sup.getProductCategory().Equals("Perfume")) ? rs.GetString("perfumeText") : ((sup.getProductCategory().Equals("Package")) ? rs.GetString("packageText") : rs.GetString("bottleText"))),
                    sup.getContectNo(), sup.getEmail(), sup.getAddress());

            supplierListDataGridView.ClearSelection();

            if (supplierListDataGridView.Rows.Count > 0)
            {
                deleteButton.Enabled = true;
                deselectAllButton.Enabled = true;
                selectAllButton.Enabled = true;

                foreach (DataGridViewRow row in supplierListDataGridView.Rows)
                {
                    if (idTextBox.Text.Equals(row.Cells["supplierIDColumn"].Value.ToString()))
                        row.Selected = true;
                }
            }
            else
            {
                deleteButton.Enabled = false;
                deselectAllButton.Enabled = false;
                selectAllButton.Enabled = false;
            }
        }

        private void staffDataResetButton_Click(object sender, EventArgs e)
        {
            supplierListDataGridView.Rows.Clear();
            supplierListDataGridView.Refresh();
            supplierListDataGridView.ClearSelection();

            deleteButton.Enabled = false;
            deselectAllButton.Enabled = false;
            selectAllButton.Enabled = false;
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in supplierListDataGridView.Rows)
            {
                if (!(bool)row.Cells["selectedSupplierColumn"].Value)
                        row.Cells["selectedSupplierColumn"].Value = true;
            }
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in supplierListDataGridView.Rows)
            {
                if ((bool)row.Cells["selectedSupplierColumn"].Value)
                    row.Cells["selectedSupplierColumn"].Value = false;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(rs.GetString("deleteAccountYesNoMsg"), rs.GetString("deleteTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = 0;

                for (int i = supplierListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)supplierListDataGridView.Rows[i].Cells["selectedSupplierColumn"].Value;
                    if (delete == true)
                    {
                        sda.delete((string)supplierListDataGridView.Rows[i].Cells["supplierIDColumn"].Value, conn);
                        supplierListDataGridView.Rows.Remove(supplierListDataGridView.Rows[i]);
                        count++;
                    }
                }

                if (count == 0)
                    MessageBox.Show(rs.GetString("selectAccountMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (supplierListDataGridView.Rows.Count > 0)
                    {
                        deleteButton.Enabled = true;
                        deselectAllButton.Enabled = true;
                        selectAllButton.Enabled = true;
                    }
                    else
                    {
                        deleteButton.Enabled = false;
                        deselectAllButton.Enabled = false;
                        selectAllButton.Enabled = false;
                    }

                    supplierListDataGridView.ClearSelection();

                    resetFormButton_Click(null, null);

                    MessageBox.Show(rs.GetString("deleteAccountMsg"));
                }
            }
        }

        private void supplierListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                perfumeRadioButton.Enabled = false;
                packageRadioButton.Enabled = false;
                bottleRadioButton.Enabled = false;
                addButton.Enabled = false;
                updateButton.Enabled = true;
                staffIdHintLabel.Visible = false;
                Supplier sup = sda.getOneSupplierByID(supplierListDataGridView.Rows[e.RowIndex].Cells["supplierIdColumn"].Value.ToString(), conn);
                if (sup.getProductCategory().Equals("Bottle"))
                    bottleRadioButton.Checked = true;
                else if (sup.getProductCategory().Equals("Package"))
                    packageRadioButton.Checked = true;
                else if (sup.getProductCategory().Equals("Perfume"))
                    perfumeRadioButton.Checked = true;

                idTextBox.Text = sup.getSupplierID();
                supplierNameTextBox.Text = sup.getSupplierName();
                supplierContactNoTextBox.Text = sup.getContectNo();
                emailTextBox.Text = sup.getEmail();
                supplierAddressTextBox.Text = sup.getAddress();
                passwordTextBox.Enabled = false;
                passwordHintLabel.Visible = false;
            }
        }
    }
}
