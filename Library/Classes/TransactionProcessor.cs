using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Purpose of this class is to compare two inventories with eachother and throws an Argument Exception error on invalid quantities.
    /// Also acts as a constructuor for a transaction class which helps group relevant information.
    /// </summary>
    public static class TransactionProcessor
    {
        /// <summary>
        /// Compares two inventories, throws errors on invalid transactions
        /// </summary>

        /// <returns> 
        /// An allowable transaction
        /// </returns>
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