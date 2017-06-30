using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class ProductBottleDA
    {
        public List<Bottle> getAllProductBottles(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_bottle`.`Product_ID`, " +
                "`product_bottle`.`Product_Name_en-US`, " +
                "`product_bottle`.`Product_Name_zh-Hant`, " +
                "`product_bottle`.`Description_en-US`, " +
                "`product_bottle`.`Description_zh-Hant`, " +
                "`product_bottle`.`Supplier_ID`, " +
                "`supplier`.`Supplier_Name`, " +
                "`product_bottle`.`Qty_In_Stock`, " +
                "`product_bottle`.`Price`, " +
                "`product_bottle`.`Bottle_Capacity`, " +
                "`product_bottle`.`Release_Date`" +
                "FROM `product_bottle`, `supplier` WHERE `product_bottle`.`Date_Deleted` IS NULL AND `product_bottle`.`Supplier_ID` = `supplier`.`Supplier_ID`", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Bottle> list = new List<Bottle>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Bottle());
                list.Last().setProductID(item["Product_ID"].ToString());
                list.Last().setProductName(item["Product_Name_"+ langCode].ToString());
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
                list.Last().setBottleCapacity((int)item["Bottle_Capacity"]);
                list.Last().setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
            }
            conn.Close();
            return list;
        }

        public List<Bottle> getAllDeletedProductBottles(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_bottle`.`Product_ID`, " +
                "`product_bottle`.`Product_Name_en-US`, " +
                "`product_bottle`.`Product_Name_zh-Hant`, " +
                "`product_bottle`.`Description_en-US`, " +
                "`product_bottle`.`Description_zh-Hant`, " +
                "`product_bottle`.`Supplier_ID`, " +
                "`supplier`.`Supplier_Name`, " +
                "`product_bottle`.`Qty_In_Stock`, " +
                "`product_bottle`.`Price`, " +
                "`product_bottle`.`Bottle_Capacity`, " +
                "`product_bottle`.`Release_Date`, " +
                "`product_bottle`.`Date_Deleted`" +
                "FROM `product_bottle`, `supplier` WHERE `product_bottle`.`Date_Deleted` IS NOT NULL AND `product_bottle`.`Supplier_ID` = `supplier`.`Supplier_ID`", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Bottle> list = new List<Bottle>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Bottle());
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
                list.Last().setBottleCapacity((int)item["Bottle_Capacity"]);
                list.Last().setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public List<Bottle> findProductBottlesBySupplierID(string supplierID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_bottle`.`Product_ID`, " +
                "`product_bottle`.`Product_Name_en-US`, " +
                "`product_bottle`.`Product_Name_zh-Hant`, " +
                "`product_bottle`.`Description_en-US`, " +
                "`product_bottle`.`Description_zh-Hant`, " +
                "`product_bottle`.`Supplier_ID`, " +
                "`supplier`.`Supplier_Name`, " +
                "`product_bottle`.`Qty_In_Stock`, " +
                "`product_bottle`.`Price`, " +
                "`product_bottle`.`Bottle_Capacity`, " +
                "`product_bottle`.`Release_Date`" +
                "FROM `product_bottle`, `supplier` WHERE `product_bottle`.`Supplier_ID` = @supplierID AND `product_bottle`.`Date_Deleted` IS NULL AND `product_bottle`.`Supplier_ID` = `supplier`.`Supplier_ID`", conn);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Bottle> list = new List<Bottle>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Bottle());
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
                list.Last().setBottleCapacity((int)item["Bottle_Capacity"]);
                list.Last().setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
            }
            conn.Close();
            return list;
        }

        public List<Bottle> findDeletedProductBottlesBySupplierID(string supplierID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_bottle`.`Product_ID`, " +
                "`product_bottle`.`Product_Name_en-US`, " +
                "`product_bottle`.`Product_Name_zh-Hant`, " +
                "`product_bottle`.`Description_en-US`, " +
                "`product_bottle`.`Description_zh-Hant`, " +
                "`product_bottle`.`Supplier_ID`, " +
                "`supplier`.`Supplier_Name`, " +
                "`product_bottle`.`Qty_In_Stock`, " +
                "`product_bottle`.`Price`, " +
                "`product_bottle`.`Bottle_Capacity`, " +
                "`product_bottle`.`Release_Date`, " +
                "`product_bottle`.`Date_Deleted`" +
                "FROM `product_bottle`, `supplier` WHERE `product_bottle`.`Supplier_ID` = @supplierID AND `product_bottle`.`Date_Deleted` IS NOT NULL AND `product_bottle`.`Supplier_ID` = `supplier`.`Supplier_ID`", conn);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Bottle> list = new List<Bottle>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Bottle());
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
                list.Last().setBottleCapacity((int)item["Bottle_Capacity"]);
                list.Last().setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public Bottle getOneProductBottleByID(string productID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_bottle`.`Product_ID`, " +
                "`product_bottle`.`Product_Name_en-US`, " +
                "`product_bottle`.`Product_Name_zh-Hant`, " +
                "`product_bottle`.`Description_en-US`, " +
                "`product_bottle`.`Description_zh-Hant`, " +
                "`product_bottle`.`Photo`, " +
                "`product_bottle`.`Supplier_ID`, " +
                "`supplier`.`Supplier_Name`, " +
                "`product_bottle`.`Qty_In_Stock`, " +
                "`product_bottle`.`Price`, " +
                "`product_bottle`.`Bottle_Capacity`, " +
                "`product_bottle`.`Release_Date`" +
                "FROM `product_bottle`, `supplier` WHERE `product_bottle`.`Date_Deleted` IS NULL AND `product_bottle`.`Product_ID` = @productID AND `product_bottle`.`Supplier_ID` = `supplier`.`Supplier_ID`", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Bottle bottle = new Bottle();
            foreach (DataRow item in dt.Rows)
            {
                bottle.setProductID(item["Product_ID"].ToString());
                bottle.setProductName(item["Product_Name_" + langCode].ToString());
                bottle.setProductNameEnUs(item["Product_Name_en-US"].ToString());
                bottle.setProductNameZhHant(item["Product_Name_zh-Hant"].ToString());
                bottle.setDescription(item["Description_" + langCode].ToString());
                bottle.setDescriptionEnUs(item["Description_en-US"].ToString());
                bottle.setDescriptionZhHant(item["Description_zh-Hant"].ToString());
                bottle.setPhoto(ImageConverter.byteArrayToImage((byte[])item["Photo"]));
                bottle.setSupplierID(item["Supplier_ID"].ToString());
                bottle.setSupplierName(item["Supplier_Name"].ToString());
                bottle.setQtyInStock((int)item["Qty_In_Stock"]);
                bottle.setPrice((int)item["Price"]);
                bottle.setBottleCapacity((int)item["Bottle_Capacity"]);
                bottle.setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
            }
            conn.Close();
            return bottle;
        }

        public Bottle getOneDeletedBottleByID(string productID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_bottle`.`Product_ID`, " +
                "`product_bottle`.`Product_Name_en-US`, " +
                "`product_bottle`.`Product_Name_zh-Hant`, " +
                "`product_bottle`.`Description_en-US`, " +
                "`product_bottle`.`Description_zh-Hant`, " +
                "`product_bottle`.`Photo`, " +
                "`product_bottle`.`Supplier_ID`, " +
                "`supplier`.`Supplier_Name`, " +
                "`product_bottle`.`Qty_In_Stock`, " +
                "`product_bottle`.`Price`, " +
                "`product_bottle`.`Bottle_Capacity`, " +
                "`product_bottle`.`Release_Date`, " +
                "`product_bottle`.`Date_Deleted`" +
                "FROM `product_bottle`, `supplier` WHERE `product_bottle`.`Date_Deleted` IS NOT NULL AND `product_bottle`.`Product_ID` = @productID AND `product_bottle`.`Supplier_ID` = `supplier`.`Supplier_ID`", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Bottle bottle = new Bottle();
            foreach (DataRow item in dt.Rows)
            {
                bottle.setProductID(item["Product_ID"].ToString());
                bottle.setProductName(item["Product_Name_" + langCode].ToString());
                bottle.setProductNameEnUs(item["Product_Name_en-US"].ToString());
                bottle.setProductNameZhHant(item["Product_Name_zh-Hant"].ToString());
                bottle.setDescription(item["Description_" + langCode].ToString());
                bottle.setDescriptionEnUs(item["Description_en-US"].ToString());
                bottle.setDescriptionZhHant(item["Description_zh-Hant"].ToString());
                bottle.setPhoto(ImageConverter.byteArrayToImage((byte[])item["Photo"]));
                bottle.setSupplierID(item["Supplier_ID"].ToString());
                bottle.setSupplierName(item["Supplier_Name"].ToString());
                bottle.setQtyInStock((int)item["Qty_In_Stock"]);
                bottle.setPrice((int)item["Price"]);
                bottle.setBottleCapacity((int)item["Bottle_Capacity"]);
                bottle.setReleaseDate(Convert.ToDateTime(item["Release_Date"]));
                bottle.setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return bottle;
        }

        public int insert(Bottle bottle, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `product_bottle`(`Product_ID`, `Product_Name_en-US`, `Product_Name_zh-Hant`, `Description_en-US`, `Description_zh-Hant`, `Photo`, `Supplier_ID`, `Qty_In_Stock`, `Price`, `Bottle_Capacity`, `Release_Date`) " +
                "VALUES (@productID,@productNameEnUs,@productNameZhHant,@descriptionEnUs,@descriptionZhHant,@photo,@supplierID,@qtyInStock,@price,@bottleCapacity,@releaseDate)", conn);
            cmd.Parameters.AddWithValue("@productID", bottle.getProductID());
            cmd.Parameters.AddWithValue("@productNameEnUs", bottle.getProductNameEnUs());
            cmd.Parameters.AddWithValue("@productNameZhHant", bottle.getProductNameZhHant());
            cmd.Parameters.AddWithValue("@descriptionEnUs", bottle.getDescriptionEnUs());
            cmd.Parameters.AddWithValue("@descriptionZhHant", bottle.getDescriptionZhHant());
            cmd.Parameters.AddWithValue("@photo", ImageConverter.imageToByteArray(bottle.getPhoto()));
            cmd.Parameters.AddWithValue("@supplierID", bottle.getSupplierID());
            cmd.Parameters.AddWithValue("@qtyInStock", bottle.getQtyInStock());
            cmd.Parameters.AddWithValue("@price", bottle.getPrice());
            cmd.Parameters.AddWithValue("@bottleCapacity", bottle.getBottleCapacity());
            cmd.Parameters.AddWithValue("@releaseDate", bottle.getReleaseDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int update(Bottle bottle, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `product_bottle` SET `Product_Name_en-US`=@productNameEnUs,`Product_Name_zh-Hant`=@productNameZhHant,`Description_en-US`=@descriptionEnUs,`Description_zh-Hant`=@descriptionZhHant,`Photo`=@photo,`Supplier_ID`=@supplierID,`Qty_In_Stock`=@qtyInStock,`Price`=@price,`Bottle_Capacity`=@bottleCapacity,`Release_Date`=@releaseDate WHERE `Product_ID`=@productID", conn);
            cmd.Parameters.AddWithValue("@productID", bottle.getProductID());
            cmd.Parameters.AddWithValue("@productNameEnUs", bottle.getProductNameEnUs());
            cmd.Parameters.AddWithValue("@productNameZhHant", bottle.getProductNameZhHant());
            cmd.Parameters.AddWithValue("@descriptionEnUs", bottle.getDescriptionEnUs());
            cmd.Parameters.AddWithValue("@descriptionZhHant", bottle.getDescriptionZhHant());
            cmd.Parameters.AddWithValue("@photo", ImageConverter.imageToByteArray(bottle.getPhoto()));
            cmd.Parameters.AddWithValue("@supplierID", bottle.getSupplierID());
            cmd.Parameters.AddWithValue("@qtyInStock", bottle.getQtyInStock());
            cmd.Parameters.AddWithValue("@price", bottle.getPrice());
            cmd.Parameters.AddWithValue("@bottleCapacity", bottle.getBottleCapacity());
            cmd.Parameters.AddWithValue("@releaseDate", bottle.getReleaseDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int delete(string productID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `product_bottle` SET `Date_Deleted` = NOW() WHERE `Product_ID` = @productID", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int undelete(string productID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `product_bottle` SET `Date_Deleted` = NULL WHERE `Product_ID` = @productID", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int permanentlyDelete(string productID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `product_bottle` WHERE `Product_ID` = @productID", conn);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

    }
}
