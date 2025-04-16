namespace SRP.Exemple_01.After
{
    using System;

    public class UserValidator
    {
        public void Validate(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                throw new ArgumentException("Username cannot be empty.");
            }

            if (!user.Email.Contains("@"))
            {
                throw new ArgumentException("Invalid email address.");
            }
        }
    }
}
