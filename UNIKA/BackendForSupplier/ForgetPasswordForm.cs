using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Resources;
using System.Windows.Forms;
using BackendClassLibrary;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;

namespace BackendForSupplier
{
    public partial class ForgetPasswordForm : MetroForm
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForSupplier.Properties.Resources", typeof(ForgetPasswordForm).Assembly);

        private SupplierDA sda = new SupplierDA();
        private Supplier sup = null;

        private string token = null;
        private int second;

        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void sendTokenButton_Click(object sender, EventArgs e)
        {
            sup = sda.getOneSupplierByID(idTextbox.Text, conn);

            if (string.IsNullOrWhiteSpace(idTextbox.Text) || string.IsNullOrEmpty(sup.getSupplierID()))
            {
                idErrorLabel.Visible = true;
                sup = null;
            }
            else
            {
                token = Security.getToken();

                string recipients = sup.getEmail();
                string givenName = sup.getSupplierName();
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
                sup.setPassword(Security.getHash(newPasswordTextbox.Text, "SHA512", null));
                int i = sda.update(sup, sup.getSupplierID(), conn);
                if (i > 0)
                {
                    MessageBox.Show(rs.GetString("passwordChangedMsg"));

                    sup = null;
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
                sup = null;
                token = null;
                tokenTimer.Stop();
            }
        }
    }
}
