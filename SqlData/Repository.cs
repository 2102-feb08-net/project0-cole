﻿using System;
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

        public bool AddCustomer(Library.Customer businesscustomer)
        {

            // ID left at default 0
            Customer customer = new Customer() { FirstName = businesscustomer.FirstName, LastName = businesscustomer.LastName };


            _context.Add(customer);

            return true;
        }

        public bool AddOrder(Library.Order businessorder)
        {

            // ID left at default 0

            Order order = new Order() { CustomerId = businessorder.CustomerId, StoreLocationId = businessorder.StoreId, TimeCreated = businessorder.TimeCreated };

            _context.Add(order);

            return true;
        }

        public bool AddProduct(Library.Product businessproduct)
        {

            // ID left at default 0
            Product product = new Product() { Id = businessproduct.Id, ProductName = businessproduct.ProductName,Price=businessproduct.Price };

            _context.Add(product);

            return true;
        }

        public bool AddStoreLocation(Library.StoreLocation businessstorelocation)
        {

            // ID left at default 0
            StoreLocation storeLocation = new StoreLocation() 
            { 
                Id = businessstorelocation.Id, 
                Address = businessstorelocation.Address, 
                City = businessstorelocation.City, 
                State = businessstorelocation.State,
                PhoneNumber = businessstorelocation.PhoneNumber
            };

            _context.Add(storeLocation);

            return true;
        }

        public Library.Customer GetCustomerById(int customerid)
        {

            var result = _context.Customers.Where(x => x.Id == customerid).FirstOrDefault();

            Library.Customer customer = new Library.Customer(result.FirstName, result.LastName, result.Id);

            return customer;
        }

        public List<Library.Order> GetOrderByCustomerId(int customerid)
        {
            List<Library.Order> orders = new List<Library.Order>();

            var results = _context.Orders.Where(x => x.CustomerId == customerid);

            foreach (var result in results)
            {
                orders.Add(new Library.Order(result.CustomerId, result.StoreLocationId, result.TimeCreated.Value, result.Id));
            }

            return orders;

        }

        public List<Library.Customer> SearchCustomers(string firstname, string lastname)
        {
            ///Quick check if a search is null or whitespace, if it is, it sets the string to xxx to avoid recieving all entries back.

            if (string.IsNullOrWhiteSpace(firstname))
            {
                firstname = "xxx";
            }
            if (string.IsNullOrWhiteSpace(lastname))
            {
                lastname = "xxx";
            }

            List<Library.Customer> customers = new List<Library.Customer>();

            var results = _context.Customers.Where(x => x.FirstName.Contains(firstname) || x.LastName.Contains(lastname));

            foreach (var result in results)
            {
                customers.Add(new Library.Customer(result.FirstName, result.LastName, result.Id));
            }

            return customers;
        }


        public bool SaveChanges()
        {
            _context.SaveChanges();

            return true;
        }


    }


}
