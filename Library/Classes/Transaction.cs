using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Transaction
    {
        public int CustomerId { get; private set; }
        public int LocationId { get; private set; }
        public int Quantity { get; private set; }
        public Transaction(int customerid, int storelocationid,int quantity)
        {
            CustomerId = customerid;

            LocationId = storelocationid;

            Quantity = quantity;
        }
    }
}
