using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Inventory
    {
        public int Id { get; private set; }

        public int StoreId { get; private set; }

        public int ProductId { get; private set; }

        public int Quantity { get; private set; }

        public Inventory(int storeId, int productId, int quantity)
        {
            StoreId = storeId;

            ProductId = productId;

            ValidateReasonableQuantity(quantity);

            quantity = Quantity;


        }

        private void ValidateReasonableQuantity(int quantity)
        {
            if (quantity > 1000000)
            {
                throw new ArgumentException("Unreasonable Quantity");
            }
        }

        public bool AddItemQuantity(Product product, int quantity)
        {
            ValidateReasonableQuantity(quantity);


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
