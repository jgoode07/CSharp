using System;
using System.Text.RegularExpressions;

string defaultRegex = @"^[a-z]+$";

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