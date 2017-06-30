using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Controls;
using BackendClassLibrary;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System.Resources;

namespace BackendForSupplier.PackageSupplierForm
{
    public partial class ChangePasswordUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForSupplier.Properties.Resources", typeof(ChangePasswordUserCtrl).Assembly);

        private string supplierID = null;

        public ChangePasswordUserCtrl(string supplierID)
        {
            InitializeComponent();

            this.supplierID = supplierID;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            bool error = false;

            SupplierDA sda = new SupplierDA();
            Supplier sup = sda.getOneSupplierByID(supplierID, conn);

            if (string.IsNullOrWhiteSpace(currentPasswordTextBox.Text) || !Security.verifyHash(currentPasswordTextBox.Text, "SHA512", sup.getPassword()))
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
                sup.setPassword(Security.getHash(newPasswordTextBox.Text, "SHA512", null));
                int i = sda.update(sup, sup.getSupplierID(), conn);
                if (i > 0)
                {
                    MessageBox.Show(rs.GetString("passwordChangedMsg"));
                    sup = null;
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
