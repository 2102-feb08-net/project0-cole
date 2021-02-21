using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI
{
    public static class ManageCustomersUI
    {
        public static void DisplayOptions()
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
                }
            }
        }


    }
}
