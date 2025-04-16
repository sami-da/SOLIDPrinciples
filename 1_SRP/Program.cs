using SRP.Exemple_01.After;
using SRP.Exemple_02._2_After;
using System.Collections.Generic;

namespace SRP
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

            var validator = new UserValidator();
            var userRepository = new UserRepository();
            var emailService = new EmailService();

            var userManager = new UserManager(validator, userRepository, emailService);
            userManager.RegisterUser(user);
            #endregion

            #region Exemple 2
            // Creating and using the refactored classes
            var order = new Order(1, "John Doe", new List<string> { "Book", "Pen" }, 25.50m);
            order.AddItem("Notebook", 10.00m);

            // Display the order
            var displayService = new OrderDisplay();
            displayService.DisplayOrder(order);

            // Save the order
            var orderRepository = new OrderRepository();
            orderRepository.SaveOrder(order);
            #endregion
        }
    }
}
