using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using BackendClassLibrary;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System.Collections.Specialized;

namespace BackendForSupplier
{

    public partial class LoginForm : MetroForm
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForSupplier.Properties.Resources", typeof(LoginForm).Assembly);

        private Properties.Settings setting = Properties.Settings.Default;

        private string[][] formList = {
            new string[] { "Bottle", "BottleSupplierForm" },
            new string[] { "Package", "PackageSupplierForm" },
            new string[] { "Perfume", "PerfumeSupplierForm" }
        };

        private Form mainForm = null;
        private ForgetPasswordForm fpf = null;

        public LoginForm()
        {
            InitializeComponent();

            Language.setLanguageComboBox(languageComboBox);
        }

        private void showStockAlert(string supplierID, string productCategory)
        {
            if (setting.stockAlert)
            {
                string alertMessage = null;

                if (productCategory.Equals("Bottle"))
                {
                    StringCollection showedStockAlertBottle = setting.showedStockAlertBottle;
                    ProductBottleDA pbda = new ProductBottleDA();
                    List<Bottle> bList = pbda.findProductBottlesBySupplierID(supplierID, Language.getLanguageCode(), conn);
                    foreach (Bottle b in bList)
                        if (b.getQtyInStock() < 1)
                        {
                            if (!showedStockAlertBottle.Contains(b.getProductID()))
                            {
                                alertMessage += "\n - " + b.getProductName();
                                showedStockAlertBottle.Add(b.getProductID());
                                setting.Save();
                            }
                        }
                        else
                        {
                            showedStockAlertBottle.Remove(b.getProductID());
                            setting.Save();
                        }
                            
                }
                if (productCategory.Equals("Package"))
                {
                    StringCollection showedStockAlertPackage = setting.showedStockAlertPackage;
                    ProductPackageDA ppda = new ProductPackageDA();
                    List<Package> pList = ppda.findProductPackagesBySupplierID(supplierID, Language.getLanguageCode(), conn);
                    foreach (Package p in pList)
                        if (p.getQtyInStock() < 1)
                        {
                            if (!showedStockAlertPackage.Contains(p.getProductID()))
                            {
                                alertMessage += "\n - " + p.getProductName();
                                showedStockAlertPackage.Add(p.getProductID());
                                setting.Save();
                            }
                        }
                        else
                        {
                            showedStockAlertPackage.Remove(p.getProductID());
                            setting.Save();
                        }
                }
                if (productCategory.Equals("Perfume"))
                {
                    StringCollection showedStockAlertPerfume = setting.showedStockAlertPerfume;
                    ProductPerfumeDA ppda = new ProductPerfumeDA();
                    List<Perfume> pList = ppda.findProductPerfumeBySupplierID(supplierID, Language.getLanguageCode(), conn);
                    foreach (Perfume p in pList)
                        if (p.getQtyInStock() < 50)
                        {
                            if (!showedStockAlertPerfume.Contains(p.getProductID()))
                            {
                                alertMessage += "\n - " + p.getProductName();
                                showedStockAlertPerfume.Add(p.getProductID());
                                setting.Save();
                            }
                        }
                        else
                        {
                            showedStockAlertPerfume.Remove(p.getProductID());
                            setting.Save();
                        }
                }

                if (alertMessage != null)
                {
                    if(productCategory.Equals("Perfume"))
                        alertMessage = rs.GetString("stockAlertMsg") + alertMessage;
                    else
                        alertMessage = rs.GetString("stockAlertNoItemMsg") + alertMessage;

                    MessageBox.Show(alertMessage, rs.GetString("stockAlertTitle"));
                }
            }
        }

        private void showRecycleBinAlert(string supplierID, string productCategory)
        {
            string alertMessage = null;

            if (productCategory.Equals("Bottle"))
            {
                StringCollection showedDeletedAlertBottle = setting.showedDeletedAlertBottle;
                ProductBottleDA pbda = new ProductBottleDA();
                List<Bottle> bList = pbda.findDeletedProductBottlesBySupplierID(supplierID, Language.getLanguageCode(), conn);
                foreach (Bottle b in bList)
                    if (b.getDateDeleted().Date <= DateTime.Now.Date.AddYears(-1))
                    {
                        if (!showedDeletedAlertBottle.Contains(b.getProductID()))
                        {
                            alertMessage += "\n - " + b.getProductName();
                            showedDeletedAlertBottle.Add(b.getProductID());
                            setting.Save();
                        }
                    }
                    else
                    {
                        showedDeletedAlertBottle.Remove(b.getProductID());
                        setting.Save();
                    }
            }
            if (productCategory.Equals("Package"))
            {
                StringCollection showedDeletedAlertPackage = setting.showedDeletedAlertPackage;
                ProductPackageDA ppda = new ProductPackageDA();
                List<Package> pList = ppda.findDeletedProductPackagesBySupplierID(supplierID, Language.getLanguageCode(), conn);
                foreach (Package p in pList)
                    if (p.getDateDeleted().Date <= DateTime.Now.Date.AddYears(-1))
                    {
                        if (!showedDeletedAlertPackage.Contains(p.getProductID()))
                        {
                            alertMessage += "\n - " + p.getProductName();
                            showedDeletedAlertPackage.Add(p.getProductID());
                            setting.Save();
                        }
                    }
                    else
                    {
                        showedDeletedAlertPackage.Remove(p.getProductID());
                        setting.Save();
                    }
            }
            if (productCategory.Equals("Perfume"))
            {
                StringCollection showedDeletedAlertPerfume = setting.showedDeletedAlertPerfume;
                ProductPerfumeDA ppda = new ProductPerfumeDA();
                List<Perfume> pList = ppda.findDeletedProductPerfumeBySupplierID(supplierID, Language.getLanguageCode(), conn);
                foreach (Perfume p in pList)
                    if (p.getDateDeleted().Date <= DateTime.Now.Date.AddYears(-1))
                    {
                        if (!showedDeletedAlertPerfume.Contains(p.getProductID()))
                        {
                            alertMessage += "\n - " + p.getProductName();
                            showedDeletedAlertPerfume.Add(p.getProductID());
                            setting.Save();
                        }
                    }
                    else
                    {
                        showedDeletedAlertPerfume.Remove(p.getProductID());
                        setting.Save();
                    }
            }

            if (alertMessage != null)
            {
                alertMessage = rs.GetString("recycleBinAlertMsg") + alertMessage;
                MessageBox.Show(alertMessage, rs.GetString("recycleBinAlertTitle"));
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierDA sda = new SupplierDA();
                Supplier sup = sda.getOneSupplierByID(idTextbox.Text, conn);
                SupplierLoginLogDA slda = new SupplierLoginLogDA();

                if (!string.IsNullOrWhiteSpace(idTextbox.Text) && !string.IsNullOrEmpty(passwordTextbox.Text))
                {
                    if (!string.IsNullOrWhiteSpace(sup.getSupplierID()) && !string.IsNullOrWhiteSpace(sup.getPassword()))
                    {
                        List<LoginLog> logs = slda.searchLogs(DateTime.Now.AddHours(-0.5), DateTime.Now, sup.getSupplierID(), "", conn);

                        bool isLocked = false;
                        DateTime? unlockedTime = null;
                        for (int i = 0; i < logs.Count; i++)
                        {
                            if (logs.ElementAt(i).getLocked())
                            {
                                isLocked = true;
                            }
                            if (!string.IsNullOrEmpty(logs.ElementAt(i).getUnlockedByEmpID()))
                            {
                                isLocked = false;
                                unlockedTime = logs.ElementAt(i).getTime();
                            }
                        }

                        if (isLocked)
                        {
                            LoginLog ll = new LoginLog();
                            ll.setAccountID(sup.getSupplierID());
                            ll.setSuccess(false);
                            ll.setPasswordIncorrect(false);
                            ll.setLocked(false);
                            ll.setAcStatusTempLock(true);
                            ll.setTime(DateTime.Now);
                            slda.insert(ll, conn);
                            MessageBox.Show(rs.GetString("accountLockedMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (unlockedTime.HasValue)
                            {
                                logs = null;
                                logs = slda.searchLogs(unlockedTime.Value.AddMinutes(1), DateTime.Now, sup.getSupplierID(), "", conn);
                            }

                            if (sup.getSupplierID().Equals(idTextbox.Text) && Security.verifyHash(passwordTextbox.Text, "SHA512", sup.getPassword()))
                            {
                                LoginLog ll = new LoginLog();
                                ll.setAccountID(sup.getSupplierID());
                                ll.setSuccess(true);
                                ll.setPasswordIncorrect(false);
                                ll.setLocked(false);
                                ll.setAcStatusTempLock(false);
                                ll.setTime(DateTime.Now);
                                slda.insert(ll, conn);

                                for (int i = 0; i < formList.Length; i++)
                                {
                                    if (sup.getProductCategory().Equals(formList[i][0]))
                                    {
                                        Visible = false;
                                        mainForm = (Form)Activator.CreateInstance(Type.GetType(GetType().Namespace + "." + formList[i][1] + ".MainForm"), sup.getSupplierID());
                                        mainForm.FormClosed += new FormClosedEventHandler(mainForm_Closed);
                                        showStockAlert(sup.getSupplierID(), sup.getProductCategory());
                                        showRecycleBinAlert(sup.getSupplierID(), sup.getProductCategory());
                                        mainForm.ShowDialog();
                                        break;
                                    }
                                }
                            }
                            else
                            {

                                int attempts = 1;
                                for (int i = 0; i <= logs.Count; i++)
                                {
                                    if (i < logs.Count)
                                    {
                                        if (logs.ElementAt(i).getPasswordIncorrect())
                                        {
                                            if (attempts == 4)
                                            {
                                                LoginLog ll = new LoginLog();
                                                ll.setAccountID(sup.getSupplierID());
                                                ll.setSuccess(false);
                                                ll.setPasswordIncorrect(true);
                                                ll.setLocked(true);
                                                ll.setAcStatusTempLock(false);
                                                ll.setTime(DateTime.Now);
                                                slda.insert(ll, conn);
                                                MessageBox.Show(rs.GetString("accountLock30MinMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                break;
                                            }
                                            attempts++;
                                        }
                                        else if (logs.ElementAt(i).getSuccess())
                                        {
                                            attempts = 1;
                                        }

                                    }
                                    else if (i == logs.Count)
                                    {
                                        LoginLog ll = new LoginLog();
                                        ll.setAccountID(sup.getSupplierID());
                                        ll.setSuccess(false);
                                        ll.setPasswordIncorrect(true);
                                        ll.setLocked(false);
                                        ll.setAcStatusTempLock(false);
                                        ll.setTime(DateTime.Now);
                                        slda.insert(ll, conn);
                                        MessageBox.Show(rs.GetString("idPasswdIncorrectMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(rs.GetString("idPasswdIncorrectMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(rs.GetString("inputIdPasswordMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                idTextbox.Text = "";
                passwordTextbox.Text = "";
            }
            catch (MySqlException ex)
            {
               Database.showErrorMessage(ex.Number);
            }
            catch (Exception)
            {
                MessageBox.Show("System error.\nPlease contact administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void mainForm_Closed(object sender, EventArgs e)
        {
            mainForm = null;
            Visible = true;
            Clipboard.Clear();
            languageComboBox.SelectedValue = Language.getLanguageCode();
        }

        private void forgetPasswordButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            fpf = new ForgetPasswordForm();
            fpf.FormClosed += new FormClosedEventHandler(forgetPasswordForm_Closed);
            fpf.ShowDialog();
        }

        private void forgetPasswordForm_Closed(object sender, EventArgs e)
        {
            fpf = null;
            Clipboard.Clear();
            Enabled = true;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clipboard.Clear();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Language.setLanguage((string)languageComboBox.SelectedValue);
        }
    }
}
