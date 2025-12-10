using System;

// Ask for the first number
Console.Write("Enter the first number: ");
string? firstInput = Console.ReadLine();

// Try converting to a number
if (!double.TryParse(firstInput, out double num1))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

Console.WriteLine($"First number accepted: {num1}");