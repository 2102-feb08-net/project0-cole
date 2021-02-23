using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Transaction
    {
        public bool TransactionOccured { get; set; }
        public int CustomerId { get; private set; }
        public int LocationId { get; private set; }
        public int Quantity { get; private set; }
        public int ProductId { get; private set; }
        public Transaction(int customerid, int productId, int storelocationid,int quantity)
        {
            CustomerId = customerid;

            ProductId = productId;

            LocationId = storelocationid;

            Quantity = quantity;

           
        }
    }
}
