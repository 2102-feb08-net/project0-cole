using System;
using Xunit;
using Library;

namespace XUnitTestProject1 { 

    /// <summary>
    /// Tests to verify Inventory can be added to dictionary, and that function returns false when there is nothing to display
    /// </summary>
    public class InventoryUnityTest
    {
        [Fact]
        public void Inventory_AddItem_SuccessfullyAddsToDictionary()

        {
            Inventory inventory = new Inventory();

            inventory.AddProductQuantity(1, 10);

            int actual = inventory.Stock[1];

            int expected = 10;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Inventory_DisplayItems_ReturnsFalseNoKeys()

        {

            Inventory inventory = new Inventory();

            bool actual = inventory.DisplayContents();

            bool expected = false;

            Assert.Equal(expected, actual);

        }


    }
}
