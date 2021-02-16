using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Inventory
    {
        public int Id { get; private set; }

        public Dictionary<Product, int> Items { get; private set; }

        public Inventory()
        {
            Items = new Dictionary<Product, int>();
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

            if (Items.ContainsKey(product))
            {
                Items[product] += quantity;
            }
            else
            {
                Items.Add(product, quantity);
            }

            return true;
        }
        public bool RemoveItem(Product product)
        {

            // returns false if the key does not exist within the diction

            if (!Items.ContainsKey(product))
            {
                return false;
            }

            Items.Remove(product);

            return true;
        }

        public bool RemoveItemQuantity(Product product, int quantity)
        {

            // returns false if the key does not exist within the diction

            if (!Items.ContainsKey(product))
            {
                return false;
            }

            //

            int remainingquantity = Items[product] - quantity;

            if (remainingquantity > 0)
            {
                Items[product] = remainingquantity;

                return true;
            }

            else
            {
                return false;
            }
        }

        public int GetQuantity(Product product)
        {

            if (Items.ContainsKey(product))
            {
                return 0;
            }

            int currentquantity = Items[product];

            return currentquantity;

        }
    }
}
