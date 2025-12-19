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
}