using System;

namespace BackendClassLibrary.Data
{
    public class Discount
    {
        private string discountCode;
        private int discount;
        private DateTime startDate;
        private DateTime endDate;
        private string title;
        private string titleEnUs;
        private string titleZhHant;
        private DateTime dateDeleted;

        public string getDiscountCode()
        {
            return discountCode;
        }

        public void setDiscountCode(string discountCode)
        {
            this.discountCode = discountCode;
        }

        public int getDiscount()
        {
            return discount;
        }

        public void setDiscount(int discount)
        {
            this.discount = discount;
        }

        public DateTime getStartDate()
        {
            return startDate;
        }

        public void setStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }

        public DateTime getEndDate()
        {
            return endDate;
        }

        public void setEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }

        public string getTitle()
        {
            return title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public string getTitleEnUs()
        {
            return titleEnUs;
        }

        public void setTitleEnUs(string titleEnUs)
        {
            this.titleEnUs = titleEnUs;
        }

        public string getTitleZhHant()
        {
            return titleZhHant;
        }

        public void setTitleZhHant(string titleZhHant)
        {
            this.titleZhHant = titleZhHant;
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
