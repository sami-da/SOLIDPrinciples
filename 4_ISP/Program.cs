using ISP.Exemple01.After;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrderProcessor onlineOrder = new OnlineOrderService();
            onlineOrder.ProcessOrder();

            IOrderProcessor inStoreOrder = new InStoreOrderService();
            inStoreOrder.ProcessOrder();
        }
    }
}
