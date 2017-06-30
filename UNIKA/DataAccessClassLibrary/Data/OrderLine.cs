namespace BackendClassLibrary.Data
{
    public class OrderLine
    {
        private ulong orderID;
        private string productID;
        private string productName;
        private int unitPrice;
        private int? discount;
        private int qty;
        private string note;
        private int bottleCapacity;

        public ulong getOrderID()
        {
            return orderID;
        }

        public void setOrderID(ulong orderID)
        {
            this.orderID = orderID;
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

        public int getUnitPrice()
        {
            return unitPrice;
        }

        public void setUnitPrice(int unitPrice)
        {
            this.unitPrice = unitPrice;
        }

        public int? getDiscount()
        {
            if (discount==null)
                return null;
            else
                return discount.Value;
        }

        public void setDiscount(int? discount)
        {
            this.discount = discount;
        }

        public int getQty()
        {
            return qty;
        }

        public void setQty(int qty)
        {
            this.qty = qty;
        }

        public string getNote()
        {
            return note;
        }

        public void setNote(string note)
        {
            this.note = note;
        }

        public int getBottleCapacity()
        {
            return bottleCapacity;
        }

        public void setBottleCapacity(int bottleCapacity)
        {
            this.bottleCapacity = bottleCapacity;
        }
    }
}
