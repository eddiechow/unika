using System;
using System.Drawing;

namespace BackendClassLibrary.Data
{
    public class ProblemReport
    {
        private int problemID;
        private Image photo;
        private string reason;
        private string orderID;
        private string custSurname;
        private string custGivenName;
        private int custRegeionCode;
        private int custMobilePhoneNo;
        private DateTime reportDate;
        private DateTime? returnDate = null;
        private DateTime dateDeleted;

        public int getProblemID()
        {
            return problemID;
        }

        public void setProblemID(int problemID)
        {
            this.problemID = problemID;
        }

        public Image getPhoto()
        {
            return photo;
        }

        public void setPhoto(Image photo)
        {
            this.photo = photo;
        }

        public string getReason()
        {
            return reason;
        }

        public void setReason(string reason)
        {
            this.reason = reason;
        }

        public string getOrderID()
        {
            return orderID;
        }

        public void setOrderID(string orderID)
        {
            this.orderID = orderID;
        }

        public string getCustSurname()
        {
            return custSurname;
        }

        public void setCustSurname(string custSurname)
        {
            this.custSurname = custSurname;
        }

        public string getCustGivenName()
        {
            return custGivenName;
        }

        public void setCustGivenName(string custGivenName)
        {
            this.custGivenName = custGivenName;
        }

        public int getCustRegeionCode()
        {
            return custRegeionCode;
        }

        public void setCustRegeionCode(int custRegeionCode)
        {
            this.custRegeionCode = custRegeionCode;
        }

        public int getCustMobilePhoneNo()
        {
            return custMobilePhoneNo;
        }

        public void setCustMobilePhoneNo(int custMobilePhoneNo)
        {
            this.custMobilePhoneNo = custMobilePhoneNo;
        }

        public DateTime getReportDate()
        {
            return reportDate;
        }

        public void setReportDate(DateTime reportDate)
        {
            this.reportDate = reportDate;
        }

        public DateTime? getReturnDate()
        {
            return returnDate;
        }

        public void setReturnDate(DateTime? returnDate)
        {
            this.returnDate = returnDate;
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
