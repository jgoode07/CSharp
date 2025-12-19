using Assignment06_QueryingWithLINQ.Data;
using Assignment06_QueryingWithLINQ.Models;
using System.Text.Json;
using System.Xml.Serialization;

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

    try
    {
        // Serialize the data to XML and measure size
        var xmlSerializer = new XmlSerializer(typeof(NorthwindData));

        using var xmlStream = new MemoryStream();
        xmlSerializer.Serialize(xmlStream, data);

        Console.WriteLine($"XML size: {xmlStream.Length} bytes");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"XML error: {ex.InnerException?.Message ?? ex.Message}");
    }
}
catch (Exception ex)
{
    // Basic error handling for database or query issues
    Console.WriteLine($"Error loading data: {ex.Message}");
}
