using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace SqlData
{
    public class Repository { 


        private  project0Context _context;
        public Repository(project0Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Library.Customer GetCustomerById(int id)
        {
           
            var customer = _context.Customers.Find(id);

            return new Library.Customer(customer.FirstName, customer.LastName);
        }




    }


}
