namespace Assignment06_QueryingWithLINQ.Models;

// Represents a category from the Northwind database
public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;

    // Navigation property for related products
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
