using System;

// Ask for the first number
Console.Write("Enter the first number: ");
string? firstInput = Console.ReadLine();

// Try converting to a number
if (!int.TryParse(firstInput, out int num1))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

Console.WriteLine($"First number accepted: {num1}");

// Ask for the second number
Console.Write("Enter the second number: ");
string? secondInput = Console.ReadLine();

if (!int.TryParse(secondInput, out int num2))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

Console.WriteLine($"Numbers entered: {num1} and {num2}");


// Divide the numbers with exception handling
try
{
    int result = num1 / num2;
    Console.WriteLine($"{num1} divided by {num2} equals {result}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: You cannot divide by zero.");
}
catch (Exception)
{
    Console.WriteLine("There was an error during the calculation.");
}