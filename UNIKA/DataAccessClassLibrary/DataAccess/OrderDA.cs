using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class OrderDA
    {
        public List<Order> getAllOrders(MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `order`.`Order_ID`, `order`.`Customer_ID`,  `customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, `order`.`Order_date`, `order`.`Rejected`, `order`.`Bar_Code`, `order`.`Approved_By`, `employee`.`Employee_Surname`, `employee`.`Employee_GivenName`, `order`.`Approve_Date`, `order`.`PayPal_Payment_ID`, `order`.`PayPal_Transaction_ID` "
                + "FROM `order` JOIN `customer` ON `order`.`Customer_ID` = `customer`.`Customer_ID` "
                + "LEFT JOIN `employee` ON `order`.`Approved_By` = `employee`.`Employee_ID` WHERE `order`.`Date_Deleted` IS NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Order> list = new List<Order>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Order());
                list.Last().setOrderID(((uint)item["Order_ID"]).ToString("0000000000"));
                list.Last().setCustID(item["Customer_ID"].ToString());
                list.Last().setCustName(item["Customer_Surname"].ToString()+", "+ item["Customer_GivenName"].ToString());
                list.Last().setOrderDate(Convert.ToDateTime(item["Order_date"]));
                list.Last().setRejected(Convert.ToBoolean(item["Rejected"]));
                if (!Convert.IsDBNull(item["Bar_Code"])) list.Last().setBarCode(((ulong)item["Bar_Code"]).ToString("00000000000000000000"));
                if (!Convert.IsDBNull(item["Approved_By"])) list.Last().setApprovedByEmpID(item["Approved_By"].ToString());
                if (!Convert.IsDBNull(item["Employee_Surname"]) && !Convert.IsDBNull(item["Employee_GivenName"])) list.Last().setApprovedBy(item["Employee_Surname"].ToString() + ", " + item["Employee_GivenName"].ToString());
                if (!Convert.IsDBNull(item["Approve_Date"])) list.Last().setApprovedDate(Convert.ToDateTime(item["Approve_Date"]));
                if (!Convert.IsDBNull(item["PayPal_Payment_ID"])) list.Last().setPayPalPaymentID(item["PayPal_Payment_ID"].ToString());
                if (!Convert.IsDBNull(item["PayPal_Transaction_ID"])) list.Last().setPayPalTransactionID(item["PayPal_Transaction_ID"].ToString());
            }
            conn.Close();
            return list;
        }

        public List<Order> getAllDeletedOrders(MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `order`.`Order_ID`, `order`.`Customer_ID`,  `customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, `order`.`Order_date`, `order`.`Rejected`, `order`.`Bar_Code`, `order`.`Approved_By`, `employee`.`Employee_Surname`, `employee`.`Employee_GivenName`, `order`.`Approve_Date`, `order`.`PayPal_Payment_ID`, `order`.`PayPal_Transaction_ID` "
                + "FROM `order` JOIN `customer` ON `order`.`Customer_ID` = `customer`.`Customer_ID` "
                + "LEFT JOIN `employee` ON `order`.`Approved_By` = `employee`.`Employee_ID` WHERE `order`.`Date_Deleted` IS NOT NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Order> list = new List<Order>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Order());
                list.Last().setOrderID(((uint)item["Order_ID"]).ToString("0000000000"));
                list.Last().setCustID(item["Customer_ID"].ToString());
                list.Last().setCustName(item["Customer_Surname"].ToString() + ", " + item["Customer_GivenName"].ToString());
                list.Last().setOrderDate(Convert.ToDateTime(item["Order_date"]));
                list.Last().setRejected(Convert.ToBoolean(item["Rejected"]));
                if (!Convert.IsDBNull(item["Bar_Code"])) list.Last().setBarCode(((ulong)item["Bar_Code"]).ToString("00000000000000000000"));
                if (!Convert.IsDBNull(item["Approved_By"])) list.Last().setApprovedByEmpID(item["Approved_By"].ToString());
                if (!Convert.IsDBNull(item["Employee_Surname"]) && !Convert.IsDBNull(item["Employee_GivenName"])) list.Last().setApprovedBy(item["Employee_Surname"].ToString() + ", " + item["Employee_GivenName"].ToString());
                if (!Convert.IsDBNull(item["Approve_Date"])) list.Last().setApprovedDate(Convert.ToDateTime(item["Approve_Date"]));
                if (!Convert.IsDBNull(item["PayPal_Payment_ID"])) list.Last().setPayPalPaymentID(item["PayPal_Payment_ID"].ToString());
                if (!Convert.IsDBNull(item["PayPal_Transaction_ID"])) list.Last().setPayPalTransactionID(item["PayPal_Transaction_ID"].ToString());
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public Order getOneOrderByID(string orderID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `order`.`Order_ID`, `order`.`Customer_ID`,  `customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, `customer`.`Email`, `customer`.`Regeion_Code`, `customer`.`Mobile_Phone_No`, `customer`.`Address`, `order`.`Order_date`, `order`.`Rejected`, `order`.`Bar_Code`, `order`.`Approved_By`, `employee`.`Employee_Surname`, `employee`.`Employee_GivenName`, `order`.`Approve_Date`, `order`.`PayPal_Payment_ID`, `order`.`PayPal_Transaction_ID` "
                + "FROM `order` JOIN `customer` ON `order`.`Customer_ID` = `customer`.`Customer_ID` "
                + "LEFT JOIN `employee` ON `order`.`Approved_By` = `employee`.`Employee_ID` WHERE `order`.`Date_Deleted` IS NULL AND `order`.`Order_ID`=@orderID", conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Order order = new Order();
            foreach (DataRow item in dt.Rows)
            {
                order.setOrderID(((uint)item["Order_ID"]).ToString("0000000000"));
                order.setCustID(item["Customer_ID"].ToString());
                order.setCustName(item["Customer_Surname"].ToString() + ", " + item["Customer_GivenName"].ToString());
                order.setCustEmail(item["Email"].ToString());
                order.setCustMobilePhoneNo("+"+item["Regeion_Code"].ToString()+" "+ item["Mobile_Phone_No"].ToString());
                order.setCustAddress(item["Address"].ToString());
                order.setOrderDate(Convert.ToDateTime(item["Order_date"]));
                order.setRejected(Convert.ToBoolean(item["Rejected"]));
                if (!Convert.IsDBNull(item["Bar_Code"])) order.setBarCode(((ulong)item["Bar_Code"]).ToString("00000000000000000000"));
                if (!Convert.IsDBNull(item["Approved_By"])) order.setApprovedByEmpID(item["Approved_By"].ToString());
                if (!Convert.IsDBNull(item["Employee_Surname"]) && !Convert.IsDBNull(item["Employee_GivenName"])) order.setApprovedBy(item["Employee_Surname"].ToString() + ", " + item["Employee_GivenName"].ToString());
                if (!Convert.IsDBNull(item["Approve_Date"])) order.setApprovedDate(Convert.ToDateTime(item["Approve_Date"]));
                if (!Convert.IsDBNull(item["PayPal_Payment_ID"])) order.setPayPalPaymentID(item["PayPal_Payment_ID"].ToString());
                if (!Convert.IsDBNull(item["PayPal_Transaction_ID"])) order.setPayPalTransactionID(item["PayPal_Transaction_ID"].ToString());
            }
            conn.Close();
            return order;
        }

        public Order getOneDeletedOrderByID(string orderID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `order`.`Order_ID`, `order`.`Customer_ID`,  `customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, `customer`.`Email`, `customer`.`Regeion_Code`, `customer`.`Mobile_Phone_No`, `customer`.`Address`, `order`.`Order_date`, `order`.`Rejected`, `order`.`Bar_Code`, `order`.`Approved_By`, `employee`.`Employee_Surname`, `employee`.`Employee_GivenName`, `order`.`Approve_Date`, `order`.`PayPal_Payment_ID`, `order`.`PayPal_Transaction_ID` "
                + "FROM `order` JOIN `customer` ON `order`.`Customer_ID` = `customer`.`Customer_ID` "
                + "LEFT JOIN `employee` ON `order`.`Approved_By` = `employee`.`Employee_ID` WHERE `order`.`Date_Deleted` IS NOT NULL AND `order`.`Order_ID`=@orderID", conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Order order = new Order();
            foreach (DataRow item in dt.Rows)
            {
                order.setOrderID(((uint)item["Order_ID"]).ToString("0000000000"));
                order.setCustID(item["Customer_ID"].ToString());
                order.setCustName(item["Customer_Surname"].ToString() + ", " + item["Customer_GivenName"].ToString());
                order.setCustEmail(item["Email"].ToString());
                order.setCustMobilePhoneNo("+" + item["Regeion_Code"].ToString() + " " + item["Mobile_Phone_No"].ToString());
                order.setCustAddress(item["Address"].ToString());
                order.setOrderDate(Convert.ToDateTime(item["Order_date"]));
                order.setRejected(Convert.ToBoolean(item["Rejected"]));
                if (!Convert.IsDBNull(item["Bar_Code"])) order.setBarCode(((ulong)item["Bar_Code"]).ToString("00000000000000000000"));
                if (!Convert.IsDBNull(item["Approved_By"])) order.setApprovedByEmpID(item["Approved_By"].ToString());
                if (!Convert.IsDBNull(item["Employee_Surname"]) && !Convert.IsDBNull(item["Employee_GivenName"])) order.setApprovedBy(item["Employee_Surname"].ToString() + ", " + item["Employee_GivenName"].ToString());
                if (!Convert.IsDBNull(item["Approve_Date"])) order.setApprovedDate(Convert.ToDateTime(item["Approve_Date"]));
                if (!Convert.IsDBNull(item["PayPal_Payment_ID"])) order.setPayPalPaymentID(item["PayPal_Payment_ID"].ToString());
                if (!Convert.IsDBNull(item["PayPal_Transaction_ID"])) order.setPayPalTransactionID(item["PayPal_Transaction_ID"].ToString());
                order.setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return order;
        }

        public int insert(Order order, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `order`(`Order_ID`, `Customer_ID`, `Order_date`, `Rejected`) VALUES (@orderID,@customerID,@orderDate,@rejected)", conn);
            cmd.Parameters.AddWithValue("@orderID", order.getOrderID());
            cmd.Parameters.AddWithValue("@customerID", order.getCustID());
            cmd.Parameters.AddWithValue("@orderDate", order.getOrderDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@rejected", order.getRejected());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int update(Order order, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `order` SET `Customer_ID`=@customerID,`Order_date`=@orderDate,`Rejected`=@rejected,`Bar_Code`=@barCode,`Approved_By`=@approvedBy,`Approve_Date`=@approveDate,`PayPal_Payment_ID`=@payPalPaymentID,`PayPal_Transaction_ID`=@payPalTransactionID WHERE `Order_ID`=@orderID", conn);
            cmd.Parameters.AddWithValue("@orderID", order.getOrderID());
            cmd.Parameters.AddWithValue("@customerID", order.getCustID());
            cmd.Parameters.AddWithValue("@orderDate", order.getOrderDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@rejected", order.getRejected());
            cmd.Parameters.AddWithValue("@barCode", order.getBarCode() ?? null);
            cmd.Parameters.AddWithValue("@approvedBy", (order.getApprovedByEmpID()!=null)?order.getApprovedByEmpID():null);
            cmd.Parameters.AddWithValue("@approveDate", (order.getApprovedDate()!=null)?order.getApprovedDate().Value.ToString("yyyy-MM-dd HH:mm:ss"):null);
            cmd.Parameters.AddWithValue("@payPalPaymentID", (order.getPayPalPaymentID()!=null)?order.getPayPalPaymentID():null);
            cmd.Parameters.AddWithValue("@payPalTransactionID", (order.getPayPalTransactionID()!=null)?order.getPayPalTransactionID():null);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int delete(string orderID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `order` SET `Date_Deleted` = NOW() WHERE `Order_ID`=@orderID", conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int undelete(string orderID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `order` SET `Date_Deleted` = NULL WHERE `Order_ID`=@orderID", conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int permanentlyDelete(string orderID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `order` WHERE `Order_ID`=@orderID", conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
