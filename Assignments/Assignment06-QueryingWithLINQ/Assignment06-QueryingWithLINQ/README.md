# Assignment 6 - Querying with LINQ  
Author: Joe Goode  
Course: .NET  

## Overview  
This console app works with the Northwind database using Entity Framework Core and LINQ.  
It focuses on querying data, serializing results in multiple formats, and allowing user-driven lookups.

## Question 1 - Serialization Comparison  
The program queries all categories and their related products from the Northwind database and serializes the data using three different formats:
- JSON
- XML
- DataContract

For each format, the program calculates the number of bytes used and then ranks the formats from smallest to largest.

## Question 2 - Customer Lookup by City  
The program displays a list of all unique cities that customers are located in.  
The user is then prompted to enter a city name, and the application outputs all customer company names for that city along with a count.

Basic input validation is included to make sure the city name is not empty.

## How It Works  
- Entity Framework Core is used to connect to the Northwind database.
- LINQ queries retrieve categories, products, and customers.
- Data is serialized using multiple .NET serialization options.
- Console output is used to display results clearly for each question.

## Files Included  
- `Program.cs`  
- `NorthwindContext.cs`  
- `Category.cs`  
- `Product.cs`  
- `Customer.cs`  
- `NorthwindData.cs`  

## Notes  
This assignment practices LINQ querying, working with databases, basic error handling, and comparing serialization formats.