using SqlData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI
{
    /// <summary>
    /// Displays a menu of options for users to manage Products, allows them to return back to main menu.  Data type is validated here.  Products must be saved before changes are saved to data base, that's done from main menu.
    /// </summary>
    /// <param name="repository"></param>
    public static class ManageProductUI
    {
        public static void DisplayOptions(Repository repository)
        {

            while (true)
            {
                Console.WriteLine("You are now viewing the Product Management Menu.");
                Console.WriteLine();
                Console.WriteLine("c: To Create A New Product");
                Console.WriteLine("q: To Return Back to the Main Menu");
                Console.WriteLine();

                string userinput = Console.ReadLine().ToLower();

                if (userinput == "c")
                {

                    Console.WriteLine("Please Enter The Products Name\n");
                    string productname = Console.ReadLine();
                    decimal price;

                    while (true)
                    {

                        Console.WriteLine("Please Enter The Products Price\n");
                        string pricestring = Console.ReadLine();

                        if (decimal.TryParse(pricestring, out price))
                        {
                            break;
                        }                 
                    }


                    try
                    {
                        Library.Product product = new Library.Product(productname, price);
                        if (repository.AddProduct(product))
                        {
                            Console.WriteLine("Successfully added Product");
                            Console.WriteLine("Remember to save to lock in changes.");
                        }

                    }
                    catch (ArgumentException exception)
                    {
                        Console.WriteLine("Could not Create Product");
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
