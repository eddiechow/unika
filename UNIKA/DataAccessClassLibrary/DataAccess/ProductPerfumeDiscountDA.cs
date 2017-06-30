using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class ProductPerfumeDiscountDA
    {
        public List<ProductDiscount> getOneProductDiscountByCode(string discountCode, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `product_perfume_discount`.`Product_ID`, `product_perfume_discount`.`Discount_Code`, `product_perfume`.`Product_Name_" + langCode + "`, `product_perfume_category`.`Category_Name_"+ langCode + "`, `product_perfume`.`Price` FROM `product_perfume_discount`, `product_perfume` " +
                "INNER JOIN `product_perfume_category` ON `product_perfume`.`Perfume_Category_Code` = `product_perfume_category`.`Perfume_Category_Code` " +
                "WHERE `product_perfume_discount`.`Product_ID`=`product_perfume`.`Product_ID` AND `Discount_Code`=@discountCode", conn);
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
                list.Last().setPerfumeCategory(item["Category_Name_" + langCode].ToString());
                list.Last().setProductPrice((int)item["Price"]);
            }
            conn.Close();
            return list;
        }

        public int insert(ProductDiscount pd, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `product_perfume_discount`(`Product_ID`, `Discount_Code`) VALUES (@productID,@dicountCode)", conn);
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
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `product_perfume_discount` WHERE `Product_ID` = @productID AND `Discount_Code`=@dicountCode", conn);
            cmd.Parameters.AddWithValue("@productID", pd.getProductID());
            cmd.Parameters.AddWithValue("@dicountCode", pd.getDiscountCode());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
