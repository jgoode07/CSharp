Console.WriteLine("=== Average Calculator ===");

// Get Three Numbers from the User
Console.Write("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the third number: ");
double num3 = Convert.ToDouble(Console.ReadLine());

// Calculate the Average
double average = (num1 + num2 + num3) / 3;

// Display the Result
Console.WriteLine($"The average is: {average}");