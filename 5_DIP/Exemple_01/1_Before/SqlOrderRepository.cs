using System;

namespace DIP.Exemple_01.Before
{
    // Low-level module
    public class SqlOrderRepository
    {
        public void Save(Order order)
        {
            // Database saving logic
            Console.WriteLine($"Order {order.Id} saved to SQL database");
        }
    }
}
