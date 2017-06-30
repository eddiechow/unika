using System;

namespace BackendClassLibrary.Data
{
    public class Customer
    {
        private string customerID;
        private string email;
        private string password;
        private string customerSurname;
        private string customerGivenName;
        private int regeionCode;
        private int mobilePhoneNo;
        private char gender;
        private int ageGroupCode;
        private string ageGroup;
        private string address;
        private bool activated;
        private DateTime dateDeleted;

        public string getCustomerID()
        {
            return customerID;
        }

        public void setCustomerID(string customerID)
        {
            this.customerID = customerID;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getCustomerSurname()
        {
            return customerSurname;
        }

        public void setCustomerSurname(string customerSurname)
        {
            this.customerSurname = customerSurname;
        }

        public string getCustomerGivenName()
        {
            return customerGivenName;
        }

        public void setCustomerGivenName(string customerGivenName)
        {
            this.customerGivenName = customerGivenName;
        }

        public int getRegeionCode()
        {
            return regeionCode;
        }

        public void setRegeionCode(int regeionCode)
        {
            this.regeionCode = regeionCode;
        }

        public int getMobilePhoneNo()
        {
            return mobilePhoneNo;
        }

        public void setMobilePhoneNo(int mobilePhoneNo)
        {
            this.mobilePhoneNo = mobilePhoneNo;
        }

        public char getGender()
        {
            return gender;
        }

        public void setGender(char gender)
        {
            this.gender = gender;
        }

        public int getAgeGroupCode()
        {
            return ageGroupCode;
        }

        public void setAgeGroupCode(int ageGroupCode)
        {
            this.ageGroupCode = ageGroupCode;
        }

        public string getAgeGroup()
        {
            return ageGroup;
        }

        public void setAgeGroup(string ageGroup)
        {
            this.ageGroup = ageGroup;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public bool getActivated()
        {
            return activated;
        }

        public void setActivated(bool activated)
        {
            this.activated = activated;
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
