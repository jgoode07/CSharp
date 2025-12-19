/// <summary>
/// Console application that uses Entity Framework Core
/// to query and display data from the Northwind database.
/// </summary>
/// <remarks>
/// Author: Joe Goode
/// Course: .NET Programming
/// </remarks>

using Activity13_EFCoreNorthwind.Data;

using (var context = new NorthwindContext())
{
    var categories = context.Categories;

    // Loop through Categories, write to console
    foreach (var category in categories)
    {
        Console.WriteLine(category.CategoryName);
    }

    Console.WriteLine(); // spacing

    // Loop through Customers and display
    var topCustomers = context.Customers
        .OrderByDescending(c =>
            context.Orders.Count(o => o.CustomerId == c.CustomerId))
        .Take(5);

    foreach (var customer in topCustomers)
    {
        Console.WriteLine(customer.CompanyName);
    }

    Console.WriteLine();

    // Display all suppliers and contact info
    var suppliers = context.Suppliers;

    foreach (var supplier in suppliers)
    {
        Console.WriteLine($"{supplier.CompanyName} - {supplier.ContactName} ({supplier.Phone})");
    }

    Console.WriteLine();

    // Products in stock with price over $50
    var expensiveProducts = context.Products
        .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 50);

    foreach (var product in expensiveProducts)
    {
        Console.WriteLine($"{product.ProductName} - ${product.UnitPrice:F2}"); // Format to 2 decimal points
    }

    Console.WriteLine();

    Console.WriteLine("Orders from the last month:");

    // Get the most recent order date in the database
    // Northwind is old, this is based on "last month" in the database
    var latestOrderDate = context.Orders
        .Where(o => o.OrderDate.HasValue)
        .Max(o => o.OrderDate);

    // Pull orders from the month leading up to the latest order date
    var recentOrders = context.Orders
    .Where(o => o.OrderDate.HasValue &&
                o.OrderDate.Value >= latestOrderDate.Value.AddMonths(-1))
    .OrderBy(o => o.OrderDate);

    foreach (var order in recentOrders)
    {
        Console.WriteLine($"{order.OrderId} - {order.OrderDate:d}");
    }

    Console.WriteLine();

    // Use London as an example for customers in a city
    Console.WriteLine("Customers from London:");

    var londonCustomers = context.Customers
        .Where(c => c.City == "London")
        .OrderBy(c => c.CompanyName);

    foreach (var customer in londonCustomers)
    {
        Console.WriteLine(customer.CompanyName);
    }
}