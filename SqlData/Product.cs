using System;
using System.Collections.Generic;

#nullable disable

namespace SqlData
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
    }
}
