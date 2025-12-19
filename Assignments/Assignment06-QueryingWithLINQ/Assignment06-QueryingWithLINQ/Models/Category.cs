namespace Activity13_EFCoreNorthwind.Models
{
    // Represents a category from the Northwind database
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}