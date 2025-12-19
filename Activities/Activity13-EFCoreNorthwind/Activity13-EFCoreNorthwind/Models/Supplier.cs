using System;
using System.Collections.Generic;
using System.Text;

namespace Activity13_EFCoreNorthwind.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string? ContactName { get; set; }
        public string? Phone { get; set; }
    }
}
