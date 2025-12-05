/// <summary>
/// Practice program to understand basic collection manipulation in C#.
/// Includes List operations, duplicate removal, and Dictionary usage.
/// </summary>
/// <remarks>
/// Author: Joe Goode  
/// Course: .NET
/// </remarks>

using System;
using System.Collections.Generic;

List<int> numbers = new List<int>();
Random random = new Random();

// Create 10 random numbers between 1 and 50
for (int i = 0; i < 10; i++)
{
    numbers.Add(random.Next(1, 51));
}

// Display the original list
Console.WriteLine("Original List of Numbers:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}

Console.WriteLine();

// Find minimum and maximum values
int min = numbers.Min();
int max = numbers.Max();

// Display min and max
Console.WriteLine();
Console.WriteLine($"Minimum Value: {min}");
Console.WriteLine($"Maximum Value: {max}");

// Remove duplicates from the list
List<int> uniqueNumbers = numbers.Distinct().ToList();

// Display list after removing duplicates
Console.WriteLine();
Console.WriteLine("List After Removing Duplicates:");
foreach (int num in uniqueNumbers)
{
    Console.Write(num + " ");
}
Console.WriteLine();
Console.WriteLine();

// Dictionary to store book titles and authors
Dictionary<string, string> books = new Dictionary<string, string>()
{
    { "Pet Sematary", "Stephen King" },
    { "Along Came a Spider", "James Patterson" },
    { "Fear and Loathing in Las Vegas", "Hunter S. Thompson" },
    { "The Silence of the Lambs", "Thomas Harris" }
};

Console.WriteLine("Book Collection:");
foreach (var book in books)
{
    Console.WriteLine($"\"{book.Key}\" by {book.Value}");
}
Console.WriteLine();