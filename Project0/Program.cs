using System;
using UI;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Logging;
using SqlData;

namespace Project0
{
    class Program
    {
        static void Main(string[] args)
        {
           using var disposables = new Disposables();

            var context = disposables.getContext();

            Repository repository = new Repository(context);

            AppUI(repository);
    

        }
        public static void AppUI(Repository repository)
        {

            while (true)
            {
                Console.WriteLine("c:  Manage Customers.");
                Console.WriteLine("l:  Manage Store Locations.");
                Console.WriteLine("o:  Manage Orders.");
                Console.WriteLine("p:  Manage Products.");
                Console.WriteLine("s:  Save Data.");
                Console.WriteLine("q: Quit Application");
                Console.WriteLine();
                Console.Write("Please Enter a Valid Character to Continue\n\n");

                string userinput = Console.ReadLine();

                Console.WriteLine();

                if (userinput == "c")
                {
                    ManageCustomersUI.DisplayOptions(repository);
                }
                else if (userinput == "p")
                {
                    ManageProductUI.DisplayOptions(repository);
                }
                else if(userinput == "l")
                {
                    ManageStoreLocationsUI.DisplayOptions(repository);
                }
                else if (userinput == "o")
                {
                    ManageOrderUI.DisplayOptions(repository);
                }
                else if (userinput == "l")
                {
                    Console.WriteLine("Load Data");
                }
                else if (userinput == "s")
                {
                    if (repository.SaveChanges())
                    {
                        Console.WriteLine("--Successfully Saved Data to Database!\n");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
                else if (userinput == "q")
                {
                    break;
                }


            }

        }
    }
}