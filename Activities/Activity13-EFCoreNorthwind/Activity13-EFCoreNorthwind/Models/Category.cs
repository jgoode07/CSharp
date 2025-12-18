using System;
using System.Collections.Generic;
using System.Text;

namespace Activity13_EFCoreNorthwind.Models
{
    // Represents a single category from the Categories table
    public class Category
    {
        // Primary key for the Category table
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
