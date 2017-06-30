using System;

namespace BackendClassLibrary.Data
{
    public class Order
    {
        private string orderID;
        private string custID;
        private string custName;
        private string custEmail;
        private string custMobilePhoneNo;
        private string custAddress;
        private DateTime orderDate;
        private bool rejected;
        private string barCode = null;
        private string approvedByEmpID = null;
        private string approvedBy = null;
        private DateTime? approvedDate = null;
        private string payPalPaymentID = null;
        private string payPalTransactionID = null;
        private DateTime dateDeleted;

        public string getOrderID()
        {
            return orderID;
        }

        public void setOrderID(string orderID)
        {
            this.orderID = orderID;
        }

        public string getCustID()
        {
            return custID;
        }

        public void setCustID(string custID)
        {
            this.custID = custID;
        }

        public string getCustName()
        {
            return custName;
        }

        public void setCustName(string custName)
        {
            this.custName = custName;
        }

        public string getCustEmail()
        {
            return custEmail;
        }

        public void setCustEmail(string custEmail)
        {
            this.custEmail = custEmail;
        }

        public string getCustMobilePhoneNo()
        {
            return custMobilePhoneNo;
        }

        public void setCustMobilePhoneNo(string custMobilePhoneNo)
        {
            this.custMobilePhoneNo = custMobilePhoneNo;
        }

        public string getCustAddress()
        {
            return custAddress;
        }

        public void setCustAddress(string custAddress)
        {
            this.custAddress = custAddress;
        }

        public DateTime getOrderDate()
        {
            return orderDate;
        }

        public void setOrderDate(DateTime orderDate)
        {
            this.orderDate = orderDate;
        }

        public bool getRejected()
        {
            return rejected;
        }

        public void setRejected(bool rejected)
        {
            this.rejected = rejected;
        }

        public string getBarCode()
        {
            return barCode;
        }

        public void setBarCode(string barCode)
        {
            this.barCode = barCode;
        }

        public string getApprovedByEmpID()
        {
            return approvedByEmpID;
        }

        public void setApprovedByEmpID(string approvedByEmpID)
        {
            this.approvedByEmpID = approvedByEmpID;
        }

        public string getApprovedBy()
        {
            return approvedBy;
        }

        public void setApprovedBy(string approvedBy)
        {
            this.approvedBy = approvedBy;
        }

        public DateTime? getApprovedDate()
        {
            return approvedDate;
        }

        public void setApprovedDate(DateTime? approvedDate)
        {
            this.approvedDate = approvedDate;
        }

        public string getPayPalPaymentID()
        {
            return payPalPaymentID;
        }

        public void setPayPalPaymentID(string payPalPaymentID)
        {
            this.payPalPaymentID = payPalPaymentID;
        }

        public string getPayPalTransactionID()
        {
            return payPalTransactionID;
        }

        public void setPayPalTransactionID(string payPalTransactionID)
        {
            this.payPalTransactionID = payPalTransactionID;
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
