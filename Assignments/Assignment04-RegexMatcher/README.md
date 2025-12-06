# Assignment 4 – Regex Matcher  
Author: Joe Goode  
Course: .NET  

## Overview  
This console application lets the user test custom regular expressions against user input.  
The program continues running until the user presses the ESC key to exit.

## How It Works  
- The user is asked to enter a regular expression.  
- If the user presses ENTER without typing a regex, a default pattern is used.  
- The user then enters a string to test against the active regex.  
- The program checks for a match using `Regex.IsMatch`.  
- The result is displayed as `True` or `False`.  
- The user can press ESC to quit or any other key to test again.  

## Files Included  
- `Program.cs`

## Notes  
This assignment practices pattern matching using regular expressions. It is the first assignment in Module 1 of the .NET course at Robertson College.