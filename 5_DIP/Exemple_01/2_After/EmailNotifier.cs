using System;

namespace DIP.Exemple_01.After
{
    // Low-level module implementing the interface
    public class EmailNotifier : INotificationService
    {
        public void Notify(string to, string message)
        {
            // Email sending logic
            Console.WriteLine($"Email sent to {to}: {message}");
        }
    }
}
