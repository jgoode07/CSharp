using System;
using System.Collections.Generic;
using System.Text;

namespace Activity13_EFCoreNorthwind.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
