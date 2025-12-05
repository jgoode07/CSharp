/// <summary>
/// Small practice program that takes user input, counts the number of 
/// characters, displays the text in uppercase, and shows the text in 
/// reverse order.
/// </summary>
/// <remarks>
/// Author: Joe Goode  
/// Course: .NET  
/// </remarks>

Console.Write("Enter a sentence or phrase: ");
string? userInput = Console.ReadLine();

if (string.IsNullOrEmpty(userInput))
{
    Console.WriteLine("You didn't enter any text. Please run the program again.");
    return;
}

int characterCount = userInput.Length;
Console.WriteLine($"\nNumber of characters: {characterCount}");

string upperCaseVersion = userInput.ToUpper();
Console.WriteLine($"Uppercase version: {upperCaseVersion}");

char[] characters = userInput.ToCharArray();
Array.Reverse(characters);
string reversed = new string(characters);

Console.WriteLine($"Reversed: {reversed}");