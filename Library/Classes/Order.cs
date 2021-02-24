using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Order
    {
        public int Id { get; private set; }
        public int StoreId { get; private set; }
        public int CustomerId { get; private set; }
        public DateTime TimeCreated { get; private set; }
        public Order(int customerid, int storeid, DateTime timecreated, int id = 0)
        {

            Id = id;

            CustomerId = customerid;

            StoreId = storeid;

            TimeCreated = timecreated;


        }
    }
}