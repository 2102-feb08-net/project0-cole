using System;
using System.Collections.Generic;
using System.Text;
using Library;

namespace UI
{
    public static class ManageCustomerUI
    {
        public static bool addCustomer()
        {
            Console.WriteLine("Please Fill in the Details for a New Customer");
            
            Console.WriteLine("Customer First Name:");

            string firstname = Console.ReadLine();

            Console.WriteLine("Customer Last Name:");

            string lastname = Console.ReadLine();

            try
            {
                Customer customer = new Customer(firstname, lastname);
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }
    }
}
