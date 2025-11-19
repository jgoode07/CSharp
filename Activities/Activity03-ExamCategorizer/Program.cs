bool keepGoing = true;

while (keepGoing)
{
    Console.WriteLine("=== Exam Score Categorizer ===");

    // Validate User Input (Must be between 0 and 100)
    double score;
    while (true)
    {
        Console.Write("Enter a score (0-100): ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out score) && score >= 0 && score <= 100)
        {
            break; // Valid Input
        }
        else
        {
            Console.WriteLine("Invalid score. Please enter a number between 0 and 100.");
        }
    }

    // Categorize the Score
    string category;

    if (score >= 90)
        category = "Excellent";
    else if (score >= 80)
        category = "Good";
    else if (score >= 70)
        category = "Satisfactory";
    else if (score >= 60)
        category = "Needs Improvement";
    else
        category = "Fail";

    // Display the result
    Console.WriteLine($"Score Category: {category}");
}