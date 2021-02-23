using SqlData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public static class ManageOrderUI
    {
        /// <summary>
        /// Displays a menu of options for users to manage Orders, allows them to return back to main menu.  Data type is validated here
        /// </summary>
        /// <param name="repository"></param>
        public static void DisplayOptions(Repository repository)
        {

            while (true)
            {
                Console.WriteLine("You are now viewing the Order Management Menu, Please Choose Another Key To Select An Options");
                Console.WriteLine("d: Vew Details of an Order");
                Console.WriteLine("a: Edit Item on Order");
                Console.WriteLine("c: Create A New Order");
                Console.WriteLine("q: To Return Back to the Main Menu");

                Console.WriteLine();

                string userinput = Console.ReadLine();


                if (userinput == "c")
                {


                    int customerid;

                    while (true)
                    {
                        Console.WriteLine("Please Enter The Customer Id\n");
                        string customeridstring = Console.ReadLine();

                        if (int.TryParse(customeridstring, out customerid))
                        {
                            break;
                        }
                        else if (customeridstring == "q")
                        {
                            break;
                        }
                    }

                    int storeid;

                    while (true)
                    {
                        Console.WriteLine("Please Enter The Store Id\n");
                        string storeidstring = Console.ReadLine();

                        if (int.TryParse(storeidstring, out storeid))
                        {
                            break;
                        }
                        else if (storeidstring == "q")
                        {
                            break;
                        }
                    }

                    DateTime timecreated = DateTime.Now;




                    try
                    {
                        Library.Order order = new Library.Order(customerid, storeid, timecreated);
                        if (repository.AddOrder(order))
                        {
                            Console.WriteLine("Successfully added Order");
                            Console.WriteLine("Remember to save to lock in changes.");
                        }

                    }
                    catch (ArgumentException exception)
                    {
                        Console.WriteLine("Could not Create Order");
                        Console.WriteLine(exception.Message);
                    }

                }

                else if (userinput == "a")
                {
                    Console.WriteLine("Please select the Id of an order you would like to edit\n");

                    int orderid;

                    while (true)
                    {

                        string orderidstring = Console.ReadLine();

                        if (int.TryParse(orderidstring, out orderid))
                        {
                            break;
                        }

                        Console.WriteLine("\nPlease Enter An Integer\n");
                    }

                    Library.OrderDetails orderDetails= repository.GetOrderDetailsById(orderid);

                    orderDetails.DisplayOrderDetails();

                    Library.Inventory orderinventory = repository.GetOrderInventoryByID(orderid);

                    orderinventory.DisplayContents();

                    Library.Inventory storeinventory = repository.GetStoreInventoryByID(orderid);


                    Console.WriteLine("\nPlease Enter the Product Id\n");

                    int productid;

                    while (true)
                    {

                        string orderidstring = Console.ReadLine();

                        if (int.TryParse(orderidstring, out productid))
                        {
                            break;
                        }

                        Console.WriteLine("\nPlease Enter An Integer\n");
                    }

                    Library.Product product = repository.GetProductById(productid);

                    Console.WriteLine("You selected the following item.");

                    product.DisplayDetails();

                    Console.WriteLine("Please enter how many you would like to add to the order.\n");

                    int quantity;

                    while (true)
                    {

                        string orderidstring = Console.ReadLine();

                        if (int.TryParse(orderidstring, out quantity))
                        {
                            break;
                        }

                        Console.WriteLine("Please Enter An Integer\n");
                    }


                    try
                    {
                        Library.Transaction transaction = Library.TransactionProcessor.AttemptTransaction(storeinventory, orderinventory, productid, quantity,orderDetails);
                        Library.Inventory updatedinventory = repository.HandleTransaction(transaction);
                        Console.WriteLine("\nHere is an updated inventory of the order for you\n");
                        updatedinventory.DisplayContents();
                    }
                    catch (ArgumentException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }

               
                   

                    break;
                }

                else if (userinput == "d")
                {
                    Console.WriteLine("Please select the Id of an order you would like to view the details of\n");

                    int orderid;

                    while (true)
                    {
                        Console.WriteLine("Please Enter The Order Id\n");
                        string orderidstring = Console.ReadLine();

                        if (int.TryParse(orderidstring, out orderid))
                        {
                            break;
                        }
                        else if (orderidstring == "q")
                        {
                            break;
                        }
                    }

                    

                    break;
                }

                else if (userinput == "q")
                {
                    Console.WriteLine("Returning to Main Menu\n");
                    break;
                }
            }

        }
    }

}
