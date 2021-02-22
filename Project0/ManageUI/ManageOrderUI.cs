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
        public static void DisplayOptions(Repository repository)
        {

            while (true)
            {
                Console.WriteLine("You are now viewing the Order Management Menu, Please Choose Another Key To Select An Options");
                Console.WriteLine();
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

                else if (userinput == "q")
                {
                    Console.WriteLine("Returning to Main Menu\n");
                    break;
                }
            }

        }
    }

}
