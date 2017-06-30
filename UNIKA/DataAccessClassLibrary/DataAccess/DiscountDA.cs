using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class DiscountDA
    {
        public List<Discount> getAllDiscount(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `Discount_Code`, `Discount`, `Start_Date`, `End_Date`, `Title_en-US`, `Title_zh-Hant` FROM `discount` WHERE `Date_Deleted` IS NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Discount> list = new List<Discount>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Discount());
                list.Last().setDiscountCode(item["Discount_Code"].ToString());
                list.Last().setDiscount((int)item["Discount"]);
                list.Last().setTitle(item["Title_" + langCode].ToString());
                list.Last().setTitleEnUs(item["Title_en-US"].ToString());
                list.Last().setTitleZhHant(item["Title_zh-Hant"].ToString());
                list.Last().setStartDate(Convert.ToDateTime(item["Start_Date"]));
                list.Last().setEndDate(Convert.ToDateTime(item["End_Date"]));
            }
            conn.Close();
            return list;
        }

        public List<Discount> getAllDeletedDiscount(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `Discount_Code`, `Discount`, `Start_Date`, `End_Date`, `Title_en-US`, `Title_zh-Hant`, `Date_Deleted` FROM `discount` WHERE `Date_Deleted` IS NOT NULL`", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Discount> list = new List<Discount>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Discount());
                list.Last().setDiscountCode(item["Discount_Code"].ToString());
                list.Last().setDiscount((int)item["Discount"]);
                list.Last().setTitle(item["Title_" + langCode].ToString());
                list.Last().setTitleEnUs(item["Title_en-US"].ToString());
                list.Last().setTitleZhHant(item["Title_zh-Hant"].ToString());
                list.Last().setStartDate(Convert.ToDateTime(item["Start_Date"]));
                list.Last().setEndDate(Convert.ToDateTime(item["End_Date"]));
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public Discount getOneDiscountByCode(string discountCode, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `Discount_Code`, `Discount`, `Start_Date`, `End_Date`, `Title_en-US`, `Title_zh-Hant` FROM `discount` WHERE `Date_Deleted` IS NULL AND `Discount_Code`=@discountCode", conn);
            cmd.Parameters.AddWithValue("@discountCode", discountCode);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Discount discount = new Discount();
            foreach (DataRow item in dt.Rows)
            {
                discount.setDiscountCode(item["Discount_Code"].ToString());
                discount.setDiscount((int)item["Discount"]);
                discount.setTitle(item["Title_" + langCode].ToString());
                discount.setTitleEnUs(item["Title_en-US"].ToString());
                discount.setTitleZhHant(item["Title_zh-Hant"].ToString());
                discount.setStartDate(Convert.ToDateTime(item["Start_Date"]));
                discount.setEndDate(Convert.ToDateTime(item["End_Date"]));
            }
            conn.Close();
            return discount;
        }

        public Discount getOneDeletedDiscountByCode(string discountCode, string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `Discount_Code`, `Discount`, `Start_Date`, `End_Date`, ``Title_en-US`, `Title_zh-Hant`, `Date_Deleted` FROM `discount` WHERE `Date_Deleted` IS NOT NULL AND `Discount_Code`=@discountCode", conn);
            cmd.Parameters.AddWithValue("@discountCode", discountCode);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Discount discount = new Discount();
            foreach (DataRow item in dt.Rows)
            {
                discount.setDiscountCode(item["Discount_Code"].ToString());
                discount.setDiscount((int)item["Discount"]);
                discount.setTitle(item["Title_" + langCode].ToString());
                discount.setTitleEnUs(item["Title_en-US"].ToString());
                discount.setTitleZhHant(item["Title_zh-Hant"].ToString());
                discount.setStartDate(Convert.ToDateTime(item["Start_Date"]));
                discount.setEndDate(Convert.ToDateTime(item["End_Date"]));
                discount.setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return discount;
        }

        public int insert(Discount discount, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `discount`(`Discount_Code`, `Discount`, `Start_Date`, `End_Date`, `Title_en-US`, `Title_zh-Hant`) VALUES (@dicountCode,@dicount,@startDate,@endDate,@title_EnUs,@title_ZhHant)", conn);
            cmd.Parameters.AddWithValue("@dicountCode", discount.getDiscountCode());
            cmd.Parameters.AddWithValue("@dicount", discount.getDiscount());
            cmd.Parameters.AddWithValue("@startDate", discount.getStartDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@endDate", discount.getEndDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@title_EnUs", discount.getTitleEnUs());
            cmd.Parameters.AddWithValue("@title_ZhHant", discount.getTitleZhHant());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int update(Discount discount, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `discount` SET `Discount`=@dicount,`Start_Date`=@startDate,`End_Date`=@endDate,`Title_en-US`=@title_EnUs,`Title_zh-Hant`=@title_ZhHant WHERE `Discount_Code`=@dicountCode", conn);
            cmd.Parameters.AddWithValue("@dicountCode", discount.getDiscountCode());
            cmd.Parameters.AddWithValue("@dicount", discount.getDiscount());
            cmd.Parameters.AddWithValue("@startDate", discount.getStartDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@endDate", discount.getEndDate().ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@title_EnUs", discount.getTitleEnUs());
            cmd.Parameters.AddWithValue("@title_ZhHant", discount.getTitleZhHant());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int delete(string discountCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `discount` SET `Date_Deleted` = NOW() WHERE `Discount_Code` = @dicountCode", conn);
            cmd.Parameters.AddWithValue("@dicountCode", discountCode);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int undelete(string discountCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `discount` SET `Date_Deleted` = NULL WHERE `Discount_Code` = @dicountCode", conn);
            cmd.Parameters.AddWithValue("@dicountCode", discountCode);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int permanentlyDelete(string discountCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `discount` WHERE `Discount_Code` = @dicountCode", conn);
            cmd.Parameters.AddWithValue("@dicountCode", discountCode);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
