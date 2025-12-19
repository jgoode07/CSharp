# Assignment 13 - EF Core Northwind Queries  
Author: Joe Goode  
Course: .NET

## Overview  
This console application uses Entity Framework Core to connect to the Northwind database  
and run a series of queries to retrieve and display data in the console.

## How It Works  
- A DbContext is configured to connect to the Northwind SQL Server database.  
- Entity classes are created to represent database tables (such as Categories, Customers, Orders, Products, and Suppliers).  
- The program queries and displays:
  - A list of all product categories  
  - The top 5 customers based on number of orders  
  - All suppliers with their contact information  
  - Products that are in stock and priced over $50  
  - Orders placed within the most recent month in the database  
  - Customers from a specific city, sorted alphabetically  
- Results are printed directly to the console.

## Files Included  
- `Program.cs`  
- `NorthwindContext.cs`  
- `Category.cs`  
- `Customer.cs`  
- `Order.cs`  
- `Product.cs`  
- `Supplier.cs`  

## Notes  
This assignment focuses on working with EF Core and LINQ queries instead of writing raw SQL. 
It also reinforces how to map database tables to C# classes and retrieve filtered and sorted data using EF Core.