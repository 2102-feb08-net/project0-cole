using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class StoreLocation
    {
        public int Id { get; private set; }
        public string Location { get; private set; }
        public string PhoneNumber { get; private set; }

        public StoreLocation(string location, string PhoneNumber)
        {


            ValidateLocation(location);
        }

        private void ValidateLocation(string location)
        {
            if(location.Length > 100)
            {
                throw new ArgumentException("Location name too long");
            }
        }




    }
}
