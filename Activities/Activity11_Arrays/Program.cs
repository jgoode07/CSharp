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