using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    /// <summary>
    /// Interface for basic behavior of both order and store inventory
    /// </summary>
    interface IInventoryManager
    {
        bool AddProductQuantity(int productid, int quantity);
        void DisplayContents();

    }
}
