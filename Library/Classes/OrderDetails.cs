using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    class OrderDetails
    {
        public Customer Customer { get; private set; }
        public Order Order { get; private set; }

        public OrderDetails(Customer customer, Order order)
        {
            Customer = customer;

            Order = order;

        }
    }
}
