using System;
using Xunit;
using Library;

namespace XUnitTestProject1
{
    public class ProductUnitTest
    {
        /// <summary>
        /// Validates reasonable quantity and name length that occurs when Products are constructed
        /// </summary>
        [Fact]
        public void Product_Constructor_ValidateReasonableQuantity()

        {
            //Arrange

            Product product;

            //Assert

            Assert.Throws<ArgumentException>(() => product = new Product("Semi Truck", 100000000, 1));

        }

        [Fact]
        public void Product_Constructor_ValidateReasonableName()

        {
            //Arrange

            Product product;

            //Assert

            Assert.Throws<ArgumentException>(() => product = new Product("This name is way too long and someone probably confused it with a description", 1000, 1));

        }
    }
}
