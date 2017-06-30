using System.Collections.Generic;
using System.Linq;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System.Resources;

namespace BackendForCompany.ManagerForm
{
    public partial class HomeUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(HomeUserCtrl).Assembly);

        private string staffID = null;

        public HomeUserCtrl(string staffID)
        {
            this.staffID = staffID;

            InitializeComponent();

            showLoginLog();
            showProfile();
        }

        private void showLoginLog()
        {
            EmployeeLoginLogDA elda = new EmployeeLoginLogDA();
            List<LoginLog> list = elda.searchLogs(null, null, staffID, null, null, conn);
            for (int i = list.Count - 1; i >= 0; i--)
            {
                loginLogDataGridView.Rows.Add(
                    list.ElementAt(i).getTime(),
                    list.ElementAt(i).getStatus());
            }
        }

        private void showProfile()
        {
            EmployeeDA eda = new EmployeeDA();
            Employee e = eda.getOneEmployeeByID(staffID, conn);
            showStaffIdLabel.Text = e.getEmployeeID();
            showNameLabel.Text = e.getEmployeeSurname()+", "+e.getEmployeeGivenName();
            showEmailLabel.Text = e.getEmail();
            if (e.getPosition().Equals("Manager"))
                showPositionLabel.Text = rs.GetString("managerText");
            else if (e.getPosition().Equals("Staff"))
                showPositionLabel.Text = rs.GetString("staffText");
            else if (e.getPosition().Equals("Web Master"))
                showPositionLabel.Text = rs.GetString("webMasterText");
        }

        private void loginLogGroupBox_Enter(object sender, System.EventArgs e)
        {

        }
    }
}
