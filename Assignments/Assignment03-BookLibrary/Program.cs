// Start choice at -1 so the loop runs at least once
int choice = -1;

// Keep the program running until user chooses to quit
while (choice != 0)
{
    Console.WriteLine("=== Book Library Menu ===");
    Console.WriteLine("0 - Exit");
    Console.Write("Enter your choice: ");

    // Try to Read a Number
    bool valid = int.TryParse(Console.ReadLine(), out choice);

    if (!valid)
    {
        Console.WriteLine("Invalid input. Please enter a number.\n");
        continue;
    }

    if (choice == 0)
    {
        Console.WriteLine("Exiting... Goodbye!");
        break;
    }

    Console.WriteLine("This operation is not supported, please try again.\n");
}