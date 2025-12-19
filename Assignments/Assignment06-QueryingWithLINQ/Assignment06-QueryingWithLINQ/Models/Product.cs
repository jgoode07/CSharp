namespace Assignment06_QueryingWithLINQ.Models;

// Represents a product from the Northwind database
public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }

    public int CategoryId { get; set; }

    // Navigation back to Category
    public Category? Category { get; set; }
}
