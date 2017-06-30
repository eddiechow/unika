using System;

namespace BackendClassLibrary.Data
{
    public class ProductDiscount
    {
        private string discountCode;
        private string productID;
        private string productName;
        private string perfumeCategory;
        private int productPrice;
        private DateTime dateDeleted;

        public string getDiscountCode()
        {
            return discountCode;
        }

        public void setDiscountCode(string discountCode)
        {
            this.discountCode = discountCode;
        }

        public string getProductID()
        {
            return productID;
        }

        public void setProductID(string productID)
        {
            this.productID = productID;
        }

        public string getProductName()
        {
            return productName;
        }

        public void setProductName(string productName)
        {
            this.productName = productName;
        }

        public string getPerfumeCategory()
        {
            return perfumeCategory;
        }

        public void setPerfumeCategory(string perfumeCategory)
        {
            this.perfumeCategory = perfumeCategory;
        }

        public int getProductPrice()
        {
            return productPrice;
        }

        public void setProductPrice(int productPrice)
        {
            this.productPrice = productPrice;
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
