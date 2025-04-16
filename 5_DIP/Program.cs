using DIP.Exemple_01;
using DIP.Exemple_01.After;

namespace DIP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Using email notifications and SQL database
            var orderProcessor1 = new OrderProcessor(
                new EmailNotifier(),
                new SqlOrderRepository()
            );

            // Using SMS notifications and MongoDB
            var orderProcessor2 = new OrderProcessor(
                new SmsNotifier(),
                new MongoOrderRepository()
            );

            var order = new Order
            {
                Id = 1,
                CustomerEmail = "customer@example.com",
                Amount = 99.99m
            };

            orderProcessor1.ProcessOrder(order);
            orderProcessor2.ProcessOrder(order);
        }
    }
}
