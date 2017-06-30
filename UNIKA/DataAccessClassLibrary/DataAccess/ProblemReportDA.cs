using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class ProblemReportDA
    {
        public List<ProblemReport> getAllReports(MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `problem_report`.`Problem_ID`, `problem_report`.`Reason`, `problem_report`.`Order_ID`, `customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, `customer`.`Regeion_Code`, `customer`.`Mobile_Phone_No`, "+
                "`problem_report`.`Report_date`, `problem_report`.`Return_date` FROM `problem_report`, `customer`, `order` "+
                "WHERE  `problem_report`.`Order_ID`=`order`.`Order_ID` AND `order`.`Customer_ID`=`customer`.`Customer_ID` AND `problem_report`.`Date_Deleted` IS NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<ProblemReport> list = new List<ProblemReport>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new ProblemReport());
                list.Last().setProblemID(int.Parse(item["Problem_ID"].ToString()));
                list.Last().setReason(item["Reason"].ToString());
                list.Last().setOrderID(((uint)item["Order_ID"]).ToString("0000000000"));
                list.Last().setCustSurname(item["Customer_Surname"].ToString());
                list.Last().setCustGivenName(item["Customer_GivenName"].ToString());
                list.Last().setCustRegeionCode((int)item["Regeion_Code"]);
                list.Last().setCustMobilePhoneNo((int)item["Mobile_Phone_No"]);
                list.Last().setReportDate(Convert.ToDateTime(item["Report_date"]));
                if (!Convert.IsDBNull(item["Return_date"])) list.Last().setReturnDate(Convert.ToDateTime(item["Return_date"]));
            }
            conn.Close();
            return list;
        }

        public List<ProblemReport> getReportsByOrderID(ulong orderID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `problem_report`.`Problem_ID`, `problem_report`.`Reason`, `problem_report`.`Order_ID`, `customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, `customer`.`Regeion_Code`, `customer`.`Mobile_Phone_No`, " +
                "`problem_report`.`Report_date`, `problem_report`.`Return_date` FROM `problem_report`, `customer`, `order` " +
                "WHERE `problem_report`.`Order_ID`= @orderID AND `problem_report`.`Order_ID`=`order`.`Order_ID` AND `order`.`Customer_ID`=`customer`.`Customer_ID` AND `problem_report`.`Date_Deleted` IS NULL", conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<ProblemReport> list = new List<ProblemReport>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new ProblemReport());
                list.Last().setProblemID(int.Parse(item["Problem_ID"].ToString()));
                list.Last().setReason(item["Reason"].ToString());
                list.Last().setOrderID(((uint)item["Order_ID"]).ToString("0000000000"));
                list.Last().setCustSurname(item["Customer_Surname"].ToString());
                list.Last().setCustGivenName(item["Customer_GivenName"].ToString());
                list.Last().setCustRegeionCode((int)item["Regeion_Code"]);
                list.Last().setCustMobilePhoneNo((int)item["Mobile_Phone_No"]);
                list.Last().setReportDate(Convert.ToDateTime(item["Report_date"]));
                if(!Convert.IsDBNull(item["Return_date"]))list.Last().setReturnDate(Convert.ToDateTime(item["Return_date"]));
            }
            conn.Close();
            return list;
        }

        public List<ProblemReport> getAllDeletedReports(MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `problem_report`.`Problem_ID`, `problem_report`.`Reason`, `problem_report`.`Order_ID`, `problem_report`.`Date_Deleted`, `customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, `customer`.`Regeion_Code`, `customer`.`Mobile_Phone_No`, " +
                "`problem_report`.`Report_date`, `problem_report`.`Return_date` FROM `problem_report`, `customer`, `order` " +
                "WHERE  `problem_report`.`Order_ID`=`order`.`Order_ID` AND `order`.`Customer_ID`=`customer`.`Customer_ID` AND `problem_report`.`Date_Deleted` IS NOT NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<ProblemReport> list = new List<ProblemReport>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new ProblemReport());
                list.Last().setProblemID(int.Parse(item["Problem_ID"].ToString()));
                list.Last().setReason(item["Reason"].ToString());
                list.Last().setOrderID(((uint)item["Order_ID"]).ToString("0000000000"));
                list.Last().setCustSurname(item["Customer_Surname"].ToString());
                list.Last().setCustGivenName(item["Customer_GivenName"].ToString());
                list.Last().setCustRegeionCode((int)item["Regeion_Code"]);
                list.Last().setCustMobilePhoneNo((int)item["Mobile_Phone_No"]);
                list.Last().setReportDate(Convert.ToDateTime(item["Report_date"]));
                if (!Convert.IsDBNull(item["Return_date"])) list.Last().setReturnDate(Convert.ToDateTime(item["Return_date"]));
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public ProblemReport getOneReportByID(int problemID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `problem_report`.`Problem_ID`, `problem_report`.`Photo`, `problem_report`.`Reason`, `problem_report`.`Order_ID`, `customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, `customer`.`Regeion_Code`, `customer`.`Mobile_Phone_No`, " +
                "`problem_report`.`Report_date`, `problem_report`.`Return_date` FROM `problem_report`, `customer`, `order` " +
                "WHERE  `problem_report`.`Order_ID`=`order`.`Order_ID` AND `order`.`Customer_ID`=`customer`.`Customer_ID` AND `problem_report`.`Date_Deleted` IS NULL AND `problem_report`.`Problem_ID`=@problemID", conn);
            cmd.Parameters.AddWithValue("@problemID", problemID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            ProblemReport problemReport = new ProblemReport();
            foreach (DataRow item in dt.Rows)
            {
                problemReport.setProblemID(int.Parse(item["Problem_ID"].ToString()));
                problemReport.setPhoto(ImageConverter.byteArrayToImage((byte[])item["Photo"]));
                problemReport.setReason(item["Reason"].ToString());
                problemReport.setOrderID(((uint)item["Order_ID"]).ToString("0000000000"));
                problemReport.setCustSurname(item["Customer_Surname"].ToString());
                problemReport.setCustGivenName(item["Customer_GivenName"].ToString());
                problemReport.setCustRegeionCode((int)item["Regeion_Code"]);
                problemReport.setCustMobilePhoneNo((int)item["Mobile_Phone_No"]);
                problemReport.setReportDate(Convert.ToDateTime(item["Report_date"]));
                if (!Convert.IsDBNull(item["Return_date"])) problemReport.setReturnDate(Convert.ToDateTime(item["Return_date"]));
            }
            conn.Close();
            return problemReport;
        }

        public ProblemReport getOneDeletedReportByID(int problemID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `problem_report`.`Problem_ID`, `problem_report`.`Photo`, `problem_report`.`Reason`, `problem_report`.`Order_ID`, `problem_report`.`Date_Deleted`, `customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, `customer`.`Regeion_Code`, `customer`.`Mobile_Phone_No`, " +
                "`problem_report`.`Report_date`, `problem_report`.`Return_date` FROM `problem_report`, `customer`, `order` " +
                "WHERE  `problem_report`.`Order_ID`=`order`.`Order_ID` AND `order`.`Customer_ID`=`customer`.`Customer_ID` AND `problem_report`.`Date_Deleted` IS NOT NULL AND `problem_report`.`Problem_ID`=@problemID", conn);
            cmd.Parameters.AddWithValue("@problemID", problemID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            ProblemReport problemReport = new ProblemReport();
            foreach (DataRow item in dt.Rows)
            {
                problemReport.setProblemID(int.Parse(item["Problem_ID"].ToString()));
                problemReport.setPhoto(ImageConverter.byteArrayToImage((byte[])item["Photo"]));
                problemReport.setReason(item["Reason"].ToString());
                problemReport.setOrderID(((uint)item["Order_ID"]).ToString("0000000000"));
                problemReport.setCustSurname(item["Customer_Surname"].ToString());
                problemReport.setCustGivenName(item["Customer_GivenName"].ToString());
                problemReport.setCustRegeionCode((int)item["Regeion_Code"]);
                problemReport.setCustMobilePhoneNo((int)item["Mobile_Phone_No"]);
                problemReport.setReportDate(Convert.ToDateTime(item["Report_date"]));
                if (!Convert.IsDBNull(item["Return_date"])) problemReport.setReturnDate(Convert.ToDateTime(item["Return_date"]));
                problemReport.setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return problemReport;
        }

        public int insert(ProblemReport problemReport, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `problem_report`(`Photo`, `Reason`, `Order_ID`, `Report_date`, `Return_date`) "+
                "VALUES(@photo, @reason, @orderID, @reportDate, @returnDate)", conn);
            cmd.Parameters.AddWithValue("@photo", ImageConverter.imageToByteArray(problemReport.getPhoto()));
            cmd.Parameters.AddWithValue("@reason", problemReport.getReason());
            cmd.Parameters.AddWithValue("@orderID", problemReport.getOrderID());
            cmd.Parameters.AddWithValue("@reportDate", problemReport.getReportDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@returnDate", (problemReport.getReturnDate() != null) ? problemReport.getReturnDate().Value.ToString("yyyy-MM-dd HH:mm:ss") : null);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            problemReport.setProblemID((int.Parse(cmd.LastInsertedId.ToString())));
            conn.Close();
            return i;
        }

        public int update(ProblemReport problemReport, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `problem_report` SET `Photo`=@photo,`Reason`=@reason,`Order_ID`=@orderID,`Report_date`=@reportDate,`Return_date`=@returnDate WHERE `Problem_ID`=@problemID", conn);
            cmd.Parameters.AddWithValue("@problemID", problemReport.getProblemID());
            cmd.Parameters.AddWithValue("@photo", ImageConverter.imageToByteArray(problemReport.getPhoto()));
            cmd.Parameters.AddWithValue("@reason", problemReport.getReason());
            cmd.Parameters.AddWithValue("@orderID", problemReport.getOrderID());
            cmd.Parameters.AddWithValue("@reportDate", problemReport.getReportDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@returnDate", (problemReport.getReturnDate() != null) ? problemReport.getReturnDate().Value.ToString("yyyy-MM-dd HH:mm:ss") : null);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int delete(string problemID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `problem_report` SET `Date_Deleted` = NOW() WHERE `Problem_ID`=@problemID", conn);
            cmd.Parameters.AddWithValue("@problemID", problemID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int undelete(string problemID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `problem_report` SET `Date_Deleted` = NULL WHERE `Problem_ID`=@problemID", conn);
            cmd.Parameters.AddWithValue("@problemID", problemID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int permanentlyDelete(string problemID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `problem_report` WHERE `Problem_ID`=@problemID", conn);
            cmd.Parameters.AddWithValue("@problemID", problemID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
