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

        public StoreLocation(string city, string state, string address, string phoneNumber, int id = 0)
        {

            string[] checklength = { city, state, phoneNumber,address };

            string[] onlyletters = { city, state };

            ValidateLength(50,checklength);

            Id = id;

            City = city;

            State = state;

            Address = address;

            PhoneNumber = Formatter.FormatPhoneNumber(phoneNumber);

            
        }

        private void ValidateLength(int length, params string[] names)
        {
            foreach (var name in names)
            {
                if (name.Length > length)
                {
                    throw new ArgumentException("Location name too long");
                }
            }
        }

        private void ValidateOnlyLetters(params string[] names)
        {
            foreach(var test in names)
            {
                foreach (var letter in test)
                {
                    if (!char.IsLetterOrDigit(letter))
                    {
                        throw new ArgumentException("Character must be a letter");
                    }

                }

            }

        }




    }
}
