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

// Operation selection
if (choice == 1)
{
    result = Add(first, second);
    symbol = "+";
}
else if (choice == 2)
{
    result = Subtract(first, second);
    symbol = "-";
}
else if (choice == 3)
{
    result = Multiply(first, second);
    symbol = "*";
}
else if (choice == 4)
{
    // Only check the second number since it's the divisor. 
    // If it's zero, the division would throw a runtime error.
    if (second == 0)
    {
        Console.WriteLine("Cannot divide by zero.");
        Environment.Exit(0);
    }

    result = Divide(first, second);
    symbol = "/";
}
else if (choice == 5)
{
    result = Power(first, second);
    symbol = "^";
}
else
{
    Console.WriteLine("Invalid choice. Please run the program again and choose 1-5.");
    Environment.Exit(0);
}

Console.WriteLine($"{first} {symbol} {second} = {result}");

// Functions for Each Operation

static double Add(double a, double b)
{
    return a + b;
}

static double Subtract(double a, double b)
{
    return a - b;
}

static double Multiply(double a, double b)
{
    return a * b;
}

static double Divide(double a, double b)
{
    return a / b;
}

static double Power(double baseValue, double exponentValue)
{
    // The exponent is used as a count for how many times tp multiply the base.
    int exponent = (int)exponentValue;
    double result = 1;

    for (int i = 0; i < exponent; i++)
    {
        result = Multiply(result, baseValue);
    }

    return result;
}