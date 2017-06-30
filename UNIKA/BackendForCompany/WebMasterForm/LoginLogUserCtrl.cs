using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace BackendForCompany.WebMasterForm
{
    public partial class LoginLogUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private EmployeeLoginLogDA elda = new EmployeeLoginLogDA();
        private SupplierLoginLogDA slda = new SupplierLoginLogDA();
        private CustomerLoginLogDA clda = new CustomerLoginLogDA();


        private string staffID = null;
        
        public LoginLogUserCtrl(string staffID)
        {
            InitializeComponent();

            this.staffID = staffID;

            List<Customer> allCustomers = (new CustomerDA()).getAllCustomers(Language.getLanguageCode(), conn);
            AutoCompleteStringCollection customerIdCollection = new AutoCompleteStringCollection();
            foreach (Customer customer in allCustomers)
                customerIdCollection.Add(customer.getCustomerID());
            customerIDTextBox.AutoCompleteCustomSource = customerIdCollection;

            List<Employee> allStaffs = (new EmployeeDA()).getAllEmployees(conn);
            AutoCompleteStringCollection staffIdCollection = new AutoCompleteStringCollection();
            foreach (Employee staff in allStaffs)
                staffIdCollection.Add(staff.getEmployeeID());
            staffIdTextBox.AutoCompleteCustomSource = staffIdCollection;

            List<Supplier> allSuppliers = (new SupplierDA()).getAllSuppliers(conn);
            AutoCompleteStringCollection supplierIdCollection = new AutoCompleteStringCollection();
            foreach (Supplier supplier in allSuppliers)
                supplierIdCollection.Add(supplier.getSupplierID());
            supplierIDTextBox.AutoCompleteCustomSource = supplierIdCollection;

            searchStaffStartDateTime.Value = DateTime.Now.Date.AddDays(-1);
            searchStaffStartDateTime.MaxDate = searchStaffStartDateTime.Value;
            searchStaffEndDateTime.Value = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
            searchStaffEndDateTime.MinDate = searchStaffEndDateTime.Value;

            searchSupplierStartDateTime.Value = DateTime.Now.Date.AddDays(-1);
            searchSupplierStartDateTime.MaxDate = searchSupplierStartDateTime.Value;
            searchSupplierEndDateTime.Value = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
            searchSupplierEndDateTime.MinDate = searchSupplierEndDateTime.Value;

            searchCustomerStartDateTime.Value = DateTime.Now.Date.AddDays(-1);
            searchCustomerStartDateTime.MaxDate = searchCustomerStartDateTime.Value;
            searchCustomerEndDateTime.Value = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
            searchCustomerEndDateTime.MinDate = searchCustomerEndDateTime.Value;
        }

        private void searchStaffDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (((MetroDateTime)sender).Name == "searchStaffStartDateTime")
            {
                searchStaffEndDateTime.MinDate = searchStaffStartDateTime.Value.Date.AddDays(2).AddMilliseconds(-1);
            }
            else if (((MetroDateTime)sender).Name == "searchStaffEndDateTime")
            {
                searchStaffStartDateTime.MaxDate = searchStaffEndDateTime.Value.Date.AddDays(-1);
            }
        }

        private void searchSupplierDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (((MetroDateTime)sender).Name == "searchSupplierStartDateTime")
            {
                searchSupplierEndDateTime.MinDate = searchSupplierStartDateTime.Value.Date.AddDays(2).AddMilliseconds(-1);
            }
            else if (((MetroDateTime)sender).Name == "searchSupplierEndDateTime")
            {
                searchSupplierStartDateTime.MaxDate = searchSupplierEndDateTime.Value.Date.AddDays(-1);
            }
        }

        private void searchCustomerDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (((MetroDateTime)sender).Name == "searchCustomerStartDateTime")
            {
                searchCustomerEndDateTime.MinDate = searchSupplierStartDateTime.Value.Date.AddDays(2).AddMilliseconds(-1);
            }
            else if (((MetroDateTime)sender).Name == "searchCustomerEndDateTime")
            {
                searchCustomerStartDateTime.MaxDate = searchSupplierEndDateTime.Value.Date.AddDays(-1);
            }
        }

        private void staffSearchButton_Click(object sender, EventArgs e)
        {
            staffLoginLogDataGridView.Rows.Clear();
            staffLoginLogDataGridView.Refresh();

            DateTime start = searchStaffStartDateTime.Value.Date;
            DateTime end = searchStaffEndDateTime.Value.Date.AddDays(1).AddMilliseconds(-1);

            List<LoginLog> emploginloglist = elda.searchLogs(start, end, (string.IsNullOrWhiteSpace(staffIdTextBox.Text))?null:staffIdTextBox.Text, (string.IsNullOrWhiteSpace(staffSurnameTextBox.Text)) ? null : staffSurnameTextBox.Text, (string.IsNullOrWhiteSpace(staffGivenNameTextBox.Text)) ? null : staffGivenNameTextBox.Text, conn);

            for (int i = emploginloglist.Count - 1; i >= 0; i--)
            {
                staffLoginLogDataGridView.Rows.Add(emploginloglist.ElementAt(i).getTime(), emploginloglist.ElementAt(i).getAccountID(), emploginloglist.ElementAt(i).getAccountName(), emploginloglist.ElementAt(i).getStatus());
            }

            resetButton.PerformClick();
        }

        private void staffSearchAllButton_Click(object sender, EventArgs e)
        {
            staffLoginLogDataGridView.Rows.Clear();
            staffLoginLogDataGridView.Refresh();

            List<LoginLog> emploginloglist = elda.getAllLogs(conn);

            for(int i = emploginloglist.Count - 1; i >= 0; i--)
            {
                staffLoginLogDataGridView.Rows.Add(emploginloglist.ElementAt(i).getTime(), emploginloglist.ElementAt(i).getAccountID(), emploginloglist.ElementAt(i).getAccountName(), emploginloglist.ElementAt(i).getStatus());
            }

            resetButton.PerformClick();
        }

        private void supplierSearchButton_Click(object sender, EventArgs e)
        {
            supplierLoginLogGridView.Rows.Clear();
            supplierLoginLogGridView.Refresh();

            DateTime start = searchSupplierStartDateTime.Value.Date;
            DateTime end = searchSupplierEndDateTime.Value.Date.AddDays(1).AddMilliseconds(-1);

            List<LoginLog> suploginloglist = slda.searchLogs(start, end, (string.IsNullOrWhiteSpace(supplierIDTextBox.Text)) ? null : supplierIDTextBox.Text, (string.IsNullOrWhiteSpace(supplierNameTextBox.Text)) ? null : supplierNameTextBox.Text, conn);

            for (int i = suploginloglist.Count - 1; i >= 0; i--)
            {
                supplierLoginLogGridView.Rows.Add(suploginloglist.ElementAt(i).getTime(), suploginloglist.ElementAt(i).getAccountID(), suploginloglist.ElementAt(i).getAccountName(), suploginloglist.ElementAt(i).getStatus());
            }

            resetButton.PerformClick();
        }

        private void supplierSearchAllButton_Click(object sender, EventArgs e)
        {
            supplierLoginLogGridView.Rows.Clear();
            supplierLoginLogGridView.Refresh();

            List<LoginLog> suploginloglist = slda.getAllLogs(conn);

            for (int i = suploginloglist.Count - 1; i >= 0; i--)
            {
                supplierLoginLogGridView.Rows.Add(suploginloglist.ElementAt(i).getTime(), suploginloglist.ElementAt(i).getAccountID(), suploginloglist.ElementAt(i).getAccountName(), suploginloglist.ElementAt(i).getStatus());
            }

            resetButton.PerformClick();
        }

        private void searchCustomerButton_Click(object sender, EventArgs e)
        {
            customerLoginLogDataGridView.Rows.Clear();
            customerLoginLogDataGridView.Refresh();

            DateTime start = searchCustomerStartDateTime.Value.Date;
            DateTime end = searchCustomerEndDateTime.Value.Date.AddDays(1).AddMilliseconds(-1);

            List<LoginLog> customerloginloglist = clda.searchLogs(start, end, (string.IsNullOrWhiteSpace(customerIDTextBox.Text)) ? null : customerIDTextBox.Text, (string.IsNullOrWhiteSpace(customerSurnameTextBox.Text)) ? null : customerSurnameTextBox.Text, (string.IsNullOrWhiteSpace(customerGivenNameTextBox.Text)) ? null : customerGivenNameTextBox.Text, conn);

            for (int i = customerloginloglist.Count - 1; i >= 0; i--)
            {
                customerLoginLogDataGridView.Rows.Add(customerloginloglist.ElementAt(i).getTime(), customerloginloglist.ElementAt(i).getAccountID(), customerloginloglist.ElementAt(i).getAccountName(), customerloginloglist.ElementAt(i).getOs(), customerloginloglist.ElementAt(i).getBrowser(), customerloginloglist.ElementAt(i).getIp(), customerloginloglist.ElementAt(i).getStatus());
            }

            resetButton.PerformClick();

        }

        private void searchCustomerAllButton_Click(object sender, EventArgs e)
        {
            customerLoginLogDataGridView.Rows.Clear();
            customerLoginLogDataGridView.Refresh();

            List<LoginLog> customerloginloglist = clda.getAllLogs(conn);

            for (int i = 0; i < customerloginloglist.Count; i++)
            {
                customerLoginLogDataGridView.Rows.Add(customerloginloglist.ElementAt(i).getTime(), customerloginloglist.ElementAt(i).getAccountID(), customerloginloglist.ElementAt(i).getAccountName(), customerloginloglist.ElementAt(i).getOs(), customerloginloglist.ElementAt(i).getBrowser(), customerloginloglist.ElementAt(i).getIp(), customerloginloglist.ElementAt(i).getStatus());
            }

            resetButton.PerformClick();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            searchStaffStartDateTime.MaxDate = DateTime.Now.Date.AddDays(-1);
            searchStaffStartDateTime.Value = searchStaffStartDateTime.MaxDate;
            searchStaffEndDateTime.MinDate = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
            searchStaffEndDateTime.Value = searchStaffEndDateTime.MinDate;
            staffIdTextBox.Clear();
            staffSurnameTextBox.Clear();
            staffGivenNameTextBox.Clear();

            searchSupplierStartDateTime.MaxDate = DateTime.Now.Date.AddDays(-1);
            searchSupplierStartDateTime.Value = searchSupplierStartDateTime.MaxDate;
            searchSupplierEndDateTime.MinDate = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
            searchSupplierEndDateTime.Value = searchSupplierEndDateTime.MinDate;
            supplierIDTextBox.Clear();
            supplierNameTextBox.Clear();

            searchCustomerStartDateTime.MaxDate = DateTime.Now.Date.AddDays(-1);
            searchCustomerStartDateTime.Value = searchCustomerStartDateTime.MaxDate;
            searchCustomerEndDateTime.MinDate = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
            searchCustomerEndDateTime.Value = searchCustomerEndDateTime.MinDate;
            customerIDTextBox.Clear();
            customerSurnameTextBox.Clear();
            customerGivenNameTextBox.Clear();
        }
    }
}
