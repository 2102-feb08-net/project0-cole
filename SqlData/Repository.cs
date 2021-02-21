using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace SqlData
{
    public class Repository { 

        private readonly project0Context _context;

        public Repository(project0Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Customer(Library.Customer businesscustomer)
        {

            // ID left at default 0
            Customer customer = new Customer() { FirstName = businesscustomer.FirstName, LastName = businesscustomer.LastName };


            _context.Add(customer);
        }




    }


}
