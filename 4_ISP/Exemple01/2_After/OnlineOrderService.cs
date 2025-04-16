using System;

namespace ISP.Exemple01.After
{
    public class OnlineOrderService : IOrderProcessor, IDiscountCalculator, IInvoiceGenerator, IEmailNotifier
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processing online order...");
        }

        public void CalculateDiscount()
        {
            Console.WriteLine("Calculating discount for online order...");
        }

        public void GenerateInvoice()
        {
            Console.WriteLine("Generating invoice for online order...");
        }

        public void SendEmailNotification()
        {
            Console.WriteLine("Sending email notification for online order...");
        }
    }
}
