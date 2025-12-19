using Assignment06_QueryingWithLINQ.Data;
using Assignment06_QueryingWithLINQ.Models;
using System.Text.Json;

try
{
    // Create the database context to access Northwind
    using var context = new NorthwindContext();

    var data = new NorthwindData
    {
        Categories = context.Categories
            .Select(c => new Category
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName,
                Products = c.Products.ToList()
            })
            .ToList()
    };

    Console.WriteLine($"Loaded {data.Categories.Count} categories.");

    // Serialize the data to JSON and measure size
    var jsonBytes = JsonSerializer.SerializeToUtf8Bytes(data);
    Console.WriteLine($"JSON size: {jsonBytes.Length} bytes");
}
catch (Exception ex)
{
    // Basic error handling for database or query issues
    Console.WriteLine($"Error loading data: {ex.Message}");
}
