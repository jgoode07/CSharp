Console.Write("Enter your first name: ");
string firstName = Console.ReadLine();

Console.Write("Enter your last name: ");
string lastName = Console.ReadLine();

int birthYear;

// Try/catch to make sure the year of birth is a valid number.
try
{
    Console.Write("Enter your year of birth: ");
    birthYear = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Invalid year. Please enter a valid number next time.");
    Environment.Exit(0);
    return;
}