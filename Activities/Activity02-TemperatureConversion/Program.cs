Console.WriteLine("=== Fahrenheit to Celsius Converter ===");

// Get temperature from user
Console.Write("Enter the temperature in Fahrenheit: ");
double fahrenheit = Convert.ToDouble(Console.ReadLine());

// Convert to Celsius
double celsius = (fahrenheit - 32) * 5 / 9;

// Display the result
Console.WriteLine($"Temperature in Celsius: {celsius}");