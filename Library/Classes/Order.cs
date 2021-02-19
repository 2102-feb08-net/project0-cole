using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Order 
    {

        public Dictionary<Product, int> ProductQuantities { get; }
        public DateTime TimeCreated { get; private set; }
        public Customer Customer { get; private set; }
        public Inventory Inventory { get; private set; }

        public Order(Customer customer)
        {

            TimeCreated = DateTime.Now;

            Customer = customer;

            
        }

        private int ValidateQuantity(int quantity)
        {
            //Checks for negative numbers and makes sure orders aren't unreasonably high (999) 
            //Throws ArguementException Error if either of those are the case.

            if(quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }

            if (quantity > 999)
            { 
                throw new ArgumentException("Quantity is unreasonably high.");
            }

            return quantity;
        }
    }
}
