using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccessClassLibrary.Properties;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class CustomerLoginLogDA
    {

        public List<LoginLog> getAllLogs(MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `customer_login_log`.`Customer_ID`, " +
                "CONCAT(UPPER(`customer`.`Customer_Surname`),' ',`customer`.`Customer_GivenName`) AS `Logger_Name`, " +
                "`customer_login_log`.`Success`, `customer_login_log`.`Password_Incorrect`, `customer_login_log`.`Locked`, " +
                "`customer_login_log`.`Unlocked_By`, " +
                "CONCAT(UPPER(`employee`.`Employee_Surname`),' ',`employee`.`Employee_GivenName`) AS `Unclocker_Name`, " +
                "`customer_login_log`.`Ac_Status_Temp_Lock`, `customer_login_log`.`Ac_Status_Non_Active`, " +
                "`customer_login_log`.`Time`, `customer_login_log`.`OS`, `customer_login_log`.`Browser`, " +
                "`customer_login_log`.`IP` FROM `customer_login_log` " +
                "JOIN `customer` ON `customer_login_log`.`Customer_ID` = `customer`.`Customer_ID` " +
                "LEFT JOIN `employee` ON `customer_login_log`.`Unlocked_By` = `employee`.`Employee_ID` ORDER BY `customer_login_log`.`Time` ASC", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<LoginLog> list = new List<LoginLog>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new LoginLog());
                list.Last().setAccountID(item["Customer_ID"].ToString());
                list.Last().setAccountName(item["Logger_Name"].ToString());
                list.Last().setSuccess(Convert.ToBoolean(item["Success"]));
                list.Last().setPasswordIncorrect(Convert.ToBoolean(item["Password_Incorrect"]));
                list.Last().setLocked(Convert.ToBoolean(item["Locked"]));
                list.Last().setUnlockedByEmpID(item["Unlocked_By"].ToString());
                list.Last().setUnlockedBy(item["Unclocker_Name"].ToString());
                list.Last().setAcStatusTempLock(Convert.ToBoolean(item["Ac_Status_Temp_Lock"]));
                list.Last().setAcStatusNonActive(Convert.ToBoolean(item["Ac_Status_Non_Active"]));

                if (list.Last().getSuccess() && !list.Last().getAcStatusNonActive())
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
                else if (list.Last().getSuccess() && list.Last().getAcStatusNonActive())
                {
                    list.Last().setStatus(Resources.loginSuccessWithoutVerifiedEmailLog);
                }
                else if (list.Last().getUnlockedByEmpID() != null)
                {
                    list.Last().setStatus(Resources.accountUnlockLog1 + list.Last().getUnlockedBy() + Resources.accountUnlockLog2);
                }

                list.Last().setTime(Convert.ToDateTime(item["Time"]));
                list.Last().setOs(item["OS"].ToString());
                list.Last().setBrowser(item["Browser"].ToString());
                list.Last().setIp(item["IP"].ToString());
            }
            conn.Close();
            return list;
        }

        public List<LoginLog> searchLogs(DateTime? form, DateTime? to, string customerID, string surname, string givenName, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `customer_login_log`.`Customer_ID`, " +
                "CONCAT(UPPER(`customer`.`Customer_Surname`),' ',`customer`.`Customer_GivenName`) AS `Logger_Name`, " +
                "`customer_login_log`.`Success`, `customer_login_log`.`Password_Incorrect`, `customer_login_log`.`Locked`, " +
                "`customer_login_log`.`Unlocked_By`, " +
                "CONCAT(UPPER(`employee`.`Employee_Surname`),' ',`employee`.`Employee_GivenName`) AS `Unclocker_Name`, " +
                "`customer_login_log`.`Ac_Status_Temp_Lock`, `customer_login_log`.`Ac_Status_Non_Active`, " +
                "`customer_login_log`.`Time`, `customer_login_log`.`OS`, `customer_login_log`.`Browser`, " +
                "`customer_login_log`.`IP` FROM `customer_login_log` " +
                "JOIN `customer` ON `customer_login_log`.`Customer_ID` = `customer`.`Customer_ID` " +
                "LEFT JOIN `employee` ON `customer_login_log`.`Unlocked_By` = `employee`.`Employee_ID` WHERE " +
                ((form != null) ? "`customer_login_log`.`Time`>=@form AND " : "") +
                ((to != null) ? "`customer_login_log`.`Time`<=@to AND " : "") +
                ((!string.IsNullOrWhiteSpace(customerID)) ? "`customer_login_log`.`Customer_ID`=@customerID AND " : "") +
                "LOWER(`customer`.`Customer_Surname`) LIKE @surname AND " +
                "LOWER(`customer`.`Customer_GivenName`) LIKE @givenName ORDER BY `customer_login_log`.`Time` ASC", conn);
            if (form != null)
                cmd.Parameters.AddWithValue("@form", form.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            if (to != null)
                cmd.Parameters.AddWithValue("@to", to.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            if (!string.IsNullOrWhiteSpace(customerID))
                cmd.Parameters.AddWithValue("@customerID", customerID);
            cmd.Parameters.AddWithValue("@surname", "%" + ((surname == null) ? "" : "LOWER(" + surname + ")") + "%");
            cmd.Parameters.AddWithValue("@givenName", "%" + ((givenName == null) ? "" : "LOWER(" + givenName + ")") + "%");
            cmd.Prepare();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<LoginLog> list = new List<LoginLog>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new LoginLog());
                list.Last().setAccountID(item["Customer_ID"].ToString());
                list.Last().setAccountName(item["Logger_Name"].ToString());
                list.Last().setSuccess(Convert.ToBoolean(item["Success"]));
                list.Last().setPasswordIncorrect(Convert.ToBoolean(item["Password_Incorrect"]));
                list.Last().setLocked(Convert.ToBoolean(item["Locked"]));
                list.Last().setUnlockedByEmpID(item["Unlocked_By"].ToString());
                list.Last().setUnlockedBy(item["Unclocker_Name"].ToString());
                list.Last().setAcStatusTempLock(Convert.ToBoolean(item["Ac_Status_Temp_Lock"]));
                list.Last().setAcStatusNonActive(Convert.ToBoolean(item["Ac_Status_Non_Active"]));

                if (list.Last().getSuccess() && !list.Last().getAcStatusNonActive())
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
                else if (list.Last().getSuccess() && list.Last().getAcStatusNonActive())
                {
                    list.Last().setStatus(Resources.loginSuccessWithoutVerifiedEmailLog);
                }
                else if (list.Last().getUnlockedByEmpID() != null)
                {
                    list.Last().setStatus(Resources.accountUnlockLog1 + list.Last().getUnlockedBy() + Resources.accountUnlockLog2);
                }

                list.Last().setTime(Convert.ToDateTime(item["Time"]));
                list.Last().setOs(item["OS"].ToString());
                list.Last().setBrowser(item["Browser"].ToString());
                list.Last().setIp(item["IP"].ToString());
            }
            conn.Close();
            return list;
        }

        public int insert(LoginLog loginLog, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `customer_login_log`(`Customer_ID`, `Success`, `Password_Incorrect`, `Locked`, `Ac_Status_Temp_Lock`, `Ac_Status_Non_Active`, `Time`, `Unlocked_By`, `OS`, `Browser`, `IP`) VALUES (@accountID,@success,@passwordIncorrect,@locked,@acStatusTempLock,@acStatusTempNonActive,@time,@unlockedBy,@os,@browser,@ip)", conn);
            cmd.Parameters.AddWithValue("@accountID", loginLog.getAccountID());
            cmd.Parameters.AddWithValue("@success", loginLog.getSuccess());
            cmd.Parameters.AddWithValue("@passwordIncorrect", loginLog.getPasswordIncorrect());
            cmd.Parameters.AddWithValue("@locked", loginLog.getLocked());
            cmd.Parameters.AddWithValue("@acStatusTempLock", loginLog.getAcStatusTempLock());
            cmd.Parameters.AddWithValue("@acStatusTempNonActive", loginLog.getAcStatusNonActive());
            cmd.Parameters.AddWithValue("@time", loginLog.getTime());
            cmd.Parameters.AddWithValue("@unlockedBy", loginLog.getUnlockedByEmpID());
            cmd.Parameters.AddWithValue("@os", loginLog.getOs());
            cmd.Parameters.AddWithValue("@browser", loginLog.getBrowser());
            cmd.Parameters.AddWithValue("@ip", loginLog.getIp());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

    }
}
