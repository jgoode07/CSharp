# Assignment 1 Minimal APIs

This project is a minimal ASP.NET Core Web API that provides endpoints for working with a Product resource.

## Requirements
- .NET 8 SDK
- Visual Studio 2022
- Postman (for testing)

## How to Run
1. Open the solution in Visual Studio.
2. Press **F5** to run the project.
3. The API will start on a local https://localhost address.
4. The exact port number will be shown in the Visual Studio output window.

## Testing
All endpoints were tested using Postman.

## Available Endpoints

### Get All Products
GET /products

### Get Product by ID
GET /products/{id}

### Create a Product
POST /products  

Body (JSON):
```
{
  "name": "Monitor",
  "description": "27 inch display",
  "price": 299.99
}
```

### Delete a Product
DELETE /products/{id}

### Final Product List
After deleting product with ID 1, the remaining products are:

Product ID 2
Product ID 3

![Final product list](screenshot/final-product-list.png)