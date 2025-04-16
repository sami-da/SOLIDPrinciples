using System;

namespace ISP.Exemple01.Before
{
    public class InStoreOrderService : IOrderService
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processing in-store order...");
        }

        public void CalculateDiscount()
        {
            Console.WriteLine("Calculating discount for in-store order...");
        }

        public void GenerateInvoice()
        {
            Console.WriteLine("Generating invoice for in-store order...");
        }

        public void SendEmailNotification()
        {
            // Violates ISP: In-store orders do not require email notifications.
            throw new NotImplementedException("Email notifications are not supported for in-store orders.");
        }
    }
}
