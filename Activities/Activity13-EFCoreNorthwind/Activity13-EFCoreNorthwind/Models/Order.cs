using System;
using System.Collections.Generic;
using System.Text;

namespace Activity13_EFCoreNorthwind.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; } = string.Empty;
    }
}

