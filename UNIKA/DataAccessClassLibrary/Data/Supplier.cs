using System;

namespace BackendClassLibrary.Data
{
    public class Supplier
    {
        private string supplierID;
        private string supplierName;
        private string password;
        private string productCategory;
        private string contectNo;
        private string email;
        private string address;
        private DateTime dateDeleted;

        public string getSupplierID()
        {
            return supplierID;
        }

        public void setSupplierID(string supplierID)
        {
            this.supplierID = supplierID;
        }

        public string getSupplierName()
        {
            return supplierName;
        }

        public void setSupplierName(string supplierName)
        {
            this.supplierName = supplierName;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getProductCategory()
        {
            return productCategory;
        }

        public void setProductCategory(string productCategory)
        {
            this.productCategory = productCategory;
        }

        public string getContectNo()
        {
            return contectNo;
        }

        public void setContectNo(string contectNo)
        {
            this.contectNo = contectNo;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        {
            this.address = address;
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
