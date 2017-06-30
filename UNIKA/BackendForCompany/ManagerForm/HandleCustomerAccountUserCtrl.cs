using BackendClassLibrary;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace BackendForCompany.ManagerForm
{
    public partial class HandleCustomerAccountUserCtrl : MetroUserControl
    {
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(HandleCustomerAccountUserCtrl).Assembly);

        private MySqlConnection conn = Database.getConnection();
        private CustomerDA cda = new CustomerDA();

        string staffID = null;

        public HandleCustomerAccountUserCtrl(string staffID)
        {
            InitializeComponent();
            this.staffID = staffID;

            Dictionary<string, int> ageGroups = cda.getAllAgeGroups(Language.getLanguageCode(), conn);
            ageComboBox.DataSource = new BindingSource(ageGroups, null);
            ageComboBox.DisplayMember = "Key";
            ageComboBox.ValueMember = "Value";
            ageComboBox.SelectedIndex = -1;

            Dictionary<string, int> regionCode = new Dictionary<string, int> { { "+852", 852 } };
            regionCodeComboBox.DataSource = new BindingSource(regionCode, null);
            regionCodeComboBox.DisplayMember = "Key";
            regionCodeComboBox.ValueMember = "Value";
            regionCodeComboBox.SelectedIndex = -1;
        }

        private void resetFormButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            customerSurnameTextBox.Clear();
            customerGivenNameTextBox.Clear();
            emailTextBox.Clear();
            ageComboBox.SelectedIndex = -1;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            regionCodeComboBox.SelectedIndex = -1;
            mobilePhoneNoTextBox.Clear();
            customerAddressTextBox.Clear();

            customerSurnameTextBox.Enabled = false;
            customerGivenNameTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            ageComboBox.Enabled = false;
            maleRadioButton.Enabled = false;
            femaleRadioButton.Enabled = false;
            regionCodeComboBox.Enabled = false;
            mobilePhoneNoTextBox.Enabled = false;
            customerAddressTextBox.Enabled = false;

            customerSurnameErrorLabel.Visible = false;
            customerGivenNameErrorLabel.Visible = false;
            emailErrorLabel.Visible = false;
            mobilePhoneNoErrorLabel.Visible = false;
            customerAddressErrorLabel.Visible = false;

            customerListDataGridView.ClearSelection();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            bool correct = true;

            if (string.IsNullOrWhiteSpace(customerSurnameTextBox.Text))
            {
                customerSurnameErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                customerSurnameErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(customerGivenNameTextBox.Text))
            {
                customerGivenNameErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                customerGivenNameErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(emailTextBox.Text) || !FormatChecker.isValidEmail(emailTextBox.Text))
            {
                emailErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                emailErrorLabel.Visible = false;
            }

            int mobilePhoneNo;
            if (string.IsNullOrWhiteSpace(mobilePhoneNoTextBox.Text) || !int.TryParse(mobilePhoneNoTextBox.Text, out mobilePhoneNo))
            {
                mobilePhoneNoErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                mobilePhoneNoErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(customerAddressTextBox.Text))
            {
                customerAddressErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                customerAddressErrorLabel.Visible = false;
            }

            if (correct)
            {
                Customer customer = cda.getOneCustomerByID(idTextBox.Text, Language.getLanguageCode(), conn);
                customer.setCustomerSurname(customerSurnameTextBox.Text);
                customer.setCustomerGivenName(customerGivenNameTextBox.Text);
                customer.setEmail(emailTextBox.Text);
                customer.setAgeGroupCode((int)ageComboBox.SelectedValue);
                customer.setAgeGroup(ageComboBox.Text);
                customer.setGender((maleRadioButton.Checked) ? 'M' : 'F');
                customer.setRegeionCode((int)regionCodeComboBox.SelectedValue);
                customer.setMobilePhoneNo(int.Parse(mobilePhoneNoTextBox.Text));
                customer.setAddress(customerAddressTextBox.Text);

                int i = cda.update(customer, conn);
                if (i > 0)
                {
                    foreach (DataGridViewRow row in customerListDataGridView.Rows)
                    {
                        if (idTextBox.Text.Equals(row.Cells["customerIDColumn"].Value.ToString()))
                        {
                            row.Cells["customerNameColumn"].Value = customer.getCustomerSurname().ToUpper()+" "+ customer.getCustomerGivenName();
                            row.Cells["customerEmailColumn"].Value = customer.getEmail();
                            row.Cells["customerAgeColumn"].Value = customer.getAgeGroup();
                            row.Cells["genderColumn"].Value = (customer.getGender().Equals('M') ? maleRadioButton.Text : femaleRadioButton.Text);
                            row.Cells["customerMobilePhoneNoColumn"].Value = "+" + customer.getRegeionCode() + "-" + customer.getMobilePhoneNo();
                            row.Cells["customerAddressColumn"].Value = customer.getAddress();
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
            customerListDataGridView.Rows.Clear();
            customerListDataGridView.Refresh();

            List<Customer> customers = cda.getAllCustomers(Language.getLanguageCode(), conn);
            foreach (Customer customer in customers)
                if(customer.getCustomerID().Contains(searchCustomerIdTextBox.Text.ToUpper()) &&
                    customer.getCustomerSurname().ToUpper().Contains(searchCustomerSurnameTextBox.Text.ToUpper()) &&
                    customer.getCustomerGivenName().ToLower().Contains(searchCustomerGivenNameTextBox.Text.ToLower()) &&
                    customer.getEmail().ToLower().Contains(searchEmailTextBox.Text.ToLower()))
                        customerListDataGridView.Rows.Add(false, customer.getCustomerID(), customer.getCustomerSurname().ToUpper() + " " + customer.getCustomerGivenName(),
                            customer.getEmail(), customer.getAgeGroup(), (customer.getGender().Equals('M') ? maleRadioButton.Text : femaleRadioButton.Text), "+"+customer.getRegeionCode()+"-"+customer.getMobilePhoneNo(), customer.getAddress());

            customerListDataGridView.ClearSelection();

            if (customerListDataGridView.Rows.Count > 0)
            {
                deleteButton.Enabled = true;
                deselectAllButton.Enabled = true;
                selectAllButton.Enabled = true;

                foreach (DataGridViewRow row in customerListDataGridView.Rows)
                {
                    if (idTextBox.Text.Equals(row.Cells["customerIDColumn"].Value.ToString()))
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
            customerListDataGridView.Rows.Clear();
            customerListDataGridView.Refresh();

            List<Customer> customers = cda.getAllCustomers(Language.getLanguageCode(), conn);
            foreach (Customer customer in customers)
                customerListDataGridView.Rows.Add(false, customer.getCustomerID(), customer.getCustomerSurname().ToUpper() + " " + customer.getCustomerGivenName(),
                    customer.getEmail(), customer.getAgeGroup(), (customer.getGender().Equals('M')? maleRadioButton.Text: femaleRadioButton.Text), "+" + customer.getRegeionCode() + "-" + customer.getMobilePhoneNo(), customer.getAddress());

            customerListDataGridView.ClearSelection();

            if (customerListDataGridView.Rows.Count > 0)
            {
                deleteButton.Enabled = true;
                deselectAllButton.Enabled = true;
                selectAllButton.Enabled = true;

                foreach (DataGridViewRow row in customerListDataGridView.Rows)
                {
                    if (idTextBox.Text.Equals(row.Cells["customerIDColumn"].Value.ToString()))
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

        private void customerListResetButton_Click(object sender, EventArgs e)
        {
            searchCustomerIdTextBox.Clear();
            searchCustomerSurnameTextBox.Clear();
            searchCustomerGivenNameTextBox.Clear();
            searchEmailTextBox.Clear();

            customerListDataGridView.Rows.Clear();
            customerListDataGridView.Refresh();

            customerListDataGridView.ClearSelection();

            deleteButton.Enabled = false;
            deselectAllButton.Enabled = false;
            selectAllButton.Enabled = false;
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in customerListDataGridView.Rows)
            {
                if (!(bool)row.Cells["selectedSupplierColumn"].Value)
                    row.Cells["selectedSupplierColumn"].Value = true;
            }
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in customerListDataGridView.Rows)
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

                for (int i = customerListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)customerListDataGridView.Rows[i].Cells["selectedSupplierColumn"].Value;
                    if (delete == true)
                    {
                        cda.delete((string)customerListDataGridView.Rows[i].Cells["customerIDColumn"].Value, conn);
                        customerListDataGridView.Rows.Remove(customerListDataGridView.Rows[i]);
                        count++;
                    }
                }

                if (count == 0)
                    MessageBox.Show(rs.GetString("selectAccountMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (customerListDataGridView.Rows.Count > 0)
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

                    customerListDataGridView.ClearSelection();

                    resetFormButton.PerformClick();

                    MessageBox.Show(rs.GetString("deleteAccountMsg"));
                }
            }
        }

        private void customerListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                updateButton.Enabled = true;
                Customer customer = cda.getOneCustomerByID(customerListDataGridView.Rows[e.RowIndex].Cells["customerIDColumn"].Value.ToString(), Language.getLanguageCode(), conn);
                idTextBox.Text = customer.getCustomerID();
                customerSurnameTextBox.Text = customer.getCustomerSurname();
                customerGivenNameTextBox.Text = customer.getCustomerGivenName();
                emailTextBox.Text = customer.getEmail();
                ageComboBox.SelectedValue = customer.getAgeGroupCode();
                if(customer.getGender().Equals('M'))
                    maleRadioButton.Checked = true;
                else
                    femaleRadioButton.Checked = true;
                regionCodeComboBox.SelectedValue = customer.getRegeionCode();
                mobilePhoneNoTextBox.Text = customer.getMobilePhoneNo().ToString();
                customerAddressTextBox.Text = customer.getAddress();

                customerSurnameTextBox.Enabled = true;
                customerGivenNameTextBox.Enabled = true;
                emailTextBox.Enabled = true;
                ageComboBox.Enabled = true;
                maleRadioButton.Enabled = true;
                femaleRadioButton.Enabled = true;
                regionCodeComboBox.Enabled = true;
                mobilePhoneNoTextBox.Enabled = true;
                customerAddressTextBox.Enabled = true;
            }
        }
    }
}
