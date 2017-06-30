using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class ProductPackageDA
    {
        public List<Package> getAllProductPackages(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_package`.`Product_ID`, " +
                "`product_package`.`Product_Name_en-US`, " +
                "`product_package`.`Product_Name_zh-Hant`, " +
                "`product_package`.`Description_en-US`, " +
                "`product_package`.`Description_zh-Hant`, " +
                "`product_package`.`Supplier_ID`, " +
                "`supplier`.`Supplier_Name`, " +
                "`product_package`.`Qty_In_Stock`, " +
                "`product_package`.`Price`, " +
                "`product_package`.`Release_Date`" +
                "FROM `product_package`, `supplier` WHERE `product_package`.`Date_Deleted` IS NULL AND `product_package`.`Supplier_ID` = `supplier`.`Supplier_ID`", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Package> list = new List<Package>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Package());
                list.Last().setProductID(item["Product_ID"].ToString());
                list.Last().setProductName(item["Product_Name_" + langCode].ToString());
                list.Last().setProductNameEnUs(item["Product_Name_en-US"].ToString());
                list.Last().setProductNameZhHant(item["Product_Name_zh-Hant"].ToString());
                list.Last().setDescription(item["Description_" + langCode].ToString());
                list.Last().setDescriptionEnUs(item["Description_en-US"].ToString());
                list.Last().setDescriptionZhHant(item["Description_zh-Hant"].ToString());
                list.Last().setPhoto(null);
                list.Last().setSupplierID(item["Supplier_ID"].ToString());
                list.Last().setSupplierName(item["Supplier_Name"].ToString());
                list.Last().setQtyInStock((int)item["Qty_In_Stock"]);
                list.Last().setPrice((int)item["Price"]);
                list.Last().setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
            }
            conn.Close();
            return list;
        }

        public List<Package> getAllDeletedProductPackages(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_package`.`Product_ID`, " +
                "`product_package`.`Product_Name_en-US`, " +
                "`product_package`.`Product_Name_zh-Hant`, " +
                "`product_package`.`Description_en-US`, " +
                "`product_package`.`Description_zh-Hant`, " +
                "`product_package`.`Supplier_ID`, " +
                "`supplier`.`Supplier_Name`, " +
                "`product_package`.`Qty_In_Stock`, " +
                "`product_package`.`Price`, " +
                "`product_package`.`Release_Date`, " +
                "`product_package`.`Date_Deleted`" +
                "FROM `product_package`, `supplier` WHERE `product_package`.`Date_Deleted` IS NOT NULL AND `product_package`.`Supplier_ID` = `supplier`.`Supplier_ID`", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Package> list = new List<Package>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Package());
                list.Last().setProductID(item["Product_ID"].ToString());
                list.Last().setProductName(item["Product_Name_" + langCode].ToString());
                list.Last().setProductNameEnUs(item["Product_Name_en-US"].ToString());
                list.Last().setProductNameZhHant(item["Product_Name_zh-Hant"].ToString());
                list.Last().setDescription(item["Description_" + langCode].ToString());
                list.Last().setDescriptionEnUs(item["Description_en-US"].ToString());
                list.Last().setDescriptionZhHant(item["Description_zh-Hant"].ToString());
                list.Last().setPhoto(null);
                list.Last().setSupplierID(item["Supplier_ID"].ToString());
                list.Last().setSupplierName(item["Supplier_Name"].ToString());
                list.Last().setQtyInStock((int)item["Qty_In_Stock"]);
                list.Last().setPrice((int)item["Price"]);
                list.Last().setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public List<Package> findProductPackagesBySupplierID(string supplierID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_package`.`Product_ID`, " +
                "`product_package`.`Product_Name_en-US`, " +
                "`product_package`.`Product_Name_zh-Hant`, " +
                "`product_package`.`Description_en-US`, " +
                "`product_package`.`Description_zh-Hant`, " +
                "`product_package`.`Supplier_ID`, " +
                "`supplier`.`Supplier_Name`, " +
                "`product_package`.`Qty_In_Stock`, " +
                "`product_package`.`Price`, " +
                "`product_package`.`Release_Date`" +
                "FROM `product_package`, `supplier` WHERE `product_package`.`Supplier_ID` = @supplierID AND `product_package`.`Date_Deleted` IS NULL AND `product_package`.`Supplier_ID` = `supplier`.`Supplier_ID`", conn);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Package> list = new List<Package>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Package());
                list.Last().setProductID(item["Product_ID"].ToString());
                list.Last().setProductName(item["Product_Name_" + langCode].ToString());
                list.Last().setProductNameEnUs(item["Product_Name_en-US"].ToString());
                list.Last().setProductNameZhHant(item["Product_Name_zh-Hant"].ToString());
                list.Last().setDescription(item["Description_" + langCode].ToString());
                list.Last().setDescriptionEnUs(item["Description_en-US"].ToString());
                list.Last().setDescriptionZhHant(item["Description_zh-Hant"].ToString());
                list.Last().setPhoto(null);
                list.Last().setSupplierID(item["Supplier_ID"].ToString());
                list.Last().setSupplierName(item["Supplier_Name"].ToString());
                list.Last().setQtyInStock((int)item["Qty_In_Stock"]);
                list.Last().setPrice((int)item["Price"]);
                list.Last().setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
            }
            conn.Close();
            return list;
        }

        public List<Package> findDeletedProductPackagesBySupplierID(string supplierID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_package`.`Product_ID`, " +
                "`product_package`.`Product_Name_en-US`, " +
                "`product_package`.`Product_Name_zh-Hant`, " +
                "`product_package`.`Description_en-US`, " +
                "`product_package`.`Description_zh-Hant`, " +
                "`product_package`.`Supplier_ID`, " +
                "`supplier`.`Supplier_Name`, " +
                "`product_package`.`Qty_In_Stock`, " +
                "`product_package`.`Price`, " +
                "`product_package`.`Release_Date`, " +
                "`product_package`.`Date_Deleted`" +
                "FROM `product_package`, `supplier` WHERE `product_package`.`Supplier_ID` = @supplierID AND `product_package`.`Date_Deleted` IS NOT NULL AND `product_package`.`Supplier_ID` = `supplier`.`Supplier_ID`", conn);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Package> list = new List<Package>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Package());
                list.Last().setProductID(item["Product_ID"].ToString());
                list.Last().setProductName(item["Product_Name_" + langCode].ToString());
                list.Last().setProductNameEnUs(item["Product_Name_en-US"].ToString());
                list.Last().setProductNameZhHant(item["Product_Name_zh-Hant"].ToString());
                list.Last().setDescription(item["Description_" + langCode].ToString());
                list.Last().setDescriptionEnUs(item["Description_en-US"].ToString());
                list.Last().setDescriptionZhHant(item["Description_zh-Hant"].ToString());
                list.Last().setPhoto(null);
                list.Last().setSupplierID(item["Supplier_ID"].ToString());
                list.Last().setSupplierName(item["Supplier_Name"].ToString());
                list.Last().setQtyInStock((int)item["Qty_In_Stock"]);
                list.Last().setPrice((int)item["Price"]);
                list.Last().setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public Package getOneProductPackageByID(string productID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_package`.`Product_ID`, " +
                "`product_package`.`Product_Name_en-US`, " +
                "`product_package`.`Product_Name_zh-Hant`, " +
                "`product_package`.`Description_en-US`, " +
                "`product_package`.`Description_zh-Hant`, " +
                "`product_package`.`Photo`, " +
                "`product_package`.`Supplier_ID`, " +
                "`supplier`.`Supplier_Name`, " +
                "`product_package`.`Qty_In_Stock`, " +
                "`product_package`.`Price`, " +
                "`product_package`.`Release_Date`" +
                "FROM `product_package`, `supplier` WHERE `product_package`.`Date_Deleted` IS NULL AND `product_package`.`Product_ID` = @productID AND `product_package`.`Supplier_ID` = `supplier`.`Supplier_ID`", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Package package = new Package();
            foreach (DataRow item in dt.Rows)
            {
                package.setProductID(item["Product_ID"].ToString());
                package.setProductName(item["Product_Name_" + langCode].ToString());
                package.setProductNameEnUs(item["Product_Name_en-US"].ToString());
                package.setProductNameZhHant(item["Product_Name_zh-Hant"].ToString());
                package.setDescription(item["Description_" + langCode].ToString());
                package.setDescriptionEnUs(item["Description_en-US"].ToString());
                package.setDescriptionZhHant(item["Description_zh-Hant"].ToString());
                package.setPhoto(ImageConverter.byteArrayToImage((byte[])item["Photo"]));
                package.setSupplierID(item["Supplier_ID"].ToString());
                package.setSupplierName(item["Supplier_Name"].ToString());
                package.setQtyInStock((int)item["Qty_In_Stock"]);
                package.setPrice((int)item["Price"]);
                package.setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
            }
            conn.Close();
            return package;
        }

        public Package getOneDeletedPackageByID(string productID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_package`.`Product_ID`, " +
                "`product_package`.`Product_Name_en-US`, " +
                "`product_package`.`Product_Name_zh-Hant`, " +
                "`product_package`.`Description_en-US`, " +
                "`product_package`.`Description_zh-Hant`, " +
                "`product_package`.`Photo`, " +
                "`product_package`.`Supplier_ID`, " +
                "`supplier`.`Supplier_Name`, " +
                "`product_package`.`Qty_In_Stock`, " +
                "`product_package`.`Price`, " +
                "`product_package`.`Release_Date`, " +
                "`product_package`.`Date_Deleted`" +
                "FROM `product_package`, `supplier` WHERE `product_package`.`Date_Deleted` IS NOT NULL AND `product_package`.`Product_ID` = @productID AND `product_package`.`Supplier_ID` = `supplier`.`Supplier_ID`", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Package package = new Package();
            foreach (DataRow item in dt.Rows)
            {
                package.setProductID(item["Product_ID"].ToString());
                package.setProductName(item["Product_Name_" + langCode].ToString());
                package.setProductNameEnUs(item["Product_Name_en-US"].ToString());
                package.setProductNameZhHant(item["Product_Name_zh-Hant"].ToString());
                package.setDescription(item["Description_" + langCode].ToString());
                package.setDescriptionEnUs(item["Description_en-US"].ToString());
                package.setDescriptionZhHant(item["Description_zh-Hant"].ToString());
                package.setPhoto(ImageConverter.byteArrayToImage((byte[])item["Photo"]));
                package.setSupplierID(item["Supplier_ID"].ToString());
                package.setSupplierName(item["Supplier_Name"].ToString());
                package.setQtyInStock((int)item["Qty_In_Stock"]);
                package.setPrice((int)item["Price"]);
                package.setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
                package.setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return package;
        }

        public int insert(Package package, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `product_package`(`Product_ID`, `Product_Name_en-US`, `Product_Name_zh-Hant`, `Description_en-US`, `Description_zh-Hant`, `Photo`, `Supplier_ID`, `Qty_In_Stock`, `Price`, `Release_Date`) " +
                "VALUES (@productID,@productNameEnUs,@productNameZhHant,@descriptionEnUs,@descriptionZhHant,@photo,@supplierID,@qtyInStock,@price,@releaseDate)", conn);
            cmd.Parameters.AddWithValue("@productID", package.getProductID());
            cmd.Parameters.AddWithValue("@productNameEnUs", package.getProductNameEnUs());
            cmd.Parameters.AddWithValue("@productNameZhHant", package.getProductNameZhHant());
            cmd.Parameters.AddWithValue("@descriptionEnUs", package.getDescriptionEnUs());
            cmd.Parameters.AddWithValue("@descriptionZhHant", package.getDescriptionZhHant());
            cmd.Parameters.AddWithValue("@photo", ImageConverter.imageToByteArray(package.getPhoto()));
            cmd.Parameters.AddWithValue("@supplierID", package.getSupplierID());
            cmd.Parameters.AddWithValue("@qtyInStock", package.getQtyInStock());
            cmd.Parameters.AddWithValue("@price", package.getPrice());
            cmd.Parameters.AddWithValue("@releaseDate", package.getReleaseDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int update(Package package, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `product_package` SET `Product_Name_en-US`=@productNameEnUs,`Product_Name_zh-Hant`=@productNameZhHant,`Description_en-US`=@descriptionEnUs,`Description_zh-Hant`=@descriptionZhHant,`Photo`=@photo,`Supplier_ID`=@supplierID,`Qty_In_Stock`=@qtyInStock,`Price`=@price,`Release_Date`=@releaseDate WHERE `Product_ID`=@productID", conn);
            cmd.Parameters.AddWithValue("@productID", package.getProductID());
            cmd.Parameters.AddWithValue("@productNameEnUs", package.getProductNameEnUs());
            cmd.Parameters.AddWithValue("@productNameZhHant", package.getProductNameZhHant());
            cmd.Parameters.AddWithValue("@descriptionEnUs", package.getDescriptionEnUs());
            cmd.Parameters.AddWithValue("@descriptionZhHant", package.getDescriptionZhHant());
            cmd.Parameters.AddWithValue("@photo", ImageConverter.imageToByteArray(package.getPhoto()));
            cmd.Parameters.AddWithValue("@supplierID", package.getSupplierID());
            cmd.Parameters.AddWithValue("@qtyInStock", package.getQtyInStock());
            cmd.Parameters.AddWithValue("@price", package.getPrice());
            cmd.Parameters.AddWithValue("@releaseDate", package.getReleaseDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int delete(string productID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `product_package` SET `Date_Deleted` = NOW() WHERE `Product_ID` = @productID", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int undelete(string productID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `product_package` SET `Date_Deleted` = NULL WHERE `Product_ID` = @productID", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int permanentlyDelete(string productID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `product_package` WHERE `Product_ID` = @productID", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
