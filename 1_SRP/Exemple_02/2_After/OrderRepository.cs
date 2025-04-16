using System;
using System.IO;
using System.Linq;

namespace SRP.Exemple_02._2_After
{
    // Responsible for saving order data
    public class OrderRepository
    {
        public void SaveOrder(Order order)
        {
            // Code to save order to a file
            string orderData = $"{order.OrderId},{order.CustomerName},{string.Join("|", order.Items)},{order.TotalAmount}";
            File.WriteAllText($"order_{order.OrderId}.txt", orderData);
            Console.WriteLine("Order saved to file.");
        }

        public Order LoadOrder(int orderId)
        {
            // Code to load order from file (simplified)
            string[] data = File.ReadAllText($"order_{orderId}.txt").Split(',');
            return new Order(
                int.Parse(data[0]),
                data[1],
                data[2].Split('|').ToList(),
                decimal.Parse(data[3])
            );
        }
    }
}
