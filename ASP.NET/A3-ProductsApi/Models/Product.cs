namespace A3_ProductsApi.Models;

public class Product
{
    // Primary key
    public int Id { get; set; }

    // Basic product info
    public string Name { get; set; } = "";

    public string Description { get; set; } = "";

    // Using decimal for money values
    public decimal Price { get; set; }
}
