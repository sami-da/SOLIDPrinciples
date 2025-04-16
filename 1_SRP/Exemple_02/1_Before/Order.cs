using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Exemple_02
{
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
    
    // Order data management
    public void AddItem(string item, decimal price)
    {
        Items.Add(item);
        TotalAmount += price;
    }
    
    // Order display responsibility
    public void DisplayOrder()
    {
        Console.WriteLine($"Order ID: {OrderId}");
        Console.WriteLine($"Customer: {CustomerName}");
        Console.WriteLine("Items:");
        foreach (var item in Items)
        {
            Console.WriteLine($"- {item}");
        }
        Console.WriteLine($"Total: ${TotalAmount}");
    }
    
    // Order persistence responsibility
    public void SaveOrder()
    {
        // Code to save order to a file
        string orderData = $"{OrderId},{CustomerName},{string.Join("|", Items)},{TotalAmount}";
        File.WriteAllText($"order_{OrderId}.txt", orderData);
        Console.WriteLine("Order saved to file.");
    }
}
}
