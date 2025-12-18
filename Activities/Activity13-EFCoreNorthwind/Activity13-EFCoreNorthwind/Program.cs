using Activity13_EFCoreNorthwind.Data;

using (var context = new NorthwindContext())
{
    var categories = context.Categories;

    // Loop through Categories, write to console
    foreach (var category in categories)
    {
        Console.WriteLine(category.CategoryName);
    }
}