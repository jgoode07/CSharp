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
