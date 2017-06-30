using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class SupplierDA
    {
        public List<Supplier> getAllSuppliers(MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `supplier` WHERE `Date_Deleted` IS NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Supplier> list = new List<Supplier>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Supplier());
                list.Last().setSupplierID(item["Supplier_ID"].ToString());
                list.Last().setSupplierName(item["Supplier_Name"].ToString());
                list.Last().setProductCategory(item["Product_Category"].ToString());
                list.Last().setContectNo(item["ContectNo"].ToString());
                list.Last().setEmail(item["Email"].ToString());
                list.Last().setAddress(item["Address"].ToString());
            }
            conn.Close();
            return list;
        }

        public List<Supplier> getAllDeletedSuppliers(MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `supplier` WHERE `Date_Deleted` IS NOT NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Supplier> list = new List<Supplier>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Supplier());
                list.Last().setSupplierID(item["Supplier_ID"].ToString());
                list.Last().setSupplierName(item["Supplier_Name"].ToString());
                list.Last().setProductCategory(item["Product_Category"].ToString());
                list.Last().setContectNo(item["ContectNo"].ToString());
                list.Last().setEmail(item["Email"].ToString());
                list.Last().setAddress(item["Address"].ToString());
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public Supplier getOneSupplierByID(string supplierID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `supplier` WHERE `Supplier_ID` = @supplierID  AND `Date_Deleted` IS NULL", conn);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Supplier supplier = new Supplier();
            foreach (DataRow item in dt.Rows)
            {
                supplier.setSupplierID(item["Supplier_ID"].ToString());
                supplier.setPassword(item["Password"].ToString());
                supplier.setSupplierName(item["Supplier_Name"].ToString());
                supplier.setProductCategory(item["Product_Category"].ToString());
                supplier.setContectNo(item["ContectNo"].ToString());
                supplier.setEmail(item["Email"].ToString());
                supplier.setAddress(item["Address"].ToString());
            }
            conn.Close();
            return supplier;
        }

        public Supplier getOneDeletedSupplierByID(string supplierID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `supplier` WHERE `Supplier_ID` = @supplierID  AND `Date_Deleted` IS NOT NULL", conn);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Supplier supplier = new Supplier();
            foreach (DataRow item in dt.Rows)
            {
                supplier.setSupplierID(item["Supplier_ID"].ToString());
                supplier.setPassword(item["Password"].ToString());
                supplier.setSupplierName(item["Supplier_Name"].ToString());
                supplier.setProductCategory(item["Product_Category"].ToString());
                supplier.setContectNo(item["ContectNo"].ToString());
                supplier.setEmail(item["Email"].ToString());
                supplier.setAddress(item["Address"].ToString());
                supplier.setDateDeleted(Convert.ToDateTime(item["Release_Date"]));
            }
            conn.Close();
            return supplier;
        }

        public int insert(Supplier supplier, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `supplier` (`Supplier_ID`, `Supplier_Name`, `Password`, `Product_Category`, `ContectNo`, `Email`, `Address`) " +
                "VALUES (@supplierID,@supplierName,@password,@productCategory,@contectNo,@email,@address)", conn);
            cmd.Parameters.AddWithValue("@supplierID", supplier.getSupplierID());
            cmd.Parameters.AddWithValue("@supplierName", supplier.getSupplierName());
            cmd.Parameters.AddWithValue("@password", supplier.getPassword());
            cmd.Parameters.AddWithValue("@productCategory", supplier.getProductCategory());
            cmd.Parameters.AddWithValue("@contectNo", supplier.getContectNo());
            cmd.Parameters.AddWithValue("@email", supplier.getEmail());
            cmd.Parameters.AddWithValue("@address", supplier.getAddress());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int update(Supplier supplier, string currenId, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `supplier` SET `Supplier_ID` = @supplierId, `Supplier_Name` = @supplierName, `Password` = @password, `Product_Category` = @productCategory, `ContectNo` = @contectNo, `Email` = @email, `Address` = @address " +
                "WHERE `Supplier_ID` = @currenId", conn);
            cmd.Parameters.AddWithValue("@supplierName", supplier.getSupplierName());
            cmd.Parameters.AddWithValue("@password", supplier.getPassword());
            cmd.Parameters.AddWithValue("@productCategory", supplier.getProductCategory());
            cmd.Parameters.AddWithValue("@contectNo", supplier.getContectNo());
            cmd.Parameters.AddWithValue("@email", supplier.getEmail());
            cmd.Parameters.AddWithValue("@address", supplier.getAddress());
            cmd.Parameters.AddWithValue("@supplierId", supplier.getSupplierID());
            cmd.Parameters.AddWithValue("@currenId", supplier.getSupplierID());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int delete(string supplierID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `supplier` SET `Date_Deleted` = NOW() WHERE `Supplier_ID` = @supplierID", conn);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int undelete(string supplierID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `supplier` SET `Date_Deleted` = NULL WHERE `Supplier_ID` = @supplierID", conn);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int permanentlyDelete(string supplierID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `supplier` WHERE `Supplier_ID` = @supplierID", conn);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
