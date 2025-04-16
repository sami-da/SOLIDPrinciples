using System;

namespace SRP.Exemple_02._2_After
{
    // Responsible for displaying order information
    public class OrderDisplay
    {
        public void DisplayOrder(Order order)
        {
            Console.WriteLine($"Order ID: {order.OrderId}");
            Console.WriteLine($"Customer: {order.CustomerName}");
            Console.WriteLine("Items:");
            foreach (var item in order.Items)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine($"Total: ${order.TotalAmount}");
        }
    }
}
