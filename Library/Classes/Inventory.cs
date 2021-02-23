using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Inventory
    {
        public Dictionary<int , int> Stock { get; private set; } 

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

        public void DisplayContent()
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

        public bool AddProductQuantity(int productid, int quantity)
        {
            ValidateReasonableQuantity(quantity);

            
            this.Stock.Add(productid,quantity);

            return true;
        }


    }
}
