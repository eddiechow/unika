using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace BackendClassLibrary.DataAccess
{
    using Data;
    using System;

    public class OrderLineDA
    {
        public OrderLine getPackageOrderLine(string orderID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `package_order_line`.`Order_ID`, `package_order_line`.`Product_ID`, `product_package`.`Product_Name_en-US`, `product_package`.`Product_Name_zh-Hant`, `package_order_line`.`Unit_Price`, `package_order_line`.`Discount` FROM `package_order_line`,  `product_package` WHERE `package_order_line`.`Order_ID`=@OrderID AND `package_order_line`.`Product_ID`= `product_package`.`Product_ID`", conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            OrderLine ol = new OrderLine();
            foreach (DataRow item in dt.Rows)
            {
                ol.setOrderID((uint)item["Order_ID"]);
                ol.setProductID(item["Product_ID"].ToString());
                ol.setProductName(item["Product_Name_" + langCode].ToString());
                ol.setUnitPrice((int)item["Unit_Price"]);
                if (!Convert.IsDBNull(item["Discount"])) ol.setDiscount((int)item["Discount"]);
                else ol.setDiscount(null);
            }
            conn.Close();
            return ol;
        }

        public int insertPackageOrderLine(OrderLine orderLine, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `package_order_line`(`Order_ID`, `Product_ID`, `Unit_Price`, `Discount`) VALUES (@orderID,@productID,@unitPrice,@discount)", conn);
            cmd.Parameters.AddWithValue("@orderID", orderLine.getOrderID());
            cmd.Parameters.AddWithValue("@productID", orderLine.getProductID());
            cmd.Parameters.AddWithValue("@unitPrice", orderLine.getUnitPrice());
            cmd.Parameters.AddWithValue("@discount", orderLine.getDiscount());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public OrderLine getBottleOrderLine(string orderID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `bottle_order_line`.`Order_ID`, `bottle_order_line`.`Product_ID`, `product_bottle`.`Product_Name_en-US`, `product_bottle`.`Product_Name_zh-Hant`, `product_bottle`.`Bottle_Capacity`, `bottle_order_line`.`Unit_Price`, `bottle_order_line`.`Discount` FROM `bottle_order_line`, `product_bottle` WHERE `bottle_order_line`.`Order_ID`=@OrderID AND `bottle_order_line`.`Product_ID`=`product_bottle`.`Product_ID`", conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            OrderLine ol = new OrderLine();
            foreach (DataRow item in dt.Rows)
            {
                ol.setOrderID((uint)item["Order_ID"]);
                ol.setProductID(item["Product_ID"].ToString());
                ol.setProductName(item["Product_Name_" + langCode].ToString());
                ol.setUnitPrice((int)item["Unit_Price"]);
                ol.setBottleCapacity((int)item["Bottle_Capacity"]);
                if (!Convert.IsDBNull(item["Discount"])) ol.setDiscount((int)item["Discount"]);
                else ol.setDiscount(null);
            }
            conn.Close();
            return ol;
        }

        public int insertBottleOrderLine(OrderLine orderLine, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `bottle_order_line`(`Order_ID`, `Product_ID`, `Unit_Price`, `Discount`) VALUES (@orderID,@productID,@unitPrice,@discount)", conn);
            cmd.Parameters.AddWithValue("@orderID", orderLine.getOrderID());
            cmd.Parameters.AddWithValue("@productID", orderLine.getProductID());
            cmd.Parameters.AddWithValue("@unitPrice", orderLine.getUnitPrice());
            cmd.Parameters.AddWithValue("@discount", orderLine.getDiscount());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public List<OrderLine> getPerfumeOrderLine(string orderID, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `perfume_order_line`.`Order_ID`, `perfume_order_line`.`Product_ID`, `product_perfume`.`Product_Name_en-US`, `product_perfume`.`Product_Name_zh-Hant`, `perfume_order_line`.`Unit_Price`, `perfume_order_line`.`Discount`, `perfume_order_line`.`Qty`, `perfume_order_line`.`Note` FROM `perfume_order_line`, `product_perfume` WHERE `perfume_order_line`.`Order_ID`=@orderID AND `perfume_order_line`.`Product_ID`=`product_perfume`.`Product_ID`", conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<OrderLine> list = new List<OrderLine>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new OrderLine());
                list.Last().setOrderID((uint)item["Order_ID"]);
                list.Last().setProductID(item["Product_ID"].ToString());
                list.Last().setProductName(item["Product_Name_" + langCode].ToString());
                list.Last().setUnitPrice((int)item["Unit_Price"]);
                if (!Convert.IsDBNull(item["Discount"])) list.Last().setDiscount((int)item["Discount"]);
                else list.Last().setDiscount(null);
                list.Last().setQty((int)item["Qty"]);
                list.Last().setNote(item["Note"].ToString());
            }
            conn.Close();
            return list;
        }

        public int insertPerfumeOrderLine(OrderLine orderLine, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `perfume_order_line`(`Order_ID`, `Product_ID`, `Unit_Price`, `Discount`, `Qty`, `Note`) VALUES (@orderID,@productID,@unitPrice,@discount,@qty,@note)", conn);
            cmd.Parameters.AddWithValue("@orderID", orderLine.getOrderID());
            cmd.Parameters.AddWithValue("@productID", orderLine.getProductID());
            cmd.Parameters.AddWithValue("@unitPrice", orderLine.getUnitPrice());
            cmd.Parameters.AddWithValue("@discount", orderLine.getDiscount());
            cmd.Parameters.AddWithValue("@qty", orderLine.getQty());
            cmd.Parameters.AddWithValue("@note", orderLine.getNote());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
