using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Resources;
using System.Windows.Forms;
using BackendClassLibrary;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;

namespace BackendForCompany
{
    public partial class ForgetPasswordForm : MetroForm
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(ForgetPasswordForm).Assembly);

        private EmployeeDA eda = new EmployeeDA();
        private Employee emp = null;

        private string token = null;
        private int second;

        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void sendTokenButton_Click(object sender, EventArgs e)
        {
            emp = eda.getOneEmployeeByID(idTextbox.Text, conn);

            if (string.IsNullOrWhiteSpace(idTextbox.Text) || string.IsNullOrEmpty(emp.getEmployeeID()))
            {
                idErrorLabel.Visible = true;
                emp = null;
            }
            else
            {
                token = Security.getToken();

                string recipients = emp.getEmail();
                string givenName = emp.getEmployeeGivenName();
                string subject = rs.GetString("resetPasswdEmailSubjectText");
                string body = givenName + rs.GetString("resetPasswdEmailBodyText1") + token + rs.GetString("resetPasswdEmailBodyText2");

                try
                {
                    Email.send(recipients, subject, body);
                    MessageBox.Show(rs.GetString("tokenIsSentMsg"));
                    idTextbox.Enabled = false;
                }
                catch (System.Net.Mail.SmtpException)
                {
                    MessageBox.Show(rs.GetString("failToSendMailMsg"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                second = 300;
                tokenTimer.Start();
            }
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (string.IsNullOrWhiteSpace(token) || string.IsNullOrWhiteSpace(tokenTextbox.Text) || !token.Equals(tokenTextbox.Text))
            {
                tokenErrorLabel.Visible = true;
                error = true;
            }
            else
            {
                tokenErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(newPasswordTextbox.Text) || !FormatChecker.checkPasswdFormat(newPasswordTextbox.Text))
            {
                newPasswordErrorLabel.Visible = true;
                error = true;
            }
            else
            {
                newPasswordErrorLabel.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(confirmPasswordTextbox.Text) || !confirmPasswordTextbox.Text.Equals(confirmPasswordTextbox.Text))
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
                emp.setPassword(Security.getHash(newPasswordTextbox.Text, "SHA512", null));
                int i = eda.update(emp, emp.getEmployeeID(), conn);
                if (i > 0)
                {
                    MessageBox.Show(rs.GetString("passwordChangedMsg"));

                    emp = null;
                    token = null;

                    tokenTimer.Stop();

                    idTextbox.Text = "";
                    idTextbox.Enabled = true;
                }
                else
                {
                    MessageBox.Show(rs.GetString("failToChangePasswdMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            tokenTextbox.Clear();
            newPasswordTextbox.Clear();
            confirmPasswordTextbox.Clear();
        }

        private void tokenTimer_Tick(object sender, EventArgs e)
        {
            second--;
            if (second == 0)
            {
                emp = null;
                token = null;
                tokenTimer.Stop();
            }
        }
    }
}
