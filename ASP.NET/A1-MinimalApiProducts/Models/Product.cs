namespace A1_MinimalApiProducts.Models
{
    // Simple product model used by the minimal API
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        // Unique ID for each product
        public int ProductId { get; set; }

        // Name shown to the user
        // [Required] checks for null, but not whitespace. For stricter validation (no whitespace-only), a custom attribute could be created.
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        // Short description of the product
        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        // Price of the product
        [Range(0.01, 10000)]
        public decimal Price { get; set; }
    }
}