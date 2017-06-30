using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class NoticeDA
    {
        public List<Notice> getAllNotice(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `notice`.`Notice_ID`, `notice`.`Content_en-US`, `notice`.`Content_zh-Hant`, `notice`.`Released_By`, `employee`.`Employee_Surname`, `employee`.`Employee_GivenName` FROM `notice`, `employee` WHERE `notice`.`Released_By`=`employee`.`Employee_ID` AND `notice`.`Date_Deleted` IS NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Notice> list = new List<Notice>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Notice());
                list.Last().setNoticeID((int)item["Notice_ID"]);
                list.Last().setContent(item["Content_"+langCode].ToString());
                list.Last().setContentEnUs(item["Content_en-US"].ToString());
                list.Last().setContentZhHant(item["Content_zh-Hant"].ToString());
                list.Last().setReleasedByEmpID(item["Released_By"].ToString());
                list.Last().setReleasedBy(item["Employee_Surname"].ToString()+", "+ item["Employee_GivenName"].ToString());
            }
            conn.Close();
            return list;
        }

        public List<Notice> getAllDeletedNotice(string langCode, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `notice`.`Notice_ID`, `notice`.`Content_en-US`, `notice`.`Content_zh-Hant`, `notice`.`Released_By`, `notice`.`Date_Deleted`, `employee`.`Employee_Surname`, `employee`.`Employee_GivenName` FROM `notice`, `employee` WHERE `notice`.`Released_By`=`employee`.`Employee_ID` AND `notice`.`Date_Deleted` IS NOT NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Notice> list = new List<Notice>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Notice());
                list.Last().setNoticeID((int)item["Notice_ID"]);
                list.Last().setContent(item["Content_" + langCode].ToString());
                list.Last().setContentEnUs(item["Content_en-US"].ToString());
                list.Last().setContentZhHant(item["Content_zh-Hant"].ToString());
                list.Last().setReleasedByEmpID(item["Released_By"].ToString());
                list.Last().setReleasedBy(item["Employee_Surname"].ToString() + ", " + item["Employee_GivenName"].ToString());
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public Notice getOneNoticeByID(string langCode, int noticeID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `notice`.`Notice_ID`, `notice`.`Content_en-US`, `notice`.`Content_zh-Hant`, `notice`.`Released_By`, `employee`.`Employee_Surname`, `employee`.`Employee_GivenName` FROM `notice`, `employee` WHERE `notice`.`Released_By`=`employee`.`Employee_ID` AND `notice`.`Date_Deleted` IS NULL AND `notice`.`Notice_ID`=@noticeID", conn);
            cmd.Parameters.AddWithValue("@noticeID", noticeID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Notice notice = new Notice();
            foreach (DataRow item in dt.Rows)
            {
                notice.setNoticeID((int)item["Notice_ID"]);
                notice.setContent(item["Content_" + langCode].ToString());
                notice.setContentEnUs(item["Content_en-US"].ToString());
                notice.setContentZhHant(item["Content_zh-Hant"].ToString());
                notice.setReleasedByEmpID(item["Released_By"].ToString());
                notice.setReleasedBy(item["Employee_Surname"].ToString() + ", " + item["Employee_GivenName"].ToString());
            }
            conn.Close();
            return notice;
        }

        public Notice getOneDeletedNoticeByID(string langCode, int noticeID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `notice`.`Notice_ID`, `notice`.`Content_en-US`, `notice`.`Content_zh-Hant`, `notice`.`Released_By`, `notice`.`Date_Deleted`, `employee`.`Employee_Surname`, `employee`.`Employee_GivenName` FROM `notice`, `employee` WHERE `notice`.`Released_By`=`employee`.`Employee_ID` AND `notice`.`Date_Deleted` IS NOT NULL AND `notice`.`Notice_ID`=@noticeID", conn);
            cmd.Parameters.AddWithValue("@noticeID", noticeID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Notice notice = new Notice();
            foreach (DataRow item in dt.Rows)
            {
                notice.setNoticeID((int)item["Notice_ID"]);
                notice.setContent(item["Content_" + langCode].ToString());
                notice.setContentEnUs(item["Content_en-US"].ToString());
                notice.setContentZhHant(item["Content_zh-Hant"].ToString());
                notice.setReleasedByEmpID(item["Released_By"].ToString());
                notice.setReleasedBy(item["Employee_Surname"].ToString() + ", " + item["Employee_GivenName"].ToString());
                notice.setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return notice;
        }

        public int insert(Notice notice, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `notice`(`Content_en-US`, `Content_zh-Hant`, `Released_By`) VALUES (@contentEnUs,@contentZhHant,@releasedBy)", conn);
            cmd.Parameters.AddWithValue("@contentEnUs", notice.getContentEnUs());
            cmd.Parameters.AddWithValue("@contentZhHant", notice.getContentZhHant());
            cmd.Parameters.AddWithValue("@releasedBy", notice.getReleasedByEmpID());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            notice.setNoticeID(Convert.ToInt32(cmd.LastInsertedId));
            conn.Close();
            return i;
        }

        public int update(Notice notice, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `notice` SET `Content_en-US`=@contentEnUs,`Content_zh-Hant`=@contentZhHant,`Released_By`=@releasedBy WHERE `Notice_ID`=@noticeID", conn);
            cmd.Parameters.AddWithValue("@noticeID", notice.getNoticeID());
            cmd.Parameters.AddWithValue("@contentEnUs", notice.getContentEnUs());
            cmd.Parameters.AddWithValue("@contentZhHant", notice.getContentZhHant());
            cmd.Parameters.AddWithValue("@releasedBy", notice.getReleasedByEmpID());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int delete(int noticeID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `notice` SET `Date_Deleted` = NOW() WHERE `Notice_ID`=@noticeID", conn);
            cmd.Parameters.AddWithValue("@noticeID", noticeID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int undelete(int noticeID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `notice` SET `Date_Deleted` = NULL WHERE `Notice_ID`=@noticeID", conn);
            cmd.Parameters.AddWithValue("@noticeID", noticeID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int permanentlyDelete(int noticeID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `notice` WHERE `Notice_ID`=@noticeID", conn);
            cmd.Parameters.AddWithValue("@noticeID", noticeID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
