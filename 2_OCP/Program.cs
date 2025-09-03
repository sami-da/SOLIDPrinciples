using OCP.Exemple_01.After;
using OCP.Exemple_02;
using OCP.Exemple_02.After;
using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemple 1

            var user = new User
            {
                Username = "JohnDoe",
                Email = "john.doe@example.com"
            };

            IUserValidator validator = new UserValidator();
            IUserRepository repository = new UserRepository();
            IEmailService emailService = new EmailService();

            var userManager = new UserManager(validator, repository, emailService);
            userManager.RegisterUser(user);

            // Use a different email service (e.g., LoggingEmailService)
            var loggingEmailService = new LoggingEmailService();
            var userManagerWithLogging = new UserManager(validator, repository, loggingEmailService);
            userManagerWithLogging.RegisterUser(user);

            #endregion

            #region Exemple 2
            decimal totalAmount = 1000;
            DiscountCalculator discountCalculator = new DiscountCalculator();

            // Regular customer
            Console.WriteLine($"Regular Customer Discount: {discountCalculator.CalculateDiscount("Regular", totalAmount)}");

            // Premium customer
            Console.WriteLine($"Premium Customer Discount: {discountCalculator.CalculateDiscount("Premium", totalAmount)}");

            // VIP customer
            Console.WriteLine($"VIP Customer Discount: {discountCalculator.CalculateDiscount("VIP", totalAmount)}");

            // No discount
            Console.WriteLine($"No Discount: {discountCalculator.CalculateDiscount("NoDiscount", totalAmount)}");
            #endregion
        }
    }
}
