using SqlData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public static class ManageStoreLocationsUI
    {
        public static void DisplayOptions(Repository repository)
        {

            while (true)
            {
                Console.WriteLine("You are now viewing the Store Location Management Menu");
                Console.WriteLine();
                Console.WriteLine("c: Create a Store Location");
                Console.WriteLine("q: To Return Back to the Main Menu");

                Console.WriteLine();

                string userinput = Console.ReadLine();

                if (userinput == "c")
                {

                    Console.WriteLine("Please Enter The Store Locations City\n");
                    string city = Console.ReadLine();
                    Console.WriteLine("Please Enter Its State\n");
                    string state = Console.ReadLine();
                    Console.WriteLine("Please Enter The Address\n");
                    string address = Console.ReadLine();
                    Console.WriteLine("Please Enter The Locations Phone Number\n");
                    string phoneNumber = Console.ReadLine();

 
                    try
                    {
                        Library.StoreLocation storeLocation = new Library.StoreLocation(city, state, address, phoneNumber);
                       
                        if (repository.AddStoreLocation(storeLocation))
                        {
                            Console.WriteLine("Successfully added Store Location");
                            Console.WriteLine("Remember to save to lock in changes.");
                        }   
           

                    }
                    catch (ArgumentException exception)
                    {
                        Console.WriteLine("Could not Create Store Location");
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
