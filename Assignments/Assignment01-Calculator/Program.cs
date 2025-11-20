Console.WriteLine("=== Assignment 1: Calculator ===");
Console.WriteLine("Choose an operation:");
Console.WriteLine("1 - Add (+)");
Console.WriteLine("2 - Subtract (-)");
Console.WriteLine("3 - Multiply (*)");
Console.WriteLine("4 - Divide (/)");
Console.WriteLine("5 - Power (^)");

Console.Write("Enter your choice (1-5): ");
int choice = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the first number: ");
double first = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double second = Convert.ToDouble(Console.ReadLine());

double result = 0;
// This holds the math symbol for the chosen operation (+, -, *, /, ^)
string symbol = "";