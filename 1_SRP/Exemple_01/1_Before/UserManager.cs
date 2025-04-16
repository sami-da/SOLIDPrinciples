namespace SRP.Exemple_01.Before
{
    using System;

    public class UserManager
    {
        public void RegisterUser(string username, string email)
        {
            // Validate user input
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username cannot be empty.");
            }

            if (!email.Contains("@"))
            {
                throw new ArgumentException("Invalid email address.");
            }

            // Save user to database
            Console.WriteLine($"User '{username}' with email '{email}' saved to database.");

            // Send welcome email
            Console.WriteLine($"Welcome email sent to {email}.");
        }
    }
}
