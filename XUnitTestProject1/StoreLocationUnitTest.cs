using Library;
using System;
using Xunit;

namespace XUnitTestProject1
{
    /// <summary>
    /// Validates various errors that should be thrown when these items are constructed.
    /// </summary>
    public class StoreLocationUnitTest
    {

        [Fact]
        public void StoreLocation_Constructor_ValidateOnlyLetters()

        {
            //Arrange

            StoreLocation storeLocation;

            //Assert

            Assert.Throws<ArgumentException>(() => storeLocation = new StoreLocation("New York","Ne!w York","401 N Bronx.","207-706-3042"));

        }

        [Fact]
        public void Product_Constructor_ValidateReasonableLengthCity()

        {
            //Arrange

            StoreLocation storeLocation;

            //Assert

            Assert.Throws<ArgumentException>(() => storeLocation = new StoreLocation("Whywouldacityeverneedtobethislongsajndfoanmdspofi[mdasofmoaspdfmaosdmfoasdfniasodfmoisamdfaspodmfdgo", "New York", "401 N Bronx.", "207-706-3042"));

        }


        [Fact]
        public void Product_Constructor_ValidateReasonableLengthState()

        {
            //Arrange

            StoreLocation storeLocation;

            //Assert

            Assert.Throws<ArgumentException>(() => storeLocation = new StoreLocation("OOOOOOOOOOOOOOOOOOOOOOOOOOooooooooossssssssssssssssssssssssssssssssoooooooooooooooooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO:))))))))))))", "New York", "401 N Bronx.", "207-706-3042"));

        }
    }
}