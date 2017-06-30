using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using MySql.Data.MySqlClient;
using MetroFramework.Controls;
using System.Resources;

namespace BackendForCompany.WebMasterForm
{
    public partial class RecycleBinUserCtrl : MetroUserControl
    {
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(RecycleBinUserCtrl).Assembly);

        private MySqlConnection conn = Database.getConnection();
        private string staffID = null;

        private EmployeeDA eda = new EmployeeDA();
        private SupplierDA sda = new SupplierDA();

        List<Employee> employeeList = null;
        List<Supplier> supplierList = null;

        public RecycleBinUserCtrl(string staffID)
        {
            InitializeComponent();

            this.staffID = staffID;

            employeeList = eda.getAllDeletedEmployees(conn);
            supplierList = sda.getAllDeletedSuppliers(conn);

            input_staffSearchChanged(null, null);
            input_supplierSearchChanged(null, null);
        }

        //============================================Staff=====================================================
        private void input_staffSearchChanged(object sender, EventArgs e)
        {
            staffListDataGridView.Rows.Clear();
            staffListDataGridView.Refresh();

            if (employeeList != null)
                foreach (Employee emp in employeeList)
                    if ((emp.getEmployeeID().ToUpper()).Contains(staffIdTextBox.Text.ToUpper()) &&
                            (emp.getEmployeeSurname().ToLower()).Contains(staffSurnameTextBox.Text.ToLower()) &&
                            (emp.getEmployeeGivenName()).Contains(staffGivenNameTextBox.Text.ToLower()) &&
                            (emp.getEmail().ToLower()).Contains(staffEmailTextBox.Text.ToLower())
                        )
                        staffListDataGridView.Rows.Add(
                            false,
                            emp.getEmployeeID(),
                            emp.getEmployeeSurname(),
                            emp.getEmployeeGivenName(),
                            ((emp.getPosition().Equals("Staff")) ? rs.GetString("staffText") : ((emp.getPosition().Equals("Manager")) ? rs.GetString("managerText") : rs.GetString("webMasterText"))),
                            emp.getEmail(),
                            emp.getDateDeleted().ToLongDateString());

            staffListDataGridView.ClearSelection();

            if (staffListDataGridView.Rows.Count > 0)
            {
                staffSelectAllButton.Enabled = true;
                staffDeselectAllButton.Enabled = true;
                staffRecoverButton.Enabled = true;
                staffPermanentlyDeleteButton.Enabled = true;
            }
            else
            {
                staffSelectAllButton.Enabled = false;
                staffDeselectAllButton.Enabled = false;
                staffRecoverButton.Enabled = false;
                staffPermanentlyDeleteButton.Enabled = false;
            }
        }

        private void staffResetButton_Click(object sender, EventArgs e)
        {
            staffIdTextBox.Clear();
            staffSurnameTextBox.Clear();
            staffGivenNameTextBox.Clear();
            staffEmailTextBox.Clear();
        }

