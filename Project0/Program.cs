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
                Console.WriteLine("i:  Manage Store Inventory.");
                Console.WriteLine("o:  Manage Orders.");
                Console.WriteLine("s:  Save Data.");
                Console.WriteLine("q: Quit Application");
                Console.WriteLine();
                Console.Write("Please Enter a Valid Character to Select\n\n");

                string userinput = Console.ReadLine();

                Console.WriteLine();

                if (userinput == "c")
                {
                    ManageCustomersUI.DisplayOptions();
                }
                else if(userinput == "i")
                {
                    Console.WriteLine("Manage Store Inventory");
                }
                else if (userinput == "o")
                {
                    Console.WriteLine("Manage Orders");
                }
                else if (userinput == "l")
                {
                    Console.WriteLine("Load Data");
                }
                else if (userinput == "s")
                {
                    Console.WriteLine("Save Data");
                }
                else if (userinput == "q")
                {
                    break;
                }


            }

        }
    }
}