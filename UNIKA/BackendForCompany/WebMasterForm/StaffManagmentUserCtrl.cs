using BackendClassLibrary;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Drawing;
using System.Resources;

namespace BackendForCompany.WebMasterForm
{
    public partial class StaffManagmentUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private EmployeeDA eda = new EmployeeDA();

        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(StaffManagmentUserCtrl).Assembly);

        private string staffID = null;

        private Regex nameFormat = new Regex("^([A-Z][a-z]{1,})(\\s[A-Z][a-z]{1,}){0,2}");

        public StaffManagmentUserCtrl(string staffID)
        {
            InitializeComponent();

            this.staffID = staffID;

            List<Employee> allStaffs = (new EmployeeDA()).getAllEmployees(conn);
            AutoCompleteStringCollection staffIdCollection = new AutoCompleteStringCollection();
            foreach (Employee staff in allStaffs)
                staffIdCollection.Add(staff.getEmployeeID());
            searchStaffIdTextBox.AutoCompleteCustomSource = staffIdCollection;
        }

        private void webMasterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string randId = "WM" + Security.getToken();
            Employee emp = eda.getOneEmployeeByID(randId, conn);
            Employee deletedEmp = eda.getOneDeletedEmployeeByID(randId, conn);
            while ((!string.IsNullOrWhiteSpace(emp.getEmployeeID()) && emp.getEmployeeID().Equals(randId)) || (!string.IsNullOrWhiteSpace(deletedEmp.getEmployeeID()) && deletedEmp.getEmployeeID().Equals(randId)))
            {
                randId = "WM" + Security.getToken();
            }
            idTextBox.Text = randId;
        }

        private void backendManagerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string randId = "MG" + Security.getToken();
            Employee emp = eda.getOneEmployeeByID(randId, conn);
            Employee deletedEmp = eda.getOneDeletedEmployeeByID(randId, conn);
            while ((!string.IsNullOrWhiteSpace(emp.getEmployeeID()) && emp.getEmployeeID().Equals(randId)) || (!string.IsNullOrWhiteSpace(deletedEmp.getEmployeeID()) && deletedEmp.Equals(randId)))
            {
                randId = "MG" + Security.getToken();
            }
            idTextBox.Text = randId;
        }

        private void backendStaffRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string randId = "ST" + Security.getToken();
            Employee emp = eda.getOneEmployeeByID(randId, conn);
            Employee deletedEmp = eda.getOneDeletedEmployeeByID(randId, conn);
            while ((!string.IsNullOrWhiteSpace(emp.getEmployeeID()) && emp.getEmployeeID().Equals(randId)) || (!string.IsNullOrWhiteSpace(deletedEmp.getEmployeeID()) && deletedEmp.Equals(randId)))
            {
                randId = "ST" + Security.getToken();
            }
            idTextBox.Text = randId;
        }

        private bool isInputCorrect()
        {
            bool correct = true;

            if (!webMasterRadioButton.Checked && !backendManagerRadioButton.Checked && !backendStaffRadioButton.Checked)
            {
                positionErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                positionErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(surnameTextBox.Text) || !nameFormat.IsMatch(surnameTextBox.Text))
            {
                surnameErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                surnameErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(givenNameTextBox.Text) || !nameFormat.IsMatch(givenNameTextBox.Text))
            {
                givenNameErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                givenNameErrorLabel.Visible = false;
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
                List<Employee> employees = eda.getAllEmployees(conn);
                List<Employee> deletedEmployee = eda.getAllDeletedEmployees(conn);
                if (!emailExist)
                    foreach(Employee emp in employees)
                        if(!string.IsNullOrWhiteSpace(emp.getEmail()) && emp.getEmail().Equals(emailTextBox.Text))
                            if (!string.IsNullOrWhiteSpace(emp.getEmployeeID()) && !emp.getEmployeeID().Equals(idTextBox.Text))
                            {
                                emailExist = true;
                                break;
                            }
                if (!emailExist)
                    foreach (Employee emp in deletedEmployee)
                        if (!string.IsNullOrWhiteSpace(emp.getEmail()) && emp.getEmail().Equals(emailTextBox.Text))
                            if (!string.IsNullOrWhiteSpace(emp.getEmployeeID()) && !emp.getEmployeeID().Equals(idTextBox.Text))
                            {
                                emailExist = true;
                                break;
                            }

                if(emailExist)
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

            return correct;
        }

        private void resetFormButton_Click(object sender, EventArgs e)
        {
            staffListDataGridView.ClearSelection();
            positionErrorLabel.Visible = false;
            surnameErrorLabel.Visible = false;
            givenNameErrorLabel.Visible = false;
            emailErrorLabel.Text = " ";
            emailErrorLabel.Visible = false;
            passwordHintLabel.ForeColor = SystemColors.ControlText;

            webMasterRadioButton.Enabled = true;
            backendManagerRadioButton.Enabled = true;
            backendStaffRadioButton.Enabled = true;
            webMasterRadioButton.Checked = false;
            backendManagerRadioButton.Checked = false;
            backendStaffRadioButton.Checked = false;
            idTextBox.Clear();
            surnameTextBox.Clear();
            givenNameTextBox.Clear();
            emailTextBox.Clear();
            passwordTextBox.Clear();
            searchStaffIdTextBox.Clear();
            passwordTextBox.Enabled = true;
            passwordHintLabel.Visible = true;

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
                Employee emp = new Employee();
                emp.setEmployeeID(idTextBox.Text);
                emp.setEmployeeSurname(surnameTextBox.Text);
                emp.setEmployeeGivenName(givenNameTextBox.Text);
                emp.setEmail(emailTextBox.Text);
                emp.setPassword(Security.getHash(passwordTextBox.Text, "SHA512", null));
                if (backendStaffRadioButton.Checked)
                    emp.setPosition("Staff");
                else if (backendManagerRadioButton.Checked)
                    emp.setPosition("Manager");
                else if (webMasterRadioButton.Checked)
                    emp.setPosition("Web Master");



                int i = eda.insert(emp, conn);
                if (i > 0)
                {
                    staffListDataGridView.Rows.Add(false, emp.getEmployeeID(), emp.getEmployeeSurname().ToUpper() + " " + emp.getEmployeeGivenName(), emp.getEmail(),
                        ((emp.getPosition().Equals("Staff")) ? rs.GetString("staffText") : ((emp.getPosition().Equals("Manager")) ? rs.GetString("managerText") : rs.GetString("webMasterText"))));

                    staffListDataGridView.ClearSelection();
                    foreach (DataGridViewRow row in staffListDataGridView.Rows)
                    {
                        if (idTextBox.Text.Equals(row.Cells["staffIdColumn"].Value.ToString()))
                        {
                            row.Selected = true;
                            staffListDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
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
                Employee emp = eda.getOneEmployeeByID(idTextBox.Text, conn);
                emp.setEmployeeSurname(surnameTextBox.Text);
                emp.setEmployeeGivenName(givenNameTextBox.Text);
                emp.setEmail(emailTextBox.Text);

                int i = eda.update(emp, idTextBox.Text, conn);
                if (i > 0)
                {
                    foreach (DataGridViewRow row in staffListDataGridView.Rows)
                    {
                        if (idTextBox.Text.Equals(row.Cells["staffIdColumn"].Value.ToString()))
                        {
                            row.Cells["staffIdColumn"].Value = emp.getEmployeeID();
                            row.Cells["staffNameColumn"].Value = emp.getEmployeeSurname().ToUpper() + " " + emp.getEmployeeGivenName();
                            row.Cells["emailColumn"].Value = emp.getEmail();
                            row.Cells["positionColumn"].Value = ((emp.getPosition().Equals("Staff")) ? rs.GetString("staffText") : ((emp.getPosition().Equals("Manager")) ? rs.GetString("managerText") : rs.GetString("webMasterText")));
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
            staffListDataGridView.Rows.Clear();
            staffListDataGridView.Refresh();

            List<Employee> emloyees = eda.getAllEmployees(conn);
            foreach (Employee emp in emloyees)
                if (emp.getEmployeeID().Equals(searchStaffIdTextBox.Text.ToUpper()))
                {
                    staffListDataGridView.Rows.Add(false, emp.getEmployeeID(), emp.getEmployeeSurname().ToUpper() + " " + emp.getEmployeeGivenName(), emp.getEmail(),
                        ((emp.getPosition().Equals("Staff")) ? rs.GetString("staffText") : ((emp.getPosition().Equals("Manager")) ? rs.GetString("managerText") : rs.GetString("webMasterText"))));

                    foreach (DataGridViewRow row in staffListDataGridView.Rows)
                        if (staffID.Equals(row.Cells["staffIdColumn"].Value.ToString()))
                            row.Cells["selectedStaffColumn"].ReadOnly = true;
                }

            staffListDataGridView.ClearSelection();

            if (staffListDataGridView.Rows.Count > 0)
            {
                deleteButton.Enabled = true;
                deselectAllButton.Enabled = true;
                selectAllButton.Enabled = true;

                foreach (DataGridViewRow row in staffListDataGridView.Rows)
                {
                    if (idTextBox.Text.Equals(row.Cells["staffIdColumn"].Value.ToString()))
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
            staffListDataGridView.Rows.Clear();
            staffListDataGridView.Refresh();

            List<Employee> emloyees = eda.getAllEmployees(conn);
            foreach (Employee emp in emloyees)
            {
                    staffListDataGridView.Rows.Add(false, emp.getEmployeeID(), emp.getEmployeeSurname().ToUpper() + " " + emp.getEmployeeGivenName(), emp.getEmail(),
                        ((emp.getPosition().Equals("Staff")) ? rs.GetString("staffText") : ((emp.getPosition().Equals("Manager")) ? rs.GetString("managerText") : rs.GetString("webMasterText"))));

                foreach (DataGridViewRow row in staffListDataGridView.Rows)
                    if (staffID.Equals(row.Cells["staffIdColumn"].Value.ToString()))
                        row.Cells["selectedStaffColumn"].ReadOnly = true;
            }

            staffListDataGridView.ClearSelection();

            if (staffListDataGridView.Rows.Count > 0)
            {
                deleteButton.Enabled = true;
                deselectAllButton.Enabled = true;
                selectAllButton.Enabled = true;

                foreach (DataGridViewRow row in staffListDataGridView.Rows)
                {
                    if (idTextBox.Text.Equals(row.Cells["staffIdColumn"].Value.ToString()))
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
            staffListDataGridView.Rows.Clear();
            staffListDataGridView.Refresh();
            staffListDataGridView.ClearSelection();

            deleteButton.Enabled = false;
            deselectAllButton.Enabled = false;
            selectAllButton.Enabled = false;
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in staffListDataGridView.Rows)
            {
                if (!(bool)row.Cells["selectedStaffColumn"].Value)
                {
                    if (!staffID.Equals(row.Cells["staffIdColumn"].Value.ToString()))
                        row.Cells["selectedStaffColumn"].Value = true;
                }
            }
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in staffListDataGridView.Rows)
            {
                if ((bool)row.Cells["selectedStaffColumn"].Value)
                {
                    row.Cells["selectedStaffColumn"].Value = false;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(rs.GetString("deleteAccountYesNoMsg"), rs.GetString("deleteTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = 0;

                for (int i = staffListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)staffListDataGridView.Rows[i].Cells["selectedStaffColumn"].Value;
                    if (delete == true)
                    {
                        eda.delete((string)staffListDataGridView.Rows[i].Cells["staffIdColumn"].Value, conn);
                        staffListDataGridView.Rows.Remove(staffListDataGridView.Rows[i]);
                        count++;
                    }
                }

                if (count == 0)
                    MessageBox.Show(rs.GetString("selectAccountMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (staffListDataGridView.Rows.Count > 0)
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

                    staffListDataGridView.ClearSelection();

                    resetFormButton_Click(null, null);

                    MessageBox.Show(rs.GetString("deleteAccountMsg"));
                }
            }
        }

        private void staffListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                webMasterRadioButton.Enabled = false;
                backendManagerRadioButton.Enabled = false;
                backendStaffRadioButton.Enabled = false;
                addButton.Enabled = false;
                updateButton.Enabled = true;
                staffIdHintLabel.Visible = false;
                Employee emp = eda.getOneEmployeeByID(staffListDataGridView.Rows[e.RowIndex].Cells["staffIdColumn"].Value.ToString(), conn);
                if(emp.getPosition().Equals("Staff"))
                    backendStaffRadioButton.Checked = true;
                else if (emp.getPosition().Equals("Manager"))
                    backendManagerRadioButton.Checked = true;
                else if (emp.getPosition().Equals("Web Master"))
                    webMasterRadioButton.Checked = true;

                idTextBox.Text = emp.getEmployeeID();
                surnameTextBox.Text = emp.getEmployeeSurname();
                givenNameTextBox.Text = emp.getEmployeeGivenName();
                emailTextBox.Text = emp.getEmail();
                passwordTextBox.Enabled = false;
                passwordHintLabel.Visible = false;
            }
        }
    }
}
