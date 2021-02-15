using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    interface IInventoryManager
    {
        bool AddItemQuantity(Product product, int quantity);
        bool RemoveItem(Product product);
        bool RemoveItemQuantity(Product product, int quantity);
        int GetQuantity(Product product);

    }
}
