using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class TransactionProcessor
    {
        public static Transaction AttemptTransaction(Inventory storeinventory,Inventory orderinventory ,int productid,int customerid,int quantity,int storelocationid)
        {

            if (storeinventory.Stock[productid] < quantity)
            {
                throw new ArgumentException("Store location does not have enough inventory");
            }

            if (quantity < 0)
            {
                if (orderinventory.Stock[productid] < -quantity)
                {
                    throw new ArgumentException("Can't remove more items than exist on the order");
                }
            }


            Transaction transaction = new Transaction(customerid,productid,storelocationid,quantity);

            return transaction;
        }
    }
}