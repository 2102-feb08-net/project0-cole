﻿using SqlData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI
{
    public static class ManageCustomersUI
    {
        public static void DisplayOptions(Repository repository)
        {

            while (true)
            {
                Console.WriteLine("You are now viewing the Customer Management Menu, Please Choose Another Key To Select An Options");
                Console.WriteLine();
                Console.WriteLine("c: To Create A New Customer");
                Console.WriteLine("s: To Search A Customer By Name");
                Console.WriteLine("q: To Return Back to the Main Menu");
                Console.WriteLine();

                string userinput = Console.ReadLine().ToLower();

                if (userinput == "c")
                {
                    Console.WriteLine("Please Enter The Customers First Name\n");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Please Enter The Customers Last Name\n");
                    string lastname = Console.ReadLine();
                    try
                    {
                        Library.Customer customer = new Library.Customer(firstname, lastname);
                        if (repository.AddCustomer(customer))
                        {
                            Console.WriteLine("Successfully added Customer");
                            Console.WriteLine("Remember to save to lock in changes.");
                        }

                    }
                    catch (ArgumentException exception)
                    {
                        Console.WriteLine("Could not Create Customer");
                        Console.WriteLine(exception.Message);
                    }

                }

                else if (userinput == "q")
                {
                    Console.WriteLine();
                    Console.WriteLine("Returning to Main Menu\n");
                    break;
                }




            }
        }


    }
}
