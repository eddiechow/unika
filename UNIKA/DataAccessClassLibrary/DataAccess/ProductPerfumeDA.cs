using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class ProductPerfumeDA
    {
        public Dictionary<string, string> getAllCategories(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `product_perfume_category`", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Dictionary<string, string> list = new Dictionary<string, string>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(item["Category_Name_" + langCode].ToString(), item["Perfume_Category_Code"].ToString());
            }
            conn.Close();
            return list;
        }

        public List<Perfume> getAllProductPerfume(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `p`.`Product_ID`, `p`.`Product_Name_en-US`, `p`.`Product_Name_zh-Hant`, "+
                "`p`.`Description_en-US`, `p`.`Description_zh-Hant`, " +
                "`p`.`Supplier_ID`, `s`.`Supplier_Name`, `p`.`Perfume_Category_Code`, `pc`.`Category_Name_en-US`, " +
                "`pc`.`Category_Name_zh-Hant`, `p`.`Qty_In_Stock`, `p`.`Price`, `p`.`Release_Date`  " +
                "FROM `product_perfume` AS `p`  " +
                "INNER JOIN `supplier` AS `s` ON `p`.`Supplier_ID` = `s`.`Supplier_ID`  " +
                "INNER JOIN `product_perfume_category` AS `pc` ON `p`.`Perfume_Category_Code` = `pc`.`Perfume_Category_Code`  " +
                "WHERE `p`.`Date_Deleted` IS NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Perfume> list = new List<Perfume>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Perfume());
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
                list.Last().setCategoryCode(item["Perfume_Category_Code"].ToString());
                list.Last().setCategory(item["Category_Name_" + langCode].ToString());
                list.Last().setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
            }
            conn.Close();
            return list;
        }

        public List<Perfume> getAllDeletedProductPerfume(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `p`.`Product_ID`, `p`.`Product_Name_en-US`, `p`.`Product_Name_zh-Hant`, " +
                "`p`.`Description_en-US`, `p`.`Description_zh-Hant`, " +
                "`p`.`Supplier_ID`, `s`.`Supplier_Name`, `p`.`Perfume_Category_Code`, `pc`.`Category_Name_en-US`, " +
                "`pc`.`Category_Name_zh-Hant`, `p`.`Qty_In_Stock`, `p`.`Price`, `p`.`Release_Date`, `p`.`Date_Deleted` " +
                "FROM `product_perfume` AS `p`  " +
                "INNER JOIN `supplier` AS `s` ON `p`.`Supplier_ID` = `s`.`Supplier_ID`  " +
                "INNER JOIN `product_perfume_category` AS `pc` ON `p`.`Perfume_Category_Code` = `pc`.`Perfume_Category_Code`  " +
                "WHERE `p`.`Date_Deleted` IS NOT NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Perfume> list = new List<Perfume>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Perfume());
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
                list.Last().setCategoryCode(item["Perfume_Category_Code"].ToString());
                list.Last().setCategory(item["Category_Name_" + langCode].ToString());
                list.Last().setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public List<Perfume> findProductPerfumeBySupplierID(string supplierID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `p`.`Product_ID`, `p`.`Product_Name_en-US`, `p`.`Product_Name_zh-Hant`, " +
                "`p`.`Description_en-US`, `p`.`Description_zh-Hant`, " +
                "`p`.`Supplier_ID`, `s`.`Supplier_Name`, `p`.`Perfume_Category_Code`, `pc`.`Category_Name_en-US`, " +
                "`pc`.`Category_Name_zh-Hant`, `p`.`Qty_In_Stock`, `p`.`Price`, `p`.`Release_Date`  " +
                "FROM `product_perfume` AS `p`  " +
                "INNER JOIN `supplier` AS `s` ON `p`.`Supplier_ID` = `s`.`Supplier_ID`  " +
                "INNER JOIN `product_perfume_category` AS `pc` ON `p`.`Perfume_Category_Code` = `pc`.`Perfume_Category_Code`  " +
                "WHERE `p`.`Supplier_ID` = @supplierID AND `p`.`Date_Deleted` IS NULL", conn);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Perfume> list = new List<Perfume>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Perfume());
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
                list.Last().setCategoryCode(item["Perfume_Category_Code"].ToString());
                list.Last().setCategory(item["Category_Name_" + langCode].ToString());
                list.Last().setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
            }
            conn.Close();
            return list;
        }

        public List<Perfume> findDeletedProductPerfumeBySupplierID(string supplierID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `p`.`Product_ID`, `p`.`Product_Name_en-US`, `p`.`Product_Name_zh-Hant`, " +
                "`p`.`Description_en-US`, `p`.`Description_zh-Hant`, " +
                "`p`.`Supplier_ID`, `s`.`Supplier_Name`, `p`.`Perfume_Category_Code`, `pc`.`Category_Name_en-US`, " +
                "`pc`.`Category_Name_zh-Hant`, `p`.`Qty_In_Stock`, `p`.`Price`, `p`.`Release_Date`, `p`.`Date_Deleted` " +
                "FROM `product_perfume` AS `p`  " +
                "INNER JOIN `supplier` AS `s` ON `p`.`Supplier_ID` = `s`.`Supplier_ID`  " +
                "INNER JOIN `product_perfume_category` AS `pc` ON `p`.`Perfume_Category_Code` = `pc`.`Perfume_Category_Code`  " +
                "WHERE `p`.`Supplier_ID` = @supplierID AND `p`.`Date_Deleted` IS NOT NULL", conn);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Perfume> list = new List<Perfume>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Perfume());
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
                list.Last().setCategoryCode(item["Perfume_Category_Code"].ToString());
                list.Last().setCategory(item["Category_Name_" + langCode].ToString());
                list.Last().setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public Perfume getOneProductPerfumeByID(string productID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `p`.`Product_ID`, `p`.`Product_Name_en-US`, `p`.`Product_Name_zh-Hant`, " +
                "`p`.`Description_en-US`, `p`.`Description_zh-Hant`, `p`.`Photo`, " +
                "`p`.`Supplier_ID`, `s`.`Supplier_Name`, `p`.`Perfume_Category_Code`, `pc`.`Category_Name_en-US`, " +
                "`pc`.`Category_Name_zh-Hant`, `p`.`Qty_In_Stock`, `p`.`Price`, `p`.`Release_Date`  " +
                "FROM `product_perfume` AS `p`  " +
                "INNER JOIN `supplier` AS `s` ON `p`.`Supplier_ID` = `s`.`Supplier_ID`  " +
                "INNER JOIN `product_perfume_category` AS `pc` ON `p`.`Perfume_Category_Code` = `pc`.`Perfume_Category_Code`  " +
                "WHERE `p`.`Date_Deleted` IS NULL AND `p`.`Product_ID` = @productID", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Perfume perfume = new Perfume();
            foreach (DataRow item in dt.Rows)
            {
                perfume.setProductID(item["Product_ID"].ToString());
                perfume.setProductName(item["Product_Name_" + langCode].ToString());
                perfume.setProductNameEnUs(item["Product_Name_en-US"].ToString());
                perfume.setProductNameZhHant(item["Product_Name_zh-Hant"].ToString());
                perfume.setDescription(item["Description_" + langCode].ToString());
                perfume.setDescriptionEnUs(item["Description_en-US"].ToString());
                perfume.setDescriptionZhHant(item["Description_zh-Hant"].ToString());
                perfume.setPhoto(ImageConverter.byteArrayToImage((byte[])item["Photo"]));
                perfume.setSupplierID(item["Supplier_ID"].ToString());
                perfume.setSupplierName(item["Supplier_Name"].ToString());
                perfume.setQtyInStock((int)item["Qty_In_Stock"]);
                perfume.setPrice((int)item["Price"]);
                perfume.setCategoryCode(item["Perfume_Category_Code"].ToString());
                perfume.setCategory(item["Category_Name_" + langCode].ToString());
                perfume.setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
            }
            conn.Close();
            return perfume;
        }

        public Perfume getOneDeletedProductPerfumeByID(string productID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `p`.`Product_ID`, `p`.`Product_Name_en-US`, `p`.`Product_Name_zh-Hant`, " +
                "`p`.`Description_en-US`, `p`.`Description_zh-Hant`, `p`.`Photo`, " +
                "`p`.`Supplier_ID`, `s`.`Supplier_Name`, `p`.`Perfume_Category_Code`, `pc`.`Category_Name_en-US`, " +
                "`pc`.`Category_Name_zh-Hant`, `p`.`Qty_In_Stock`, `p`.`Price`, `p`.`Release_Date`, `p`.`Date_Deleted`  " +
                "FROM `product_perfume` AS `p`  " +
                "INNER JOIN `supplier` AS `s` ON `p`.`Supplier_ID` = `s`.`Supplier_ID`  " +
                "INNER JOIN `product_perfume_category` AS `pc` ON `p`.`Perfume_Category_Code` = `pc`.`Perfume_Category_Code`  " +
                "WHERE `p`.`Date_Deleted` IS NOT NULL AND `p`.`Product_ID` = @productID", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Perfume perfume = new Perfume();
            foreach (DataRow item in dt.Rows)
            {
                perfume.setProductID(item["Product_ID"].ToString());
                perfume.setProductName(item["Product_Name_" + langCode].ToString());
                perfume.setProductNameEnUs(item["Product_Name_en-US"].ToString());
                perfume.setProductNameZhHant(item["Product_Name_zh-Hant"].ToString());
                perfume.setDescription(item["Description_" + langCode].ToString());
                perfume.setDescriptionEnUs(item["Description_en-US"].ToString());
                perfume.setDescriptionZhHant(item["Description_zh-Hant"].ToString());
                perfume.setPhoto(ImageConverter.byteArrayToImage((byte[])item["Photo"]));
                perfume.setSupplierID(item["Supplier_ID"].ToString());
                perfume.setSupplierName(item["Supplier_Name"].ToString());
                perfume.setQtyInStock((int)item["Qty_In_Stock"]);
                perfume.setPrice((int)item["Price"]);
                perfume.setCategoryCode(item["Perfume_Category_Code"].ToString());
                perfume.setCategory(item["Category_Name_" + langCode].ToString());
                perfume.setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
                perfume.setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return perfume;
        }

        public int insert(Perfume perfume, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `product_perfume`(`Product_ID`, `Product_Name_en-US`, `Product_Name_zh-Hant`, `Description_en-US`, `Description_zh-Hant`, `Photo`, `Supplier_ID`, `Perfume_Category_Code`, `Qty_In_Stock`, `Price`, `Release_Date`) " +
                "VALUES (@productID,@productNameEnUs,@productNameZhHant,@descriptionEnUs,@descriptionZhHant,@photo,@supplierID,@categoryCode,@qtyInStock,@price,@releaseDate)", conn);
            cmd.Parameters.AddWithValue("@productID", perfume.getProductID());
            cmd.Parameters.AddWithValue("@productNameEnUs", perfume.getProductNameEnUs());
            cmd.Parameters.AddWithValue("@productNameZhHant", perfume.getProductNameZhHant());
            cmd.Parameters.AddWithValue("@descriptionEnUs", perfume.getDescriptionEnUs());
            cmd.Parameters.AddWithValue("@descriptionZhHant", perfume.getDescriptionZhHant());
            cmd.Parameters.AddWithValue("@photo", ImageConverter.imageToByteArray(perfume.getPhoto()));
            cmd.Parameters.AddWithValue("@supplierID", perfume.getSupplierID());
            cmd.Parameters.AddWithValue("@qtyInStock", perfume.getQtyInStock());
            cmd.Parameters.AddWithValue("@price", perfume.getPrice());
            cmd.Parameters.AddWithValue("@categoryCode", perfume.getCategoryCode());
            cmd.Parameters.AddWithValue("@releaseDate", perfume.getReleaseDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int update(Perfume perfume, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `product_perfume` SET `Product_Name_en-US`=@productNameEnUs,`Product_Name_zh-Hant`=@productNameZhHant,`Description_en-US`=@descriptionEnUs,`Description_zh-Hant`=@descriptionZhHant,`Photo`=@photo,`Supplier_ID`=@supplierID,`Perfume_Category_Code`=@categoryCode,`Qty_In_Stock`=@qtyInStock,`Price`=@price,`Release_Date`=@releaseDate WHERE `Product_ID`=@productID", conn);
            cmd.Parameters.AddWithValue("@productID", perfume.getProductID());
            cmd.Parameters.AddWithValue("@productNameEnUs", perfume.getProductNameEnUs());
            cmd.Parameters.AddWithValue("@productNameZhHant", perfume.getProductNameZhHant());
            cmd.Parameters.AddWithValue("@descriptionEnUs", perfume.getDescriptionEnUs());
            cmd.Parameters.AddWithValue("@descriptionZhHant", perfume.getDescriptionZhHant());
            cmd.Parameters.AddWithValue("@photo", ImageConverter.imageToByteArray(perfume.getPhoto()));
            cmd.Parameters.AddWithValue("@supplierID", perfume.getSupplierID());
            cmd.Parameters.AddWithValue("@qtyInStock", perfume.getQtyInStock());
            cmd.Parameters.AddWithValue("@price", perfume.getPrice());
            cmd.Parameters.AddWithValue("@categoryCode", perfume.getCategoryCode());
            cmd.Parameters.AddWithValue("@releaseDate", perfume.getReleaseDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int delete(string productID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `product_perfume` SET `Date_Deleted` = NOW() WHERE `Product_ID` = @productID", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int undelete(string productID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `product_perfume` SET `Date_Deleted` = NULL WHERE `Product_ID` = @productID", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int permanentlyDelete(string productID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `product_perfume` WHERE `Product_ID` = @productID", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}