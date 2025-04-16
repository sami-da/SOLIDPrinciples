using OCP.Example_01.After;
using OCP.Exemple_01._2_After;
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

            // Regular customer
            var regularDiscount = new DiscountCalculator(new RegularCustomerDiscount());
            Console.WriteLine($"Regular Customer Discount: {regularDiscount.CalculateDiscount(totalAmount)}");

            // Premium customer
            var premiumDiscount = new DiscountCalculator(new PremiumCustomerDiscount());
            Console.WriteLine($"Premium Customer Discount: {premiumDiscount.CalculateDiscount(totalAmount)}");

            // VIP customer
            var vipDiscount = new DiscountCalculator(new VipCustomerDiscount());
            Console.WriteLine($"VIP Customer Discount: {vipDiscount.CalculateDiscount(totalAmount)}");

            // No discount
            var noDiscount = new DiscountCalculator(new NoDiscount());
            Console.WriteLine($"No Discount: {noDiscount.CalculateDiscount(totalAmount)}");
            #endregion
        }
    }
}
