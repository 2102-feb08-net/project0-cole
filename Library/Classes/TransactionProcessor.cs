using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class TransactionProcessor
    {
        public static void AttemptTransaction(Inventory inventory,int productid,int customerid,int quantity,int storelocationid)
        {

            if (inventory.Stock[productid] < quantity)
            {
                throw new ArgumentException("Store location does not have enough inventory ");
            }

            Transaction transaction = new Transaction(customerid, productid, quantity);
        }
    }
}