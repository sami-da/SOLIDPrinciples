using System.Collections.Generic;
namespace SRP.Exemple_02._2_After
{
    // Only responsible for order data
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public List<string> Items { get; set; }
        public decimal TotalAmount { get; set; }

        public Order(int orderId, string customerName, List<string> items, decimal totalAmount)
        {
            OrderId = orderId;
            CustomerName = customerName;
            Items = items;
            TotalAmount = totalAmount;
        }

        public void AddItem(string item, decimal price)
        {
            Items.Add(item);
            TotalAmount += price;
        }
    }
}
