/// <summary>
/// Create an array of random integers, sort them, 
/// calculate sum and average, and allow the user 
/// to search through them for a specific number.
/// </summary>
/// <remarks>
/// Author: Joe Goode  
/// Course: C# Programming
/// </remarks>

using System;

// Create an array of integers
int[] numbers = new int[10];

// Fill the array with random numbers (1–100)
Random rand = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(1, 101);
}

// Show the original numbers
Console.WriteLine("Original array numbers:");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}

Console.WriteLine();

// Sort the array in ascending order
Array.Sort(numbers);

Console.WriteLine("\nSorted array (ascending):");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}

Console.WriteLine();

// Calculate sum of all elements
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

// Calculate average
double average = (double)sum / numbers.Length;

Console.WriteLine($"\nSum of elements: {sum}");
Console.WriteLine($"Average value: {average}");

// Allow the user to search for a specific number
Console.Write("\nEnter a number to search for: ");
string? input = Console.ReadLine();

if (!int.TryParse(input, out int searchValue))
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
    return;
}

// Search through the array
bool found = false;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == searchValue)
    {
        found = true;
        break;
    }
}

if (found)
{
    Console.WriteLine($"{searchValue} was found in the array.");
}
else
{
    Console.WriteLine($"{searchValue} was NOT found in the array.");
}