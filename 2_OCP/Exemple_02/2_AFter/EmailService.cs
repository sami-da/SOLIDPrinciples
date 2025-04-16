using System;

namespace OCP.Exemple_02.After
{
    public class EmailService : IEmailService
    {
        public void SendWelcomeEmail(string email)
        {
            // Simulate sending an email
            Console.WriteLine($"Welcome email sent to {email}.");
        }
    }
}
