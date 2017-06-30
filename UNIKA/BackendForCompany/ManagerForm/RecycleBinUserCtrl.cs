using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using MySql.Data.MySqlClient;
using MetroFramework.Controls;
using System.Resources;

namespace BackendForCompany.ManagerForm
{
    public partial class RecycleBinUserCtrl : MetroUserControl
    {
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(RecycleBinUserCtrl).Assembly);

        private MySqlConnection conn = Database.getConnection();
        private CustomerDA cda = new CustomerDA();
        private List<Customer> customerList = null;

        private string staffID = null;

        public RecycleBinUserCtrl(string staffID)
        {
            InitializeComponent();

            this.staffID = staffID;

            customerList = cda.getAllDeletedCustomers(Language.getLanguageCode(), conn);

            input_searchChanged(null, null);
        }

        private void input_searchChanged(object sender, EventArgs e)
        {
            customerListDataGridView.Rows.Clear();
            customerListDataGridView.Refresh();

            if (customerList != null)
                foreach (Customer customer in customerList)
                    if ((customer.getCustomerID().ToUpper()).Contains(customerIdTextBox.Text.ToUpper()) &&
                            (customer.getCustomerSurname().ToLower()).Contains(customerSurnameTextBox.Text.ToLower()) &&
                            (customer.getCustomerGivenName()).Contains(customerGivenNameTextBox.Text.ToLower()) &&
                            (customer.getEmail().ToLower()).Contains(emailTextBox.Text.ToLower())
                        )
                        customerListDataGridView.Rows.Add(false, customer.getCustomerID(), customer.getCustomerSurname().ToUpper() + " " + customer.getCustomerGivenName(),
                            customer.getEmail(), customer.getAgeGroup(), (customer.getGender().Equals('M') ? rs.GetString("maleText") : rs.GetString("femaleText")), "+" + customer.getRegeionCode() + "-" + customer.getMobilePhoneNo(), customer.getAddress());

            customerListDataGridView.ClearSelection();

            if (customerListDataGridView.Rows.Count > 0)
            {
                selectAllButton.Enabled = true;
                deselectAllButton.Enabled = true;
                recoverButton.Enabled = true;
                permanentlyDeleteButton.Enabled = true;
            }
            else
            {
                selectAllButton.Enabled = false;
                deselectAllButton.Enabled = false;
                recoverButton.Enabled = false;
                permanentlyDeleteButton.Enabled = false;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            customerIdTextBox.Clear();
            customerSurnameTextBox.Clear();
            customerGivenNameTextBox.Clear();
            emailTextBox.Clear();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in customerListDataGridView.Rows)
            {
                if (!(bool)row.Cells["selectedCustomerColumn"].Value)
                {
                    row.Cells["selectedCustomerColumn"].Value = true;
                }
            }
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in customerListDataGridView.Rows)
            {
                if ((bool)row.Cells["selectedCustomerColumn"].Value)
                {
                    row.Cells["selectedCustomerColumn"].Value = false;
                }
            }
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = customerListDataGridView.Rows.Count - 1; i >= 0; i--)
            {
                bool recover = (bool)customerListDataGridView.Rows[i].Cells["selectedCustomerColumn"].Value;
                if (recover == true)
                {
                    cda.undelete((string)customerListDataGridView.Rows[i].Cells["customerIDColumn"].Value, conn);
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
                    selectAllButton.Enabled = true;
                    deselectAllButton.Enabled = true;
                    recoverButton.Enabled = true;
                    permanentlyDeleteButton.Enabled = true;
                }
                else
                {
                    selectAllButton.Enabled = false;
                    deselectAllButton.Enabled = false;
                    recoverButton.Enabled = false;
                    permanentlyDeleteButton.Enabled = false;
                }

                customerListDataGridView.ClearSelection();

                MessageBox.Show(rs.GetString("deletedAccountRecoverMsg"));
            }
        }

        private void permanentlyDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(rs.GetString("deletePermanentlyAccountYesNoMsg"), rs.GetString("deleteTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = 0;

                for (int i = customerListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)customerListDataGridView.Rows[i].Cells["selectedCustomerColumn"].Value;
                    if (delete == true)
                    {
                        cda.permanentlyDelete((string)customerListDataGridView.Rows[i].Cells["customerIDColumn"].Value, conn);
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
                        selectAllButton.Enabled = true;
                        deselectAllButton.Enabled = true;
                        recoverButton.Enabled = true;
                        permanentlyDeleteButton.Enabled = true;
                    }
                    else
                    {
                        selectAllButton.Enabled = false;
                        deselectAllButton.Enabled = false;
                        recoverButton.Enabled = false;
                        permanentlyDeleteButton.Enabled = false;
                    }

                    customerListDataGridView.ClearSelection();

                    MessageBox.Show(rs.GetString("deletePermanentlyAccountMsg"));
                }

            }
        }
    }
}
