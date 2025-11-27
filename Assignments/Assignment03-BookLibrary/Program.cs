// Start choice at -1 so the loop runs at least once
int choice = -1;

// List to store all books in the library
List<IBook> library = new List<IBook>();

// Keep the program running until user chooses to quit
while (choice != 0)
{
    Console.WriteLine("=== Book Library Menu ===");
    Console.WriteLine("0 - Exit");
    Console.WriteLine("1 - Add a new book");
    Console.WriteLine("2 - Find a book");
    Console.WriteLine("3 - Borrow a book");
    Console.WriteLine("4 - Return a book");
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