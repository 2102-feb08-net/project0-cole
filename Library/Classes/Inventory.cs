using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Inventory
    {
        public Dictionary<Product, int> Stock{ get; private set; }

        public Inventory()
        {
            Dictionary<Product, int> Stock = new Dictionary<Product, int>();
        }

        private void ValidateReasonableQuantity(int quantity)
        {
            if (quantity > 1000000)
            {
                throw new ArgumentException("Unreasonable Quantity");
            }
        }

        public bool AddProductQuantity(Product product, int quantity)
        {
            ValidateReasonableQuantity(quantity);

            Stock.Add(product,quantity);

            return true;
        }
        public bool RemoveItem(int productId, int storeId, int quantity)
        {

            // returns false if the key does not exist within the diction

            return false;

        }

        public bool RemoveItemQuantity(int productId, int storeId, int quantity)
        {

            // returns false if the key does not exist within the diction

            return false;

        }

        public int GetQuantity(Product product)
        {

            return 0;

        }
    }
}
