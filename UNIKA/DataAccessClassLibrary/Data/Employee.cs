using System;

namespace BackendClassLibrary.Data
{
    public class Employee
    {
        private string employeeID;
        private string employeeSurname;
        private string employeeGivenName;
        private string password;
        private string position;
        private string email;
        private DateTime dateDeleted;

        public string getEmployeeID()
        {
            return employeeID;
        }

        public void setEmployeeID(string employee_ID)
        {
            this.employeeID = employee_ID;
        }

        public string getEmployeeSurname()
        {
            return employeeSurname;
        }

        public void setEmployeeSurname(string employeeSurname)
        {
            this.employeeSurname = employeeSurname;
        }

        public string getEmployeeGivenName()
        {
            return employeeGivenName;
        }

        public void setEmployeeGivenName(string employeeGivenName)
        {
            this.employeeGivenName = employeeGivenName;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPosition()
        {
            return position;
        }

        public void setPosition(string position)
        {
            this.position = position;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public DateTime getDateDeleted()
        {
            return dateDeleted;
        }

        public void setDateDeleted(DateTime dateDeleted)
        {
            this.dateDeleted = dateDeleted;
        }
    }
}
