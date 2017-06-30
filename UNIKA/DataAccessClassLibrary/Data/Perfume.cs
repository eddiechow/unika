using System;
using System.Drawing;

namespace BackendClassLibrary.Data
{
    public class Perfume : Product
    {
        private string productID;
        private string productName;
        private string productNameEnUs;
        private string productNameZhHant;
        private string description;
        private string descriptionEnUs;
        private string descriptionZhHant;
        private Image photo;
        private int qtyInStock;
        private int price;
        private string supplierID;
        private string supplierName;
        private DateTime releaseDate;
        private string categoryCode;
        private string category;
        private DateTime dateDeleted;

        public override string getProductID()
        {
            return productID;
        }

        public override void setProductID(string productID)
        {
            this.productID = productID;
        }

        public override string getProductName()
        {
            return productName;
        }

        public override void setProductName(string productName)
        {
            this.productName = productName;
        }

        public override string getProductNameEnUs()
        {
            return productNameEnUs;
        }

        public override void setProductNameEnUs(string productNameEnUs)
        {
            this.productNameEnUs = productNameEnUs;
        }

        public override string getProductNameZhHant()
        {
            return productNameZhHant;
        }

        public override void setProductNameZhHant(string productNameZhHant)
        {
            this.productNameZhHant = productNameZhHant;
        }

        public override string getDescription()
        {
            return description;
        }

        public override void setDescription(string description)
        {
            this.description = description;
        }

        public override string getDescriptionEnUs()
        {
            return descriptionEnUs;
        }

        public override void setDescriptionEnUs(string descriptionEnUs)
        {
            this.descriptionEnUs = descriptionEnUs;
        }

        public override string getDescriptionZhHant()
        {
            return descriptionZhHant;
        }

        public override void setDescriptionZhHant(string descriptionZhHant)
        {
            this.descriptionZhHant = descriptionZhHant;
        }

        public override Image getPhoto()
        {
            return photo;
        }

        public override void setPhoto(Image photo)
        {
            this.photo = photo;
        }

        public override int getQtyInStock()
        {
            return qtyInStock;
        }

        public override void setQtyInStock(int qtyInStock)
        {
            this.qtyInStock = qtyInStock;
        }

        public override int getPrice()
        {
            return price;
        }

        public override void setPrice(int price)
        {
            this.price = price;
        }

        public override string getSupplierID()
        {
            return supplierID;
        }

        public override void setSupplierID(string supplierID)
        {
            this.supplierID = supplierID;
        }

        public override string getSupplierName()
        {
            return supplierName;
        }

        public override void setSupplierName(string supplierName)
        {
            this.supplierName = supplierName;
        }

        public override DateTime getReleaseDate()
        {
            return releaseDate;
        }

        public override void setReleaseDate(DateTime releaseDate)
        {
            this.releaseDate = releaseDate;
        }

        public string getCategoryCode()
        {
            return categoryCode;
        }

        public void setCategoryCode(string categoryCode)
        {
            this.categoryCode = categoryCode;
        }

        public string getCategory()
        {
            return category;
        }

        public void setCategory(string category)
        {
            this.category = category;
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
