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