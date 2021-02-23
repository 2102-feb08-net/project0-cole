using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Purpose of this class is to aggregate a bunch of useful information from an Order and offer methods to display that information.
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// Id that was created from sql data base, can not be set by user.
        /// </summary>
        public int OrderId { get; private set; }
        /// <summary>
        /// Customer who placed order.
        /// </summary>
        public Customer Customer { get; private set; }
        /// <summary>
        /// Store Location order was placed at.
        /// </summary>
        public StoreLocation StoreLocation { get; private set; }
        /// <summary>
        /// Contains date when the order was placed
        /// </summary>
        public DateTime TimeCreated { get; private set; }
        /// <summary>
        /// Constructor, No validation because the Types that populate this class have already done their own validation.
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="customer"></param>
        /// <param name="storeLocation"></param>
        /// <param name="timeCreated"></param>
        public OrderDetails()
        {
           
        }
        public OrderDetails(int orderId,Customer customer,StoreLocation storeLocation,DateTime timeCreated)
        {
            OrderId = orderId;

            Customer = customer;

            StoreLocation = storeLocation;

            TimeCreated = timeCreated;

        }
        /// <summary>
        /// Displays relevant Order information, such as customer,time, and location.
        /// </summary>
        public bool DisplayOrderDetails()
        {
            if(this.OrderId == 0)
            {
                Console.WriteLine("No details could be cound for this order, are you sure that Id exists?");
                return false;
            }
            Console.WriteLine($"ID:{this.OrderId} This order was created by {this.Customer.FirstName},{this.Customer.LastName} at a store located in {this.StoreLocation.City} {this.StoreLocation.State} on {this.TimeCreated}");

            return true;
        }
    }
}
