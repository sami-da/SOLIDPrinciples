using System;

namespace DIP.Exemple_01.Before
{
    // Low-level module
    public class EmailNotifier
    {
        public void SendEmail(string to, string message)
        {
            // Email sending logic
            Console.WriteLine($"Email sent to {to}: {message}");
        }
    }
}
