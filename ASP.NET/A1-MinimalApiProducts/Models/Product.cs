namespace A1_MinimalApiProducts.Models
{
    // Simple product model used by the minimal API
    public class Product
    {
        // Unique ID for each product
        public int ProductId { get; set; }

        // Name shown to the user
        public string Name { get; set; } = string.Empty;

        // Short description of the product
        public string Description { get; set; } = string.Empty;

        // Price of the product
        public decimal Price { get; set; }
    }
}