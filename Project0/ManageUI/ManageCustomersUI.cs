using SqlData;
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
                Console.WriteLine("h: To Display History of A Customer");
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
                else if (userinput == "s")
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a First or Last Name you would like to search for.\n");

                    Console.WriteLine("First Name:");
                    string searchfirstname = Console.ReadLine();

                    Console.WriteLine("Last Name:");
                    string searchlastname = Console.ReadLine();

                    var customers = repository.SearchCustomers(searchfirstname, searchlastname);

                    if (customers.Count > 0)
                    {
                        Console.WriteLine($"We've recieved {customers.Count} results for you master.\n");
                    }

                    foreach (var customer in customers)
                    {
                        Console.WriteLine($"ID:{customer.Id} {customer.FirstName},{customer.LastName}");
                    }

                    Console.WriteLine();


                }

                else if (userinput == "h")
                {
                   
                    Console.WriteLine();
                    Console.WriteLine("Please enter the id of the customer whose order history you'd like to view.\n");
                    int customerid;

                    while (true)
                    {
                        string customeridstring = Console.ReadLine();

                        if (int.TryParse(customeridstring,out customerid))
                        {
                            break;
                        }

                        Console.WriteLine("Value must be an integer");
                    }

                    var orders = repository.GetOrderByCustomerId(customerid);

                    var customer = repository.GetCustomerById(customerid);

                    int count = orders.Count;

                    Console.WriteLine($"\n We found {count} results for you from {customer.FirstName}, {customer.LastName} (ID:{customer.Id})\n");

                    if(count > 0)
                    {
                        foreach (var order in orders)
                        {
                            Console.WriteLine($"Order Id:{order.Id} -- Customer with Id:{order.CustomerId} took an order from store with Id:{order.StoreId} at {order.TimeCreated}\n");
                        }
                    };
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
