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
        public static Transaction AttemptTransaction(Inventory storeinventory,Inventory orderinventory ,int productid ,int quantity,OrderDetails orderDetails)
        {
            if (!storeinventory.Stock.ContainsKey(productid))
            {

                throw new ArgumentException($"The store does not contain item with id {productid}");
            }
            else if (storeinventory.Stock[productid] < quantity)
            {
                throw new ArgumentException($"But master, this store location does not have enough inventory, It only has {storeinventory.Stock[productid]} items, and you tried to add {quantity} to the order.");
            }

            else if (quantity < 0)
            {
                if (orderinventory.Stock[productid] < -quantity)
                {
                    throw new ArgumentException($"You attempted to remove {-quantity} items from this poor man's order, but he only has {orderinventory.Stock[productid]}");
                }
            }

            Transaction transaction = new Transaction(productid,quantity,orderDetails);

            return transaction;
        }
    }
}