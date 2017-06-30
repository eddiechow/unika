using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class ProductBottleDiscountDA
    {
        public List<ProductDiscount> getOneProductDiscountByCode(string discountCode, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_bottle_discount`.`Product_ID`, `product_bottle_discount`.`Discount_Code`, `product_bottle`.`Product_Name_en-US`, `product_bottle`.`Product_Name_zh-Hant`, `product_bottle`.`Price` FROM `product_bottle_discount`, `product_bottle` WHERE `product_bottle_discount`.`Product_ID`=`product_bottle`.`Product_ID` AND `Discount_Code`=@discountCode", conn);
            cmd.Parameters.AddWithValue("@discountCode", discountCode);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<ProductDiscount> list = new List<ProductDiscount>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new ProductDiscount());
                list.Last().setDiscountCode(item["Discount_Code"].ToString());
                list.Last().setProductID(item["Product_ID"].ToString());
                list.Last().setProductName(item["Product_Name_" + langCode].ToString());
                list.Last().setProductPrice((int)item["Price"]);
            }
            conn.Close();
            return list;
        }

        public int insert(ProductDiscount pd, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `product_bottle_discount`(`Product_ID`, `Discount_Code`) VALUES (@productID,@dicountCode)", conn);
            cmd.Parameters.AddWithValue("@productID", pd.getProductID());
            cmd.Parameters.AddWithValue("@dicountCode", pd.getDiscountCode());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }


        public int permanentlyDelete(ProductDiscount pd, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `product_bottle_discount` WHERE `Product_ID` = @productID AND `Discount_Code`=@dicountCode", conn);
            cmd.Parameters.AddWithValue("@productID", pd.getProductID());
            cmd.Parameters.AddWithValue("@dicountCode", pd.getDiscountCode());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
