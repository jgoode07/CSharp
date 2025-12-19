using Activity13_EFCoreNorthwind.Models;

namespace Assignment06_LinqNorthwind.Models
{
    // Represents a product from the Northwind database
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }

        public int CategoryId { get; set; }

        // Link back to the product's category
        public Category? Category { get; set; }
    }
}
