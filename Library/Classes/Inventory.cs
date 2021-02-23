using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    /// <summary>
    /// Acts as a container for either a store's inventory or the list of products on an order.  Allows you to add products and validates reasonable quantities.
    /// </summary>
    public class Inventory : IInventoryManager
    {
        /// <summary>
        /// Contains a Product Key (int), with it's Value Quantity (int)
        /// </summary>
        public Dictionary<int , int> Stock { get; private set; } 
        /// <summary>
        /// Initializes new Dictionary.
        /// </summary>
        public Inventory()
        {
            Stock = new Dictionary<int, int>();
        }

        private void ValidateReasonableQuantity(int quantity)
        {
            if (quantity > 1000000)
            {
                throw new ArgumentException("Unreasonable Quantity");
            }
        }
        /// <summary>
        /// Displays the product Id and Quantity of each Item in the inventory.
        /// </summary>
        public void DisplayContents()
        {
            var keys = Stock.Keys;

            if(keys.Count == 0)
            {
                Console.WriteLine("No items were found in this dictionary");
            }

            foreach (var key in keys)
            {
                Console.WriteLine($"Item with id {key} has quantity of {Stock[key]}");
            }

        }
        /// <summary>
        /// Adds a product id and given quantity to a dictionary of products and their quantities.
        /// </summary>
        /// <param name="productid"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public bool AddProductQuantity(int productid, int quantity)
        {
            ValidateReasonableQuantity(quantity);

            
            this.Stock.Add(productid,quantity);

            return true;
        }


    }
}
