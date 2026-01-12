using A1_MinimalApiProducts.Endpoints;
using A1_MinimalApiProducts.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

// Product endpoints
app.MapPost("/products", (Product product) => ProductEndpoint.CreateProduct(product));

app.MapGet("/products", () => ProductEndpoint.GetAllProducts());

app.MapGet("/products/{id:int}", (int id) => ProductEndpoint.GetProductById(id));

app.MapDelete("/products/{id:int}", (int id) => ProductEndpoint.DeleteProduct(id));

app.Run();