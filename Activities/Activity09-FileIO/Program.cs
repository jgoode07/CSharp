/// <summary>
/// The program creates a text file with sample content if it does not exist,
/// displays the contents, allows the user to add new input, and then shows
/// the updated file contents.
/// </summary>
/// <remarks>
/// Author: Joe Goode  
/// Course: .NET  
/// </remarks>

using System;
using System.IO;

string filePath = "activity9.txt";

// Only create the file if it doesn't already exist
if (!File.Exists(filePath))
{
    string sampleContent =
        "Buy the ticket, take the ride.\n" +
        "- Hunter S. Thompson\n\n" +
        "Not all those who wander are lost.\n" +
        "- J.R.R. Tolkien\n";

    File.WriteAllText(filePath, sampleContent);

    Console.WriteLine("Sample file created with provided content.");
}
else
{
    Console.WriteLine("File already exists. Using existing file.");
}

// Read and display file contents
Console.WriteLine("\n--- Current File Contents ---");

string fileContents = File.ReadAllText(filePath);
Console.WriteLine(fileContents);

// Ask the user to add new content
Console.WriteLine("Add a new line to the file:");
string? newLine = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(newLine))
{
    File.AppendAllText(filePath, newLine + Environment.NewLine);
    Console.WriteLine("\nNew content added successfully.");
}
else
{
    Console.WriteLine("\nNo content entered. File unchanged.");
}

// Display updated file contents
Console.WriteLine("\nUpdated File Contents:\n");
string updatedContents = File.ReadAllText(filePath);
Console.WriteLine(updatedContents);