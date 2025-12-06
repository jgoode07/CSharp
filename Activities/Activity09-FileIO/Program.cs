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

    Console.WriteLine("Sample file created with initial content.");
}
else
{
    Console.WriteLine("File already exists. Using existing file.");
}