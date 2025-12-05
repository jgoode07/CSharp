using System;

class Program
{
    static void Main()
    {
        // Get the current date and time
        DateTime currentDateTime = DateTime.Now;

        Console.WriteLine("Current Date and Time:");
        Console.WriteLine(currentDateTime.ToString("MMMM dd, yyyy - hh:mm tt"));
        Console.WriteLine();

        // Add 5 days to the current date
        DateTime futureDate = currentDateTime.AddDays(5);

        Console.WriteLine("Date After Adding 5 Days:");
        Console.WriteLine(futureDate.ToString("MMMM dd, yyyy"));
        Console.WriteLine();
    }
}