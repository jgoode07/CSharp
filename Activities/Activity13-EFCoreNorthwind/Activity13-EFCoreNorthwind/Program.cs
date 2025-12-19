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
}