using System;

namespace OCP.Exemple_02.After
{
    public class LoggingEmailService : IEmailService
    {
        public void SendWelcomeEmail(string email)
        {
            // Log the email instead of sending it
            Console.WriteLine($"[LOG] Email to {email} logged instead of sent.");
        }
    }
}
