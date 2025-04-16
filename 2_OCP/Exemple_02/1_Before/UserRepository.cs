using System;

namespace OCP.Exemple_02.Before
{
    public class UserRepository
    {
        public void Save(User user)
        {
            // Simulate saving to a database
            Console.WriteLine($"User '{user.Username}' with email '{user.Email}' saved to database.");
        }
    }
}
