using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccessClassLibrary.Properties;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class EmployeeLoginLogDA
    {

        public List<LoginLog> getAllLogs(MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `employee_login_log`.`Employee_ID`, " +
                    "CONCAT(UPPER(`login_employee`.`Employee_Surname`),' ',`login_employee`.`Employee_GivenName`) AS `Logger_Name`, " +
                    "`employee_login_log`.`Success`, `employee_login_log`.`Password_Incorrect`, `employee_login_log`.`Locked`, `employee_login_log`.`Unlocked_By`, " +
                    "CONCAT(UPPER(`unlocked_by_employee`.`Employee_Surname`),' ',`unlocked_by_employee`.`Employee_GivenName`) AS `Unclocker_Name`, " +
                    "`employee_login_log`.`Ac_Status_Temp_Lock`, `employee_login_log`.`Time` " +
                    "FROM `employee_login_log` " +
                    "JOIN `employee` AS `login_employee` ON `employee_login_log`.`Employee_ID` = `login_employee`.`Employee_ID` " +
                    "LEFT JOIN `employee` AS `unlocked_by_employee` ON `employee_login_log`.`Unlocked_By` = `unlocked_by_employee`.`Employee_ID` ORDER BY `employee_login_log`.`Time` ASC", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<LoginLog> list = new List<LoginLog>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new LoginLog());
                list.Last().setAccountID(item["Employee_ID"].ToString());
                list.Last().setAccountName(item["Logger_Name"].ToString());
                list.Last().setSuccess(Convert.ToBoolean(item["Success"]));
                list.Last().setPasswordIncorrect(Convert.ToBoolean(item["Password_Incorrect"]));
                list.Last().setLocked(Convert.ToBoolean(item["Locked"]));
                list.Last().setUnlockedByEmpID(item["Unlocked_By"].ToString());
                list.Last().setUnlockedBy(item["Unclocker_Name"].ToString());
                list.Last().setAcStatusTempLock(Convert.ToBoolean(item["Ac_Status_Temp_Lock"]));

                if (list.Last().getSuccess())
                {
                    list.Last().setStatus(Resources.loginSuccessLog);
                }
                else if (list.Last().getPasswordIncorrect())
                {
                    list.Last().setStatus(Resources.inputIncorrectPasswdLog);
                }
                else if (list.Last().getLocked())
                {
                    list.Last().setStatus(Resources.inputIncorrectPasswd5TimesLog);
                }
                else if (list.Last().getAcStatusTempLock())
                {
                    list.Last().setStatus(Resources.loginAccountWhileLockedLog);
                }
                else if (list.Last().getUnlockedByEmpID() != null)
                {
                    list.Last().setStatus(Resources.accountUnlockLog1 + list.Last().getUnlockedBy() + Resources.accountUnlockLog2);
                }

                list.Last().setTime(Convert.ToDateTime(item["Time"]));
            }
            conn.Close();
            return list;
        }

        public List<LoginLog> searchLogs(DateTime? form, DateTime? to, string employeeID, string surname, string givenName, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `employee_login_log`.`Employee_ID`, " +
                "CONCAT(UPPER(`login_employee`.`Employee_Surname`),' ',`login_employee`.`Employee_GivenName`) AS `Logger_Name`, " +
                "`employee_login_log`.`Success`, `employee_login_log`.`Password_Incorrect`, `employee_login_log`.`Locked`, `employee_login_log`.`Unlocked_By`, " +
                "CONCAT(UPPER(`unlocked_by_employee`.`Employee_Surname`),' ',`unlocked_by_employee`.`Employee_GivenName`) AS `Unclocker_Name`, " +
                "`employee_login_log`.`Ac_Status_Temp_Lock`, `employee_login_log`.`Time` " +
                "FROM `employee_login_log` " +
                "JOIN `employee` AS `login_employee` ON `employee_login_log`.`Employee_ID` = `login_employee`.`Employee_ID` " +
                "LEFT JOIN `employee` AS `unlocked_by_employee` ON `employee_login_log`.`Unlocked_By` = `unlocked_by_employee`.`Employee_ID` WHERE " +
                ((form != null) ? "`employee_login_log`.`Time`>=@form AND " : "") +
                ((to != null) ? "`employee_login_log`.`Time`<=@to AND " : "") +
                ((!string.IsNullOrWhiteSpace(employeeID)) ? "`employee_login_log`.`Employee_ID`=@employeeID AND " : "") +
                "LOWER(`login_employee`.`Employee_Surname`) LIKE @surname AND " +
                "LOWER(`login_employee`.`Employee_GivenName`) LIKE @givenName ORDER BY `employee_login_log`.`Time` ASC", conn);
            if (form != null)
                cmd.Parameters.AddWithValue("@form", form.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            if (to != null)
                cmd.Parameters.AddWithValue("@to", to.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            if (!string.IsNullOrWhiteSpace(employeeID))
                cmd.Parameters.AddWithValue("@employeeID", employeeID);
            cmd.Parameters.AddWithValue("@surname", "%" + ((string.IsNullOrWhiteSpace(surname)) ? "" : "LOWER("+surname+")") + "%");
            cmd.Parameters.AddWithValue("@givenName", "%" + ((string.IsNullOrWhiteSpace(givenName)) ? "" : "LOWER("+givenName+")") + "%");
            cmd.Prepare();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<LoginLog> list = new List<LoginLog>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new LoginLog());
                list.Last().setAccountID(item["Employee_ID"].ToString());
                list.Last().setAccountName(item["Logger_Name"].ToString());
                list.Last().setSuccess(Convert.ToBoolean(item["Success"]));
                list.Last().setPasswordIncorrect(Convert.ToBoolean(item["Password_Incorrect"]));
                list.Last().setLocked(Convert.ToBoolean(item["Locked"]));
                list.Last().setUnlockedByEmpID(item["Unlocked_By"].ToString());
                list.Last().setUnlockedBy(item["Unclocker_Name"].ToString());
                list.Last().setAcStatusTempLock(Convert.ToBoolean(item["Ac_Status_Temp_Lock"]));

                if (list.Last().getSuccess())
                {
                    list.Last().setStatus(Resources.loginSuccessLog);
                }
                else if (list.Last().getPasswordIncorrect())
                {
                    list.Last().setStatus(Resources.inputIncorrectPasswdLog);
                }
                else if (list.Last().getLocked())
                {
                    list.Last().setStatus(Resources.inputIncorrectPasswd5TimesLog);
                }
                else if (list.Last().getAcStatusTempLock())
                {
                    list.Last().setStatus(Resources.loginAccountWhileLockedLog);
                }
                else if (list.Last().getUnlockedByEmpID() != null)
                {
                    list.Last().setStatus(Resources.accountUnlockLog1 + list.Last().getUnlockedBy() + Resources.accountUnlockLog2);
                }
                list.Last().setTime(Convert.ToDateTime(item["Time"]));
            }
            Console.WriteLine(list == null);
            conn.Close();
            return list;
        }

        public int insert(LoginLog loginLog, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `employee_login_log`(`Employee_ID`, `Success`, `Password_Incorrect`, `Locked`, `Unlocked_By`, `Ac_Status_Temp_Lock`, `Time`) VALUES (@accountID,@success,@passwordIncorrect,@locked,@unlockedBy,@acStatusTempLock,@time)", conn);
            cmd.Parameters.AddWithValue("@accountID", loginLog.getAccountID());
            cmd.Parameters.AddWithValue("@success", loginLog.getSuccess());
            cmd.Parameters.AddWithValue("@passwordIncorrect", loginLog.getPasswordIncorrect());
            cmd.Parameters.AddWithValue("@locked", loginLog.getLocked());
            cmd.Parameters.AddWithValue("@unlockedBy", loginLog.getUnlockedByEmpID());
            cmd.Parameters.AddWithValue("@acStatusTempLock", loginLog.getAcStatusTempLock());
            cmd.Parameters.AddWithValue("@time", loginLog.getTime().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

    }
}