        private void staffSelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in staffListDataGridView.Rows)
            {
                if (!(bool)row.Cells["SelectedStaffColumn"].Value)
                {
                    row.Cells["SelectedStaffColumn"].Value = true;
                }
            }
        }

        private void staffDeselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in staffListDataGridView.Rows)
            {
                if ((bool)row.Cells["SelectedStaffColumn"].Value)
                {
                    row.Cells["SelectedStaffColumn"].Value = false;
                }
            }
        }

        private void staffRecoverButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = staffListDataGridView.Rows.Count - 1; i >= 0; i--)
            {
                bool recover = (bool)staffListDataGridView.Rows[i].Cells["SelectedStaffColumn"].Value;
                if (recover == true)
                {
                    eda.undelete((string)staffListDataGridView.Rows[i].Cells["StaffIDColumn"].Value, conn);
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
                    staffSelectAllButton.Enabled = true;
                    staffDeselectAllButton.Enabled = true;
                    staffRecoverButton.Enabled = true;
                    staffPermanentlyDeleteButton.Enabled = true;
                }
                else
                {
                    staffSelectAllButton.Enabled = false;
                    staffDeselectAllButton.Enabled = false;
                    staffRecoverButton.Enabled = false;
                    staffPermanentlyDeleteButton.Enabled = false;
                }

                staffListDataGridView.ClearSelection();

                MessageBox.Show(rs.GetString("deletedAccountRecoverMsg"));
            }
        }

        private void staffPermanentlyDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(rs.GetString("deletePermanentlyAccountYesNoMsg"), rs.GetString("deleteTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = 0;

                for (int i = staffListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)staffListDataGridView.Rows[i].Cells["SelectedStaffColumn"].Value;
                    if (delete == true)
                    {
                        eda.permanentlyDelete((string)staffListDataGridView.Rows[i].Cells["StaffIDColumn"].Value, conn);
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
                        staffSelectAllButton.Enabled = true;
                        staffDeselectAllButton.Enabled = true;
                        staffRecoverButton.Enabled = true;
                        staffPermanentlyDeleteButton.Enabled = true;
                    }
                    else
                    {
                        staffSelectAllButton.Enabled = false;
                        staffDeselectAllButton.Enabled = false;
                        staffRecoverButton.Enabled = false;
                        staffPermanentlyDeleteButton.Enabled = false;
                    }

                    staffListDataGridView.ClearSelection();

                    MessageBox.Show(rs.GetString("deletePermanentlyAccountMsg"));
                }

            }
        }
        //======================================================================================================

        //=========================================Supplier=====================================================
        private void input_supplierSearchChanged(object sender, EventArgs e)
        {
            supplierListDataGridView.Rows.Clear();
            supplierListDataGridView.Refresh();

            if (supplierList != null)
                foreach (Supplier sup in supplierList)
                    if ((sup.getSupplierID().ToUpper()).Contains(supplierIDTextBox.Text.ToUpper()) &&
                            (sup.getSupplierName().ToLower()).Contains(supplierNameTextBox.Text.ToLower()) &&
                            (sup.getContectNo()).Contains(supplierContactNoTextBox.Text.ToLower()) &&
                            (sup.getEmail().ToLower()).Contains(supplierEmailTextBox.Text.ToLower())
                        )
                        supplierListDataGridView.Rows.Add(
                            false,
                            sup.getSupplierID(),
                            sup.getSupplierName(),
                            (sup.getProductCategory().Equals("Perfume")) ? rs.GetString("perfumeText") : ((sup.getProductCategory().Equals("Package")) ? rs.GetString("packageText") : rs.GetString("bottleText")),
                            sup.getContectNo(),
                            sup.getEmail(),
                            sup.getAddress(),
                            sup.getDateDeleted().ToLongDateString());

            supplierListDataGridView.ClearSelection();

            if (supplierListDataGridView.Rows.Count > 0)
            {
                supplierSelectAllButton.Enabled = true;
                supplierDeselectAllButton.Enabled = true;
                supplierRecoverButton.Enabled = true;
                supplierPermanentlyDeleteButton.Enabled = true;
            }
            else
            {
                supplierSelectAllButton.Enabled = false;
                supplierDeselectAllButton.Enabled = false;
                supplierRecoverButton.Enabled = false;
                supplierPermanentlyDeleteButton.Enabled = false;
            }
        }

        private void supplierResetButton_Click(object sender, EventArgs e)
        {
            supplierIDTextBox.Clear();
            supplierNameTextBox.Clear();
            supplierContactNoTextBox.Clear();
            supplierEmailTextBox.Clear();
        }

        private void supplierSelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in supplierListDataGridView.Rows)
            {
                if (!(bool)row.Cells["SelectedSupplierColumn"].Value)
                {
                    row.Cells["SelectedSupplierColumn"].Value = true;
                }
            }
        }

        private void supplierDeselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in supplierListDataGridView.Rows)
            {
                if ((bool)row.Cells["SelectedSupplierColumn"].Value)
                {
                    row.Cells["SelectedSupplierColumn"].Value = false;
                }
            }
        }

        private void supplierRecoverButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = supplierListDataGridView.Rows.Count - 1; i >= 0; i--)
            {
                bool recover = (bool)supplierListDataGridView.Rows[i].Cells["SelectedSupplierColumn"].Value;
                if (recover == true)
                {
                    sda.undelete((string)supplierListDataGridView.Rows[i].Cells["SupplierIDColumn"].Value, conn);
                    supplierListDataGridView.Rows.Remove(supplierListDataGridView.Rows[i]);
                    count++;
                }
            }


            if (count == 0)
                MessageBox.Show(rs.GetString("selectAccountMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (supplierListDataGridView.Rows.Count > 0)
                {
                    supplierSelectAllButton.Enabled = true;
                    supplierDeselectAllButton.Enabled = true;
                    supplierRecoverButton.Enabled = true;
                    supplierPermanentlyDeleteButton.Enabled = true;
                }
                else
                {
                    supplierSelectAllButton.Enabled = false;
                    supplierDeselectAllButton.Enabled = false;
                    supplierRecoverButton.Enabled = false;
                    supplierPermanentlyDeleteButton.Enabled = false;
                }

                supplierListDataGridView.ClearSelection();

                MessageBox.Show(rs.GetString("deletedAccountRecoverMsg"));
            }
        }

        private void supplierPermanentlyDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(rs.GetString("deletePermanentlyAccountYesNoMsg"), rs.GetString("deleteTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = 0;

                for (int i = supplierListDataGridView.Rows.Count - 1; i >= 0; i--)
                {
                    bool delete = (bool)supplierListDataGridView.Rows[i].Cells["SelectedSupplierColumn"].Value;
                    if (delete == true)
                    {
                        sda.permanentlyDelete((string)supplierListDataGridView.Rows[i].Cells["SupplierIDColumn"].Value, conn);
                        supplierListDataGridView.Rows.Remove(supplierListDataGridView.Rows[i]);
                        count++;
                    }
                }

                if (count == 0)
                    MessageBox.Show(rs.GetString("selectAccountMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (supplierListDataGridView.Rows.Count > 0)
                    {
                        supplierSelectAllButton.Enabled = true;
                        supplierDeselectAllButton.Enabled = true;
                        supplierRecoverButton.Enabled = true;
                        supplierPermanentlyDeleteButton.Enabled = true;
                    }
                    else
                    {
                        supplierSelectAllButton.Enabled = false;
                        supplierDeselectAllButton.Enabled = false;
                        supplierRecoverButton.Enabled = false;
                        supplierPermanentlyDeleteButton.Enabled = false;
                    }

                    supplierListDataGridView.ClearSelection();

                    MessageBox.Show(rs.GetString("deletePermanentlyAccountMsg"));
                }

            }
        }


        //======================================================================================================
    }
}
