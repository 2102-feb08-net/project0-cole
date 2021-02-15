using System;
using Xunit;
using Library;

namespace XUnitTestProject1
{
    public class CustomerUnitTest
    {
        [Fact]

        public void Customer_Constructor_ValidTrimFormat()

        {
            //Arrange

            string expected = "Johnathan";

            Customer customer = new Customer("joHnathAN  ", "smith");

            Assert.Equal(expected,customer.FirstName);


        }
    }
}
