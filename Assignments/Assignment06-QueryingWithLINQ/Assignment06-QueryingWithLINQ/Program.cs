using Assignment06_QueryingWithLINQ.Data;
using Assignment06_QueryingWithLINQ.Models;

try
{
    // Create the database context to access Northwind
    using var context = new NorthwindContext();

    // Query categories and count how many products belong to each one
    var categories = context.Categories
        .Select(c => new
        {
            c.CategoryName,
            ProductCount = c.Products.Count
        })
        .ToList();

    Console.WriteLine($"Loaded {categories.Count} categories.");

    foreach (var category in categories)
    {
        Console.WriteLine($"{category.CategoryName} ({category.ProductCount} products)");
    }
}
catch (Exception ex)
{
    // Basic error handling for database or query issues
    Console.WriteLine($"Error loading data: {ex.Message}");
}
