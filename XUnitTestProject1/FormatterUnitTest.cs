using System;
using Xunit;
using Library;

namespace XUnitTestProject1
{
    /// <summary>
    /// Verifies that special characters in phone numbers are removed
    /// </summary>
    public class FormatterUnitTest
    {
        [Fact]

        public void Formatter_FormatPhoneNumber_RemoveNonDigits()

        {
            //Arrange

            string expected = "6088844692";

            StoreLocation storeLocation = new StoreLocation("Edgerton", "Wisconsin", "501 N Main St","608-884-4692");

            Assert.Equal(expected,storeLocation.PhoneNumber);
           


        }
    }
}
