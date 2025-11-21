# Assignment 2 – Email Address Generator  
**Author:** Joe Goode  
**Course:** C# Programming

## Overview
This program creates a student email address based on the user’s first name, last name, and year of birth. It follows the required format:

**[first letter of first name][last name][year]@robertsoncollege.ca**

```
Output:
jgoode1986@robertsoncollege.ca
```

## How It Works
- The program asks the user for their first name, last name, and birth year.  
- A try/catch block is used to handle cases where the user enters an invalid year.  
- The first letter of the first name is taken, the last name is added, and both are converted to lowercase.  
- The birth year is appended, followed by the required domain.  
- A friendly welcome message is printed along with the generated email.

## Files Included
- `Program.cs`