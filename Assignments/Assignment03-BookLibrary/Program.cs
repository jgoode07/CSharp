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

    switch (choice)
    {
        case 1:
            AddBook();
            break;

        case 2:
            FindBook();
            break;

        case 3:
            BorrowBook();
            break;

        case 4:
            ReturnBook();
            break;

        case 0:
            Console.WriteLine("Exiting... Goodbye!");
            break;

        default:
            Console.WriteLine("This operation is not supported, please try again.\n");
            break;
    }
}

// Methods
void AddBook()
{
    Console.WriteLine("\n=== Add a New Book ===");

    Console.Write("Enter the book type (ebook / hardcover / audio): ");
    string type = Console.ReadLine()!.ToLower();

    Console.Write("Enter the book title: ");
    string title = Console.ReadLine()!;

    IBook newBook;

    // Pick which book type to make
    if (type == "ebook")
    {
        newBook = new Ebook(title);
    }
    else if (type == "hardcover")
    {
        newBook = new HardCover(title);
    }
    else if (type == "audio")
    {
        newBook = new Audiobook(title);
    }
    else
    {
        Console.WriteLine("Unknown book type. Please try again.\n");
        return;
    }

    // Make sure each new book starts as not borrowed
    newBook.MarkAsReturned();

    // Add to library list
    library.Add(newBook);

    Console.WriteLine($"Book '{title}' added successfully!\n");
}

void FindBook()
{
    Console.WriteLine("\n=== Find a Book ===");
    Console.Write("Enter the book title: ");
    string title = Console.ReadLine()!;

    // Look for the book (case insensitive)
    IBook? found = library.FirstOrDefault(
        b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase)
    );

    if (found == null)
    {
        Console.WriteLine($"The book '{title}' does not exist in the library.\n");
        return;
    }

    // Report the status using ternary
    string status = found.IsBorrowed ? "borrowed" : "available";
    Console.WriteLine($"The book '{title}' is {status}.\n");
}