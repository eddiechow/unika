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

namespace BackendForCompany
{

    public partial class LoginForm : MetroForm
    {


        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(LoginForm).Assembly);

        private string[][] formList = {
            new string[] { "Staff", "StaffForm" },
            new string[] { "Manager", "ManagerForm" },
            new string[] { "Web Master", "WebMasterForm" }
        };

        private Form mainForm = null;
        private ForgetPasswordForm fpf = null;

        public LoginForm()
        {
            InitializeComponent();

            Language.setLanguageComboBox(languageComboBox);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDA eda = new EmployeeDA();
                Employee emp = eda.getOneEmployeeByID(idTextbox.Text, conn);
                EmployeeLoginLogDA elda = new EmployeeLoginLogDA();

                if (!string.IsNullOrWhiteSpace(idTextbox.Text) && !string.IsNullOrEmpty(passwordTextbox.Text))
                {
                    if (!string.IsNullOrWhiteSpace(emp.getEmployeeID()) && !string.IsNullOrWhiteSpace(emp.getPassword()))
                    {
                        List<LoginLog> logs = elda.searchLogs(DateTime.Now.AddHours(-0.5), DateTime.Now, emp.getEmployeeID(), "", "", conn);

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
                            ll.setAccountID(emp.getEmployeeID());
                            ll.setSuccess(false);
                            ll.setPasswordIncorrect(false);
                            ll.setLocked(false);
                            ll.setAcStatusTempLock(true);
                            ll.setTime(DateTime.Now);
                            elda.insert(ll, conn);
                            MessageBox.Show(rs.GetString("accountLockedMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (unlockedTime.HasValue)
                            {
                                logs = null;
                                logs = elda.searchLogs(unlockedTime.Value.AddMinutes(1), DateTime.Now, emp.getEmployeeID(), "", "", conn);
                            }

                            if (emp.getEmployeeID().Equals(idTextbox.Text) && Security.verifyHash(passwordTextbox.Text, "SHA512", emp.getPassword()))
                            {
                                LoginLog ll = new LoginLog();
                                ll.setAccountID(emp.getEmployeeID());
                                ll.setSuccess(true);
                                ll.setPasswordIncorrect(false);
                                ll.setLocked(false);
                                ll.setAcStatusTempLock(false);
                                ll.setTime(DateTime.Now);
                                elda.insert(ll, conn);

                                for (int i = 0; i < formList.Length; i++)
                                {
                                    if (emp.getPosition().Equals(formList[i][0]))
                                    {
                                        if (emp.getPosition().Equals("Staff"))
                                        {
                                            Properties.Settings setting = Properties.Settings.Default;
                                            if (string.IsNullOrWhiteSpace(setting.receiptPrinter))
                                            {
                                                MessageBox.Show(rs.GetString("selectReceiptPrinterFirstMsg"));
                                                ReceiptPrinterSettingForm fm = new ReceiptPrinterSettingForm();
                                                fm.ShowDialog();
                                            }
                                        }
                                        Visible = false;
                                        mainForm = (Form)Activator.CreateInstance(Type.GetType(GetType().Namespace + "." + formList[i][1] + ".MainForm"), emp.getEmployeeID());
                                        mainForm.FormClosed += new FormClosedEventHandler(mainForm_Closed);
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
                                                ll.setAccountID(emp.getEmployeeID());
                                                ll.setSuccess(false);
                                                ll.setPasswordIncorrect(true);
                                                ll.setLocked(true);
                                                ll.setAcStatusTempLock(false);
                                                ll.setTime(DateTime.Now);
                                                elda.insert(ll, conn);
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
                                        ll.setAccountID(emp.getEmployeeID());
                                        ll.setSuccess(false);
                                        ll.setPasswordIncorrect(true);
                                        ll.setLocked(false);
                                        ll.setAcStatusTempLock(false);
                                        ll.setTime(DateTime.Now);
                                        elda.insert(ll, conn);
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
