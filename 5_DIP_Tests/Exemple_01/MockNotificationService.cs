using DIP.Exemple_01.After;
using System.Collections.Generic;

namespace DIP_Tests.Exemple_01
{
    // Mock implementation for testing
    public class MockNotificationService : INotificationService
    {
        public List<string> SentNotifications { get; } = new List<string>();

        public void Notify(string to, string message)
        {
            SentNotifications.Add($"To: {to}, Message: {message}");
        }
    }
}
