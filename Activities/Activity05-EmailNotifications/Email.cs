using System;

public class Email
{
    public string Sender { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }

    // Event Raised When a New Email is Received
    public event Action<Email>? EmailReceived;

    // Method to Simulate Receiving an Email
    public void ReceiveEmail()
    {
        EmailReceived?.Invoke(this);
    }
}