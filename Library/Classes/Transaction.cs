using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Class created by Transaction Processor which just helps group some useful information of an allowed transaction
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Id of Customer who placed order
        /// </summary>
        public int CustomerId { get; private set; }
        /// <summary>
        /// id of location order was placed at
        /// </summary>
        public int LocationId { get; private set; }
        /// <summary>
        /// Number of items to be added to order
        /// </summary>
        public int Quantity { get; private set; }
        /// <summary>
        /// product for this specific line of the order
        /// </summary>
        public int ProductId { get; private set; }
        /// <summary>
        /// Holds and OrderDetails object which will give us properties to view the customer and store location this is meant for.
        /// </summary>
        public OrderDetails OrderDetails { get; set; }
        
        public Transaction(int productId ,int quantity, OrderDetails orderDetails)
        {
   
            ProductId = productId;

            Quantity = quantity;

            OrderDetails = orderDetails;

           
        }
    }
}
