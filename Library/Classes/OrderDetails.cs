using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class OrderDetails
    {
        public int OrderId { get; private set; }
        public Customer Customer { get; private set; }
        public StoreLocation StoreLocation { get; private set; }
        public DateTime TimeCreated { get; private set; }

        public OrderDetails(int orderId,Customer customer,StoreLocation storeLocation,DateTime timeCreated)
        {
            OrderId = orderId;

            Customer = customer;

            StoreLocation = storeLocation;

            TimeCreated = timeCreated;

        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine($"ID:{this.OrderId} This order was created by {this.Customer.FirstName},{this.Customer.LastName} at a store located in {this.StoreLocation.City} {this.StoreLocation.State} on {this.TimeCreated}");
        }
    }
}
