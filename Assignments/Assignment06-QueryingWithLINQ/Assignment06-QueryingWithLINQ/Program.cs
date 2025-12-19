using Assignment06_QueryingWithLINQ.Data;
using Assignment06_QueryingWithLINQ.Models;

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
}
catch (Exception ex)
{
    // Basic error handling for database or query issues
    Console.WriteLine($"Error loading data: {ex.Message}");
}
