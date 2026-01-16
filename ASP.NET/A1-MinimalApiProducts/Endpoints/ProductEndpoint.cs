using A1_MinimalApiProducts.Models;

namespace A1_MinimalApiProducts.Endpoints
{
    public static class ProductEndpoint
    {
        // In-memory list
        private static readonly List<Product> _products = new()
        {
            new Product { ProductId = 1, Name = "Keyboard", Description = "Mechanical keyboard", Price = 129.99m },
            new Product { ProductId = 2, Name = "Mouse", Description = "Wireless mouse", Price = 59.99m }
        };

        private static int _nextId = 3;

        // Create a new product
        public static IResult CreateProduct(Product product)
        {
            // DataAnnotations validation
            var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(product);
            if (!System.ComponentModel.DataAnnotations.Validator.TryValidateObject(product, validationContext, validationResults, true))
            {
                return Results.BadRequest(new {
                    success = false,
                    message = "Validation failed",
                    errors = validationResults.Select(v => v.ErrorMessage)
                });
            }

            product.ProductId = _nextId++;
            _products.Add(product);

            return Results.Created($"/products/{product.ProductId}", product);
        }

        // Get all products
        public static IResult GetAllProducts()
        {
            return Results.Ok(_products);
        }

        // Get a product by ID
        public static IResult GetProductById(int id)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
                return Results.NotFound($"No product found with id {id}.");

            return Results.Ok(product);
        }

        // Delete a product by ID
        public static IResult DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
                return Results.NotFound($"No product found with id {id}.");

            _products.Remove(product);
            return Results.NoContent();
        }
    }
}
