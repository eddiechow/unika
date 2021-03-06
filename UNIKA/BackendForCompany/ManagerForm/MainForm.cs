﻿using BackendClassLibrary;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace BackendForCompany.ManagerForm
{

    public partial class MainForm : MetroForm
    {
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(MainForm).Assembly);
        private UserControl userControlInstance;

        private string[][] menuList = {
            new string[] { "homeIcon", "homeLabel", "HomeUserCtrl" },
            new string[] { "setPromotionIcon", "setPromotionLabel", "SetPromotionUserCtrl" },
            new string[] { "handleEcommerceContentIcon", "handleEcommerceContentLabel", "HandleEcommerceContentUserCtrl" },
            new string[] { "generateSalesReportIcon", "generateSalesReportLabel", "GeneratesSalesReportUserCtrl" },
            new string[] { "handleCustomerAccountIcon", "handleCustomerAccountLabel", "HandleCustomerAccountUserCtrl" },
            new string[] { "refundIcon", "refundLabel", "RefundUserCtrl"},
            new string[] { "recycleBinIcon", "recycleBinLabel", "RecycleBinUserCtrl" },
            new string[] { "resetPasswordIcon", "resetPasswordLabel", "ChangePasswordUserCtrl" },
            new string[] { "logoutIcon", "logoutLabel", null }
        };

        private string staffID = null;
        private int oldWidth=45;
        private int oldHeight=47;

        public MainForm(string staffID)
        {
            this.staffID = staffID;

            InitializeComponent();

            Language.setLanguageComboBox(languageComboBox);

            loadUserContorl((string)"HomeUserCtrl", null);
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Language.setLanguage((string)languageComboBox.SelectedValue);
            if (mainPanel.Controls.Contains(userControlInstance))
                loadUserContorl((string)userControlInstance.GetType().Name, null);
        }

        //Form closing event
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(rs.GetString("askLogoutDialogbox"), rs.GetString("logoutText"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //All Menu Button
        private void menu_MouseHover(object sender, EventArgs e)
        {
            PictureBox pb = null;
            if (sender is PictureBox)
            {
                pb = (PictureBox)sender;
            }
            else if (sender is Label)
            {
                Label label = (Label)sender;
                for (int i = 0; i < menuList.Length; i++)
                {
                    if (menuList[i][1].Equals(label.Name))
                    {
                        foreach (PictureBox c in menuPanel.Controls.OfType<PictureBox>())
                        {
                            if (c.Name == menuList[i][0])
                            {
                                pb = c;
                                break;
                            }
                        }
                        break;
                    }
                }
            }

            if (pb != null)
            {
                oldWidth = pb.Width;
                oldHeight = pb.Height;
                pb.Width = pb.Width + 20;
                pb.Height = pb.Height + 20;
            }
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = null;
            if (sender is PictureBox)
            {
                pb = (PictureBox)sender;
            }
            else if (sender is Label)
            {
                Label label = (Label)sender;
                for (int i = 0; i < menuList.Length; i++)
                {
                    if (menuList[i][1].Equals(label.Name))
                    {
                        foreach (PictureBox c in menuPanel.Controls.OfType<PictureBox>())
                        {
                            if (c.Name == menuList[i][0])
                            {
                                pb = c;
                                break;
                            }
                        }
                        break;
                    }
                }
            }

            if (pb!=null)
            {
                pb.Width = oldWidth;
                pb.Height = oldHeight;
            }
        }

        private void loadUserContorl(object sender, EventArgs e)
        {
            string userCntrol = "";
            if (sender is PictureBox)
            {
                PictureBox tb = (PictureBox)sender;
                for (int i = 0; i < menuList.Length; i++)
                {
                    if (tb.Name == menuList[i][0])
                    {
                        userCntrol = menuList[i][2];
                        break;
                    }
                }
            }
            else if (sender is Label)
            {
                Label lable = (Label)sender;
                for (int i = 0; i < menuList.Length; i++)
                {
                    if (lable.Name == menuList[i][1])
                    {
                        userCntrol = menuList[i][2];
                        break;
                    }
                }
            }
            else if (sender is string)
            {
                userCntrol = (string)sender;
            }

            if (userCntrol==null)
            {
                Close();
            }
            else
            {
                userControlInstance = (UserControl)Activator.CreateInstance(Type.GetType(GetType().Namespace+"."+userCntrol), staffID);
                if (!mainPanel.Controls.Contains(userControlInstance))
                {
                    mainPanel.Controls.Add(userControlInstance);
                    userControlInstance.Dock = DockStyle.Fill;
                    userControlInstance.BringToFront();
                }
                else
                    userControlInstance.BringToFront();
            }
        }
    }
}
