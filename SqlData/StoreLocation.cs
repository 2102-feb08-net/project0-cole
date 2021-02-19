using System;
using System.Collections.Generic;

#nullable disable

namespace SqlData
{
    public partial class StoreLocation
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
    }
}
