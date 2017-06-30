using BackendClassLibrary;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using MetroFramework.Controls;
using System.Resources;

namespace BackendForCompany.ManagerForm
{
    public partial class HandleEcommerceContentUserCtrl : MetroUserControl
    {
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(HandleEcommerceContentUserCtrl).Assembly);

        private string staffID;

        private MySqlConnection conn = Database.getConnection();
        private NoticeDA nda = new NoticeDA();

        private int? selectedNoticeId = null;

        public HandleEcommerceContentUserCtrl(string staffID)
        {
            InitializeComponent();
            this.staffID = staffID;

        }

        private bool isInputCorrect()
        {
            bool correct = true;
            Regex illegalWord = new Regex("^[-_!@#^&*'+=]$");
            Regex englishWord = new Regex("^[ a-zA-Z0-9,.():]+$");
            
            if(illegalWord.IsMatch(engContentTextBox.Text) || illegalWord.IsMatch(tradChiContentTextBox.Text))
            {
                illegalWordHintLabel.ForeColor = Color.Red;
                correct = false;
            }
            else
            {
                illegalWordHintLabel.ForeColor = SystemColors.ControlText;
            }

            if(!englishWord.IsMatch(engContentTextBox.Text))
            {
                engContentErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                engContentErrorLabel.Visible = false;
            }

            if (!FormatChecker.includeChineseChar(tradChiContentTextBox.Text))
            {
                tradChiContentErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                tradChiContentErrorLabel.Visible = false;
            }

            return correct;
        }

        private void resetFormButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            updateButton.Enabled = false;
            selectedNoticeId = null;
            engContentTextBox.Clear();
            tradChiContentTextBox.Clear();
            noticeListDataGridView.ClearSelection();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isInputCorrect())
            {
                Notice notice = new Notice();
                notice.setContentEnUs(engContentTextBox.Text);
                notice.setContentZhHant(tradChiContentTextBox.Text);
                notice.setReleasedByEmpID(staffID);

                int i = nda.insert(notice, conn);
                if (i > 0)
                {
                    selectedNoticeId = notice.getNoticeID();

                    Employee emp = new EmployeeDA().getOneEmployeeByID(staffID, conn);

                    noticeListDataGridView.Rows.Add(false, notice.getNoticeID(), notice.getContentEnUs(), notice.getContentZhHant(),
                        emp.getEmployeeSurname() + ", " + emp.getEmployeeGivenName()+" ("+notice.getReleasedByEmpID()+")");

                    noticeListDataGridView.ClearSelection();
                    foreach (DataGridViewRow row in noticeListDataGridView.Rows)
                    {
                        if (selectedNoticeId.Value == (int)row.Cells["noticeIdColumn"].Value)
                        {
                            row.Selected = true;
                            noticeListDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        }
                    }

                    deleteButton.Enabled = true;
                    deselectAllButton.Enabled = true;
                    selectAllButton.Enabled = true;

                    addButton.Enabled = false;
                    updateButton.Enabled = true;

                    MessageBox.Show(rs.GetString("addSuccessMsg"));
                } else 
                    MessageBox.Show(rs.GetString("failToAddMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (isInputCorrect())
            {
                Notice notice = nda.getOneNoticeByID(Language.getLanguageCode(), selectedNoticeId.Value, conn);
                notice.setContentEnUs(engContentTextBox.Text);
                notice.setContentZhHant(tradChiContentTextBox.Text);

                int i = nda.update(notice, conn);
                if (i > 0)
                {
                    foreach (DataGridViewRow row in noticeListDataGridView.Rows)
                    {
                        if (selectedNoticeId.Value == (int)row.Cells["noticeIdColumn"].Value)
                        {
                            row.Cells["engContentColumn"].Value = notice.getContentEnUs();
                            row.Cells["tradChiContentColumn"].Value = notice.getContentZhHant();
                        }
                    }
                    MessageBox.Show(rs.GetString("updateSuccessMsg"));
                }
            }
            else
                MessageBox.Show(rs.GetString("failToUpdateMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            noticeListDataGridView.Rows.Clear();
            noticeListDataGridView.Refresh();

            List<Notice> noticeList = nda.getAllNotice(Language.getLanguageCode(), conn);
            foreach (Notice notice in noticeList)
                if (!string.IsNullOrWhiteSpace(keywordTextBox.Text) && ((notice.getContentEnUs().ToLower()).Contains(keywordTextBox.Text.ToLower()) || notice.getContentZhHant().Contains(keywordTextBox.Text)))
                    noticeListDataGridView.Rows.Add(false, notice.getNoticeID(), notice.getContentEnUs(), notice.getContentZhHant(),
                        notice.getReleasedBy() + " (" + notice.getReleasedByEmpID() + ")");


            noticeListDataGridView.ClearSelection();

            if (noticeListDataGridView.Rows.Count > 0)
            {
                deleteButton.Enabled = true;
                deselectAllButton.Enabled = true;
                selectAllButton.Enabled = true;

                foreach (DataGridViewRow row in noticeListDataGridView.Rows)
                {
                    if(selectedNoticeId.HasValue && (selectedNoticeId.Value== (int)row.Cells["noticeIdColumn"].Value))
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
            noticeListDataGridView.Rows.Clear();
            noticeListDataGridView.Refresh();


            List<Notice> noticeList = nda.getAllNotice(Language.getLanguageCode(), conn);
            foreach (Notice notice in noticeList)
                noticeListDataGridView.Rows.Add(false, notice.getNoticeID(), notice.getContentEnUs(), notice.getContentZhHant(),
                    notice.getReleasedBy() + " (" + notice.getReleasedByEmpID() + ")");




            noticeListDataGridView.ClearSelection();

            if (noticeListDataGridView.Rows.Count > 0)
            {
                deleteButton.Enabled = true;
                deselectAllButton.Enabled = true;
                selectAllButton.Enabled = true;

                foreach (DataGridViewRow row in noticeListDataGridView.Rows)
                {
                    if (selectedNoticeId.HasValue && (selectedNoticeId.Value == (int)row.Cells["noticeIdColumn"].Value))
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

        private void listResetButton_Click(object sender, EventArgs e)
        {
            keywordTextBox.Clear();
            noticeListDataGridView.Rows.Clear();
            noticeListDataGridView.Refresh();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in noticeListDataGridView.Rows)
            {
                if (!(bool)row.Cells["selectedNoticeColumn"].Value)
                    row.Cells["selectedNoticeColumn"].Value = true;
            }
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in noticeListDataGridView.Rows)
            {
                if ((bool)row.Cells["selectedNoticeColumn"].Value)
                    row.Cells["selectedNoticeColumn"].Value = false;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(rs.GetString("deleteNoticeYesNoMsg"), rs.GetString("deleteTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = 0;

                for (int i = noticeListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)noticeListDataGridView.Rows[i].Cells["selectedNoticeColumn"].Value;
                    if (delete == true)
                    {
                        nda.delete((int)noticeListDataGridView.Rows[i].Cells["noticeIdColumn"].Value, conn);
                        noticeListDataGridView.Rows.Remove(noticeListDataGridView.Rows[i]);
                        count++;
                    }
                }

                if (count == 0)
                    MessageBox.Show(rs.GetString("selectNoticeMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (noticeListDataGridView.Rows.Count > 0)
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

                    noticeListDataGridView.ClearSelection();

                    resetFormButton_Click(null, null);

                    MessageBox.Show(rs.GetString("deleteNoticeMsg"));
                }
            }
        }

        private void noticeListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Notice notice = nda.getOneNoticeByID(Language.getLanguageCode(), ((int)noticeListDataGridView.Rows[e.RowIndex].Cells["noticeIdColumn"].Value), conn);
                selectedNoticeId = notice.getNoticeID();
                engContentTextBox.Text = notice.getContentEnUs();
                tradChiContentTextBox.Text = notice.getContentZhHant();

                addButton.Enabled = false;
                updateButton.Enabled = true;
            }
        }
    }
}
