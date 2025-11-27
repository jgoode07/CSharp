public class EmailNotificationService
{
    // This Method Reacts When an Email is Received
    public void HandleEmailReceived(Email email)
    {
        Console.WriteLine($"New email received!");
        Console.WriteLine($"From: {email.Sender}");
        Console.WriteLine($"Subject: {email.Subject}");
        Console.WriteLine($"Content: {email.Content}");
    }
}