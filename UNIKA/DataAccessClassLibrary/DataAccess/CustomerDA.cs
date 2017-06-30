using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class CustomerDA
    {
        public Dictionary<string, int> getAllAgeGroups(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `customer_age_group`", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Dictionary<string, int> list = new Dictionary<string, int>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(item["Age_Group_" + langCode].ToString(), (int)item["Age_Group_Code"]);
            }
            conn.Close();
            return list;
        }

        public List<Customer> getAllCustomers(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `customer`.`Customer_ID`, `customer`.`Email`, "+
                "`customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, " +
                "`customer_age_group`.`Age_Group_en-US`, `customer_age_group`.`Age_Group_zh-Hant`, "+
                "`customer`.`Regeion_Code`, `customer`.`Mobile_Phone_No`, `customer`.`Gender`, `customer`.`Age_Group_Code`, "+
                "`customer`.`Address`, `customer`.`Activated` FROM `customer`, `customer_age_group` "+
                "WHERE `customer_age_group`.`Age_Group_Code` = `customer`.`Age_Group_Code` AND `customer`.`Date_Deleted` IS NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Customer> list = new List<Customer>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Customer());
                list.Last().setCustomerID(item["Customer_ID"].ToString());
                list.Last().setEmail(item["Email"].ToString());
                list.Last().setCustomerSurname(item["Customer_Surname"].ToString());
                list.Last().setCustomerGivenName(item["Customer_GivenName"].ToString());
                list.Last().setRegeionCode((int)item["Regeion_Code"]);
                list.Last().setMobilePhoneNo((int)item["Mobile_Phone_No"]);
                list.Last().setGender(Convert.ToChar(item["Gender"]));
                list.Last().setAgeGroupCode((int)item["Age_Group_Code"]);
                list.Last().setAgeGroup(item["Age_Group_"+ langCode].ToString());
                list.Last().setAddress(item["Address"].ToString());
                list.Last().setActivated(Convert.ToBoolean(item["Activated"]));
            }
            conn.Close();
            return list;
        }

        public List<Customer> getAllDeletedCustomers(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `customer`.`Customer_ID`, `customer`.`Email`, " +
                "`customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, " +
                "`customer_age_group`.`Age_Group_en-US`, `customer_age_group`.`Age_Group_zh-Hant`, " +
                "`customer`.`Regeion_Code`, `customer`.`Mobile_Phone_No`, `customer`.`Gender`, `customer`.`Age_Group_Code`, " +
                "`customer`.`Address`, `customer`.`Activated`, `customer`.`Date_Deleted` FROM `customer`, `customer_age_group` " +
                "WHERE `customer_age_group`.`Age_Group_Code` = `customer`.`Age_Group_Code` AND `customer`.`Date_Deleted` IS NOT NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Customer> list = new List<Customer>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Customer());
                list.Last().setCustomerID(item["Customer_ID"].ToString());
                list.Last().setEmail(item["Email"].ToString());
                list.Last().setCustomerSurname(item["Customer_Surname"].ToString());
                list.Last().setCustomerGivenName(item["Customer_GivenName"].ToString());
                list.Last().setRegeionCode((int)item["Regeion_Code"]);
                list.Last().setMobilePhoneNo((int)item["Mobile_Phone_No"]);
                list.Last().setGender(Convert.ToChar(item["Gender"]));
                list.Last().setAgeGroupCode((int)item["Age_Group_Code"]);
                list.Last().setAgeGroup(item["Age_Group_" + langCode].ToString());
                list.Last().setAddress(item["Email"].ToString());
                list.Last().setActivated(Convert.ToBoolean(item["Activated"]));
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public Customer getOneCustomerByID(string customerID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `customer`.`Customer_ID`, `customer`.`Email`, " +
                "`customer`.`Password`, `customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, " +
                "`customer_age_group`.`Age_Group_en-US`, `customer_age_group`.`Age_Group_zh-Hant`, " +
                "`customer`.`Regeion_Code`, `customer`.`Mobile_Phone_No`, `customer`.`Gender`, `customer`.`Age_Group_Code`, " +
                "`customer`.`Address`, `customer`.`Activated` FROM `customer`, `customer_age_group` " +
                "WHERE `customer_age_group`.`Age_Group_Code` = `customer`.`Age_Group_Code` AND `customer`.`Date_Deleted` IS NULL AND `customer`.`Customer_ID`=@customerID", conn);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Customer customer = new Customer();
            foreach (DataRow item in dt.Rows)
            {
                customer.setCustomerID(item["Customer_ID"].ToString());
                customer.setEmail(item["Email"].ToString());
                customer.setPassword(item["Password"].ToString());
                customer.setCustomerSurname(item["Customer_Surname"].ToString());
                customer.setCustomerGivenName(item["Customer_GivenName"].ToString());
                customer.setRegeionCode((int)item["Regeion_Code"]);
                customer.setMobilePhoneNo((int)item["Mobile_Phone_No"]);
                customer.setGender(Convert.ToChar(item["Gender"]));
                customer.setAgeGroupCode((int)item["Age_Group_Code"]);
                customer.setAgeGroup(item["Age_Group_" + langCode].ToString());
                customer.setAddress(item["Address"].ToString());
                customer.setActivated(Convert.ToBoolean(item["Activated"]));
            }
            conn.Close();
            return customer;
        }

        public Customer getOneDeletedCustomerByID(string customerID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `customer`.`Customer_ID`, `customer`.`Email`, " +
                "`customer`.`Password`, `customer`.`Customer_Surname`, `customer`.`Customer_GivenName`, " +
                "`customer_age_group`.`Age_Group_en-US`, `customer_age_group`.`Age_Group_zh-Hant`, " +
                "`customer`.`Regeion_Code`, `customer`.`Mobile_Phone_No`, `customer`.`Gender`, `customer`.`Age_Group_Code`, " +
                "`customer`.`Address`, `customer`.`Activated`, `customer`.`Date_Deleted` FROM `customer`, `customer_age_group` " +
                "WHERE `customer_age_group`.`Age_Group_Code` = `customer`.`Age_Group_Code` AND `customer`.`Date_Deleted` IS NOT NULL AND `customer`.`Customer_ID`=@customerID", conn);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Customer customer = new Customer();
            foreach (DataRow item in dt.Rows)
            {
                customer.setCustomerID(item["Customer_ID"].ToString());
                customer.setEmail(item["Email"].ToString());
                customer.setPassword(item["Password"].ToString());
                customer.setCustomerSurname(item["Customer_Surname"].ToString());
                customer.setCustomerGivenName(item["Customer_GivenName"].ToString());
                customer.setRegeionCode((int)item["Regeion_Code"]);
                customer.setMobilePhoneNo((int)item["Mobile_Phone_No"]);
                customer.setGender(Convert.ToChar(item["Gender"]));
                customer.setAgeGroupCode((int)item["Age_Group_Code"]);
                customer.setAgeGroup(item["Age_Group_" + langCode].ToString());
                customer.setAddress(item["Address"].ToString());
                customer.setActivated(Convert.ToBoolean(item["Activated"]));
                customer.setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return customer;
        }

        public int insert(Customer customer, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `customer`(`Customer_ID`, `Email`, `Password`, `Customer_Surname`, `Customer_GivenName`, `Regeion_Code`, `Mobile_Phone_No`, `Gender`, `Age_Group_Code`, `Address`, `Activated`) VALUES " +
                "VALUES (@customerID,@email,@password,@surname,@givenName,@regeionCode,@mobilePhoneNo,@gender,@ageGroupCode,@address,@activated)", conn);
            cmd.Parameters.AddWithValue("@customerID", customer.getCustomerID());
            cmd.Parameters.AddWithValue("@email", customer.getEmail());
            cmd.Parameters.AddWithValue("@password", customer.getPassword());
            cmd.Parameters.AddWithValue("@surname", customer.getCustomerSurname());
            cmd.Parameters.AddWithValue("@givenName", customer.getCustomerGivenName());
            cmd.Parameters.AddWithValue("@regeionCode", customer.getRegeionCode());
            cmd.Parameters.AddWithValue("@mobilePhoneNo", customer.getMobilePhoneNo());
            cmd.Parameters.AddWithValue("@gender", customer.getGender());
            cmd.Parameters.AddWithValue("@ageGroupCode", customer.getAgeGroupCode());
            cmd.Parameters.AddWithValue("@address", customer.getAddress());
            cmd.Parameters.AddWithValue("@activated", Convert.ToByte(customer.getActivated()));
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int update(Customer customer, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `customer` SET `Email`=@email,`Password`=@password,`Customer_Surname`=@surname,`Customer_GivenName`=@givenName,`Regeion_Code`=@regeionCode,`Mobile_Phone_No`=@mobilePhoneNo,`Gender`=@gender,`Age_Group_Code`=@ageGroupCode,`Address`=@address,`Activated`=@activated " +
                "WHERE `Customer_ID`=@customerID", conn);
            cmd.Parameters.AddWithValue("@customerID", customer.getCustomerID());
            cmd.Parameters.AddWithValue("@email", customer.getEmail());
            cmd.Parameters.AddWithValue("@password", customer.getPassword());
            cmd.Parameters.AddWithValue("@surname", customer.getCustomerSurname());
            cmd.Parameters.AddWithValue("@givenName", customer.getCustomerGivenName());
            cmd.Parameters.AddWithValue("@regeionCode", customer.getRegeionCode());
            cmd.Parameters.AddWithValue("@mobilePhoneNo", customer.getMobilePhoneNo());
            cmd.Parameters.AddWithValue("@gender", customer.getGender());
            cmd.Parameters.AddWithValue("@ageGroupCode", customer.getAgeGroupCode());
            cmd.Parameters.AddWithValue("@address", customer.getAddress());
            cmd.Parameters.AddWithValue("@activated", Convert.ToByte(customer.getActivated()));
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int delete(string customerID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `customer` SET `Date_Deleted` = NOW() WHERE `Customer_ID`=@customerID", conn);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int undelete(string customerID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `customer` SET `Date_Deleted` = NULL WHERE `Customer_ID`=@customerID", conn);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int permanentlyDelete(string customerID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `customer` WHERE `Customer_ID`=@customerID", conn);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
