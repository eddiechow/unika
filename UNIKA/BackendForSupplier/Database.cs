using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BackendForSupplier
{
    class Database
    {
        public static MySqlConnection getConnection()
        {
            return new MySqlConnection("server=unika.project.hostvps.com.hk;userid=unika_db;password=4jCu3ysN;database=unika_db;CharSet=utf8;");
        }

        public static void showErrorMessage(int number)
        {
            if (number== 1042)
            {
                MessageBox.Show("Failed to connect to server.\nPlease contact administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Database error.\nPlease contact administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.ExitThread();
        }

    }
}
