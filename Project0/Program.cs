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
           var disposables = new Disposables();

            var context = disposables.getContext();

            Repository repository = new Repository(context);

            Console.WriteLine(repository.GetCustomerById(1).FirstName);
    

        }
    }
}