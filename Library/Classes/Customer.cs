using System;

namespace Library
{
    public class Customer
    {
        public int Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public Customer(string firstName, string lastName, int id = 0)
        {
            string validfirstname = ValidateAndFormatName(firstName.Trim());

            string validlastname = ValidateAndFormatName(lastName.Trim());

            FirstName = validfirstname;

            LastName = validlastname;

            Id = id;
        }

        public static string ValidateAndFormatName(string name)

        {
            // Checks whether the string is Null or Empty, throws an error if it is.

            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("There are no letters");
            }

            // Seperates string into a character array to check and make sure all characters are letters,
            // Throws an ArgumentException error if it finds a non letter

            char[] nameletters = name.ToCharArray();

            nameletters.

            for (int i = 0; i < nameletters.Length; i++)
            {
                if (!char.IsLetter(nameletters[i]))
                {
                    throw new ArgumentException("All characters must be a letter");
                }

            }

            // Returns a formatted Name

            string formattedname = Formatter.FormatName(name);

            return formattedname;
        }
    }
}
