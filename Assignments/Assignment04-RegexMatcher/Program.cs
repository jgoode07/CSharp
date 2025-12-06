/// <summary>
/// Console app that lets the user enter a regular expression (regex)
/// and test it against input strings until they press ESC to quit.
/// </summary>
/// <remarks>
/// Author: Joe Goode  
/// Course: .NET 
/// </remarks>

using System;
using System.Text.RegularExpressions;

string defaultRegex = @"^[a-z]+$";

while (true)
{
    // Ask user for a regex
    Console.Write("Enter a regular expression (or press ENTER to use the default): ");
    string? userRegexInput = Console.ReadLine();

    // Use default regex if user presses ENTER
    string activeRegex = string.IsNullOrWhiteSpace(userRegexInput)
        ? defaultRegex
        : userRegexInput;

    // Ask the user for input to test
    Console.Write("Enter some input: ");
    string? userInput = Console.ReadLine() ?? string.Empty;

    // Check for a match
    bool isMatch = Regex.IsMatch(userInput, activeRegex);

    // Display result
    Console.WriteLine($"{userInput} matches {activeRegex}? {isMatch}");
    Console.WriteLine();

    // Ask user to continue or exit using ESC key
    Console.WriteLine("Press ESC to quit, or any other key to try again.");
    var key = Console.ReadKey(true);

    if (key.Key == ConsoleKey.Escape)
    {
        Console.WriteLine("Thank you for using The Regex Matcher! Goodbye.");
        Console.WriteLine();
        break;
    }

    Console.WriteLine();
}