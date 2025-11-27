using System;

public class Email
{
    public string Sender { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }

    // Event Raised When a New Email is Received
    public event Action<Email>? EmailReceived;

    // Constructor for Creating an Actual Email
    public Email(string sender, string subject, string content)
    {
        Sender = sender;
        Subject = subject;
        Content = content;
    }

    // Empty Constructor for the Event
    public Email()
    {
        Sender = "";
        Subject = "";
        Content = "";
    }

    // Method to Simulate Receiving an Email
    public void ReceiveEmail(Email email)
    {
        EmailReceived?.Invoke(this);
    }
}