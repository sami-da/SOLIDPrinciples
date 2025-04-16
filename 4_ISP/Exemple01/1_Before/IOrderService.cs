namespace ISP.Exemple01.Before
{
    public interface IOrderService
    {
        void ProcessOrder();
        void CalculateDiscount();
        void GenerateInvoice();
        void SendEmailNotification();
    }
}
