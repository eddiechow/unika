using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAccessClassLibrary.Properties;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class SupplierLoginLogDA
    {

        public List<LoginLog> getAllLogs(MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `supplier_login_log`.`Supplier_ID`, `supplier`.`Supplier_Name`, " +
                "`supplier_login_log`.`Success`, `supplier_login_log`.`Password_Incorrect`, " +
                "`supplier_login_log`.`Locked`, `supplier_login_log`.`Unlocked_By`, " +
                "CONCAT(UPPER(`employee`.`Employee_Surname`),' ',`employee`.`Employee_GivenName`) AS `Unclocker_Name`, " +
                "`supplier_login_log`.`Ac_Status_Temp_Lock`, " +
                "`supplier_login_log`.`Time` FROM `supplier_login_log` " +
                "JOIN `supplier` ON `supplier_login_log`.`Supplier_ID` = `supplier`.`Supplier_ID` " +
                "LEFT JOIN `employee` ON `supplier_login_log`.`Unlocked_By` = `employee`.`Employee_ID` ORDER BY `supplier_login_log`.`Time` ASC", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<LoginLog> list = new List<LoginLog>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new LoginLog());
                list.Last().setAccountID(item["Supplier_ID"].ToString());
                list.Last().setAccountName(item["Supplier_Name"].ToString());
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

        public List<LoginLog> searchLogs(DateTime? form, DateTime? to, string supplierID, string name, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `supplier_login_log`.`Supplier_ID`, `supplier`.`Supplier_Name`, " +
                "`supplier_login_log`.`Success`, `supplier_login_log`.`Password_Incorrect`, " +
                "`supplier_login_log`.`Locked`, `supplier_login_log`.`Unlocked_By`, " +
                "CONCAT(UPPER(`employee`.`Employee_Surname`),' ',`employee`.`Employee_GivenName`) AS `Unclocker_Name`, " +
                "`supplier_login_log`.`Ac_Status_Temp_Lock`, " +
                "`supplier_login_log`.`Time` FROM `supplier_login_log` " +
                "JOIN `supplier` ON `supplier_login_log`.`Supplier_ID` = `supplier`.`Supplier_ID` " +
                "LEFT JOIN `employee` ON `supplier_login_log`.`Unlocked_By` = `employee`.`Employee_ID` " +
                "WHERE " +
                ((form != null) ? "`supplier_login_log`.`Time`>=@form AND " : "") +
                ((to != null) ? "`supplier_login_log`.`Time`<=@to AND " : "") +
                ((!string.IsNullOrWhiteSpace(supplierID)) ? "`supplier_login_log`.`Supplier_ID`=@supplierID" : "`supplier_login_log`.`Supplier_ID` LIKE '%%'") + " AND " +
                "LOWER(`supplier`.`Supplier_Name`) LIKE @name ORDER BY `supplier_login_log`.`Time` ASC", conn);
            if (form != null)
                cmd.Parameters.AddWithValue("@form", form.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            if (to != null)
                cmd.Parameters.AddWithValue("@to", to.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            if (!string.IsNullOrWhiteSpace(supplierID))
                cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Parameters.AddWithValue("@name", "%" + ((name == null) ? "" : "LOWER("+name+ ")") + "%");
            cmd.Prepare();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<LoginLog> list = new List<LoginLog>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new LoginLog());
                list.Last().setAccountID(item["Supplier_ID"].ToString());
                list.Last().setAccountName(item["Supplier_Name"].ToString());
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

        public int insert(LoginLog loginLog, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `supplier_login_log`(`Supplier_ID`, `Success`, `Password_Incorrect`, `Locked`, `Unlocked_By`, `Ac_Status_Temp_Lock`, `Time`) VALUES (@accountID,@success,@passwordIncorrect,@locked,@unlockedBy,@acStatusTempLock,@time)", conn);
            cmd.Parameters.AddWithValue("@accountID", loginLog.getAccountID());
            cmd.Parameters.AddWithValue("@success", loginLog.getSuccess());
            cmd.Parameters.AddWithValue("@passwordIncorrect", loginLog.getPasswordIncorrect());
            cmd.Parameters.AddWithValue("@locked", loginLog.getLocked());
            cmd.Parameters.AddWithValue("@unlockedBy", loginLog.getUnlockedByEmpID());
            cmd.Parameters.AddWithValue("@acStatusTempLock", loginLog.getAcStatusTempLock());
            cmd.Parameters.AddWithValue("@time", loginLog.getTime());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

    }
}
