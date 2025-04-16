using System;

namespace DIP.Exemple_01.After
{
    // Alternative notification implementation
    public class SmsNotifier : INotificationService
    {
        public void Notify(string to, string message)
        {
            // SMS sending logic
            Console.WriteLine($"SMS sent to {to}: {message}");
        }
    }
}
