using System;

namespace ISP.Exemple01.After
{
    public class InStoreOrderService : IOrderProcessor, IDiscountCalculator, IInvoiceGenerator
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
    }
}
