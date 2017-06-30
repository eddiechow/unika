using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Controls;
using BackendClassLibrary;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System.Resources;

namespace BackendForCompany.ManagerForm
{
    public partial class ChangePasswordUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(ChangePasswordUserCtrl).Assembly);

        private string staffID = null;

        public ChangePasswordUserCtrl(string staffID)
        {
            InitializeComponent();

            this.staffID = staffID;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            bool error = false;

            EmployeeDA eda = new EmployeeDA();
            Employee emp = eda.getOneEmployeeByID(staffID, conn);

            if (string.IsNullOrWhiteSpace(currentPasswordTextBox.Text) || !Security.verifyHash(currentPasswordTextBox.Text, "SHA512", emp.getPassword()))
            {
                currentPasswordErrorLabel.Visible = true;
                error = true;
            }
            else
            {
                currentPasswordErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text) || !FormatChecker.checkPasswdFormat(newPasswordTextBox.Text))
            {
                newPasswordErrorLabel.Visible = true;
                error = true;
            }
            else
            {
                newPasswordErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text) || !newPasswordTextBox.Text.Equals(confirmPasswordTextBox.Text))
            {
                confirmPasswordErrorLabel.Visible = true;
                error = true;
            }
            else
            {
                confirmPasswordErrorLabel.Visible = false;
            }

            if (!error)
            {
                emp.setPassword(Security.getHash(newPasswordTextBox.Text, "SHA512", null));
                int i = eda.update(emp, staffID, conn);
                if (i > 0)
                {
                    MessageBox.Show(rs.GetString("passwordChangedMsg"));
                    emp = null;
                }
                else
                {
                    MessageBox.Show(rs.GetString("failToChangePasswdMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            currentPasswordTextBox.Clear();
            newPasswordTextBox.Clear();
            confirmPasswordTextBox.Clear();

        }
    }
}
