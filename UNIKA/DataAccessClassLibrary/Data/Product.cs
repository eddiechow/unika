using System;
using System.Drawing;

namespace BackendClassLibrary.Data
{
    public abstract class Product
    {
        public abstract string getProductID();
        public abstract void setProductID(string productID);
        public abstract string getProductName();
        public abstract void setProductName(string productName);
        public abstract string getProductNameEnUs();
        public abstract void setProductNameEnUs(string productNameEnUs);
        public abstract string getProductNameZhHant();
        public abstract void setProductNameZhHant(string productNameZhHant);
        public abstract string getDescription();
        public abstract void setDescription(string description);
        public abstract string getDescriptionEnUs();
        public abstract void setDescriptionEnUs(string descriptionEnUs);
        public abstract string getDescriptionZhHant();
        public abstract void setDescriptionZhHant(string descriptionZhHant);
        public abstract Image getPhoto();
        public abstract void setPhoto(Image photo);
        public abstract int getQtyInStock();
        public abstract void setQtyInStock(int qtyInStock);
        public abstract int getPrice();
        public abstract void setPrice(int price);
        public abstract string getSupplierID();
        public abstract void setSupplierID(string supplierID);
        public abstract string getSupplierName();
        public abstract void setSupplierName(string supplierName);
        public abstract DateTime getReleaseDate();
        public abstract void setReleaseDate(DateTime releaseDate);
    }
}
