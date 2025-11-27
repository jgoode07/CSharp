/// <summary>
/// Small practice program showing how to raise and handle events
/// using a basic email notification example.
/// </summary>
/// <remarks>
/// Author: Joe Goode  
/// Course: C# Programming  
/// </remarks>

using System;

// Create the Email Sender
Email incomingEmail = new Email();

// Create the Notification
EmailNotificationService notifier = new EmailNotificationService();

// Subscribe the Handler to the Event
incomingEmail.EmailReceived += notifier.HandleEmailReceived;

// Simulate Receiving a New Email
Email newMail = new Email("alice@example.com", "Meeting Update", "The meeting is moved to 3 PM.");

// Raise the Event 
incomingEmail.ReceiveEmail(newMail);