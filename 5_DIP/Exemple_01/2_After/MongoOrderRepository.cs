using System;

namespace DIP.Exemple_01.After
{
    // Alternative repository implementation
    public class MongoOrderRepository : IOrderRepository
    {
        public void Save(Order order)
        {
            // MongoDB saving logic
            Console.WriteLine($"Order {order.Id} saved to MongoDB");
        }
    }
}
