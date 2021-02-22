using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Order 
    {
        public int Id { get; private set; }
        public int StoreId { get; private set; }
        public int CustomerId { get; private set; }
        public DateTime TimeCreated { get; private set; }
        public Customer Customer { get; private set; }
        public Inventory Inventory { get; private set; }

        public Order(int id, int customerid, int storeid, DateTime timecreated)
        {

            TimeCreated = timecreated;

            CustomerId = customerid;

            StoreId = storeid;

            TimeCreated = timecreated;

            
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
