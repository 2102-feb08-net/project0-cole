using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class StoreLocation
    {
        public int Id { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }

        public StoreLocation(string city, string state, string address, string phoneNumber)
        {
            ValidateLength(city,state,address,phoneNumber);

            City = city;

            State = state;

            Address = address;

            PhoneNumber = phoneNumber;

            
        }

        private void ValidateLength(params string[] names)
        {
            foreach (var name in names)
            {
                if (name.Length > 100)
                {
                    throw new ArgumentException("Location name too long");
                }
            }
        }




    }
}
