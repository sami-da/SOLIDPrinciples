namespace SRP.Exemple_01.After
{
    using System;

    public class UserRepository
    {
        public void Save(User user)
        {
            // Simulate saving to a database
            Console.WriteLine($"User '{user.Username}' with email '{user.Email}' saved to database.");
        }
    }
}
