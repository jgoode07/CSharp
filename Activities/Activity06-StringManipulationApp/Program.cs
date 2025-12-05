Console.Write("Enter a sentence or phrase: ");
string? userInput = Console.ReadLine();

if (string.IsNullOrEmpty(userInput))
{
    Console.WriteLine("You didn't enter any text. Please run the program again.");
    return;
}