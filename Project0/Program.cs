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
            

            var customer = context.Customers.FirstOrDefaultAsync(x => x.FirstName.Contains("co")).Result;


            Console.WriteLine(customer.FirstName);

        }
    }
}