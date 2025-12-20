using Assignment06_QueryingWithLINQ.Data;
using Assignment06_QueryingWithLINQ.Models;
using System.Net.Security;
using System.Runtime.Serialization;
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

    // QUESTION 1
    Console.WriteLine("Question 1: Category and Product Serialization");

    Console.WriteLine(); // Spacing
    
    Console.WriteLine($"Loaded {data.Categories.Count} categories.");

    // Serialize the data to JSON and measure size
    var jsonBytes = JsonSerializer.SerializeToUtf8Bytes(data);
    Console.WriteLine($"JSON size: {jsonBytes.Length} bytes");

    // Store XML size so it can be ranked with the other formats
    long xmlSize = 0;

    try
    {
        // Serialize the data to XML and measure size
        var xmlSerializer = new XmlSerializer(typeof(NorthwindData));

        using var xmlStream = new MemoryStream();
        xmlSerializer.Serialize(xmlStream, data);

        xmlSize = xmlStream.Length;
        Console.WriteLine($"XML size: {xmlStream.Length} bytes");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"XML error: {ex.InnerException?.Message ?? ex.Message}");
    }

    // Serialize the data and measure size
    var dataContractSerializer = new DataContractSerializer(typeof(NorthwindData));

    using var dcStream = new MemoryStream();
    dataContractSerializer.WriteObject(dcStream, data);

    Console.WriteLine($"DataContract size: {dcStream.Length} bytes");

    // Rank formats by size (smallest to largest)
    var sizes = new List<(string Format, long Bytes)>
{
    ("JSON", jsonBytes.Length),
    ("XML", xmlSize),
    ("DataContract", dcStream.Length)
};

    var ranked = sizes.OrderBy(s => s.Bytes);

    Console.WriteLine("\nSerialization size ranking (smallest to largest):");
    foreach (var item in ranked)
    {
        Console.WriteLine($"{item.Format}: {item.Bytes} bytes");
    }

}
catch (Exception ex)
{
    // Basic error handling for database or query issues
    Console.WriteLine($"Error loading data: {ex.Message}");
}
