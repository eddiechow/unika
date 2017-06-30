using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;

namespace BackendClassLibrary.DataAccess
{
    using Data;

    public class EmployeeDA
    {
        public List<Employee> getAllEmployees(MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `employee` WHERE `Date_Deleted` IS NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Employee> list = new List<Employee>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Employee());
                list.Last().setEmployeeID(item["Employee_ID"].ToString());
                list.Last().setEmployeeSurname(item["Employee_Surname"].ToString());
                list.Last().setEmployeeGivenName(item["Employee_GivenName"].ToString());
                list.Last().setPosition(item["Position"].ToString());
                list.Last().setEmail(item["Email"].ToString());
            }
            conn.Close();
            return list;
        }

        public List<Employee> getAllDeletedEmployees(MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `employee` WHERE `Date_Deleted` IS NOT NULL", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Employee> list = new List<Employee>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Employee());
                list.Last().setEmployeeID(item["Employee_ID"].ToString());
                list.Last().setEmployeeSurname(item["Employee_Surname"].ToString());
                list.Last().setEmployeeGivenName(item["Employee_GivenName"].ToString());
                list.Last().setPosition(item["Position"].ToString());
                list.Last().setEmail(item["Email"].ToString());
                list.Last().setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return list;
        }

        public Employee getOneEmployeeByID(string employeeID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `employee` WHERE `Employee_ID` = @employeeID  AND `Date_Deleted` IS NULL", conn);
            cmd.Parameters.AddWithValue("@employeeID", employeeID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Employee employee = new Employee();
            foreach (DataRow item in dt.Rows)
            {
                employee.setEmployeeID(item["Employee_ID"].ToString());
                employee.setEmployeeSurname(item["Employee_Surname"].ToString());
                employee.setEmployeeGivenName(item["Employee_GivenName"].ToString());
                employee.setPassword(item["Password"].ToString());
                employee.setPosition(item["Position"].ToString());
                employee.setEmail(item["Email"].ToString());
            }
            conn.Close();
            return employee;

        }

        public Employee getOneDeletedEmployeeByID(string employeeID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `employee` WHERE `Employee_ID` = @employeeID  AND`Date_Deleted` IS NOT NULL", conn);
            cmd.Parameters.AddWithValue("@employeeID", employeeID);
            cmd.Prepare();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Employee employee = new Employee();
            foreach (DataRow item in dt.Rows)
            {
                employee.setEmployeeID(item["Employee_ID"].ToString());
                employee.setEmployeeSurname(item["Employee_Surname"].ToString());
                employee.setEmployeeGivenName(item["Employee_GivenName"].ToString());
                employee.setPassword(item["Password"].ToString());
                employee.setPosition(item["Position"].ToString());
                employee.setEmail(item["Email"].ToString());
                employee.setDateDeleted(Convert.ToDateTime(item["Date_Deleted"]));
            }
            conn.Close();
            return employee;
        }

        public int insert(Employee employee, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `employee`(`Employee_ID`, `Employee_Surname`, `Employee_GivenName`, `Password`, `Position`, `Email`) " +
                "VALUES (@employeeID,@surname,@givenName,@password,@position,@email)", conn);
            cmd.Parameters.AddWithValue("@employeeID", employee.getEmployeeID());
            cmd.Parameters.AddWithValue("@surname", employee.getEmployeeSurname());
            cmd.Parameters.AddWithValue("@givenName", employee.getEmployeeGivenName());
            cmd.Parameters.AddWithValue("@password", employee.getPassword());
            cmd.Parameters.AddWithValue("@position", employee.getPosition());
            cmd.Parameters.AddWithValue("@email", employee.getEmail());
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int update(Employee employee, string currentId, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `employee` SET `Employee_ID`=@employeeID,`Employee_Surname`=@surname,`Employee_GivenName`=@givenName,`Password`=@password,`Position`=@position,`Email`=@email " +
                "WHERE `Employee_ID` = @currentID", conn);
            cmd.Parameters.AddWithValue("@employeeID", employee.getEmployeeID());
            cmd.Parameters.AddWithValue("@surname", employee.getEmployeeSurname());
            cmd.Parameters.AddWithValue("@givenName", employee.getEmployeeGivenName());
            cmd.Parameters.AddWithValue("@password", employee.getPassword());
            cmd.Parameters.AddWithValue("@position", employee.getPosition());
            cmd.Parameters.AddWithValue("@email", employee.getEmail());
            cmd.Parameters.AddWithValue("@currentID", currentId);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int delete(string employeeID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `employee` SET `Date_Deleted` = NOW() WHERE `Employee_ID` = @employeeID", conn);
            cmd.Parameters.AddWithValue("@employeeID", employeeID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int undelete(string employeeID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `employee` SET `Date_Deleted` = NULL WHERE `Employee_ID` = @employeeID", conn);
            cmd.Parameters.AddWithValue("@employeeID", employeeID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public int permanentlyDelete(string employeeID, MySqlConnection conn)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `employee` WHERE `Employee_ID` = @employeeID", conn);
            cmd.Parameters.AddWithValue("@employeeID", employeeID);
            cmd.Prepare();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
