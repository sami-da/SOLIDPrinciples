using System;

namespace DIP.Exemple_01.After
{
    // Low-level module implementing the interface
    public class SqlOrderRepository : IOrderRepository
    {
        public void Save(Order order)
        {
            // Database saving logic
            Console.WriteLine($"Order {order.Id} saved to SQL database");
        }
    }
}
