namespace DIP.Exemple_01.Before
{
    // High-level module that directly depends on low-level modules
    public class OrderProcessor
    {
        private readonly EmailNotifier _emailNotifier;
        private readonly SqlOrderRepository _orderRepository;

        public OrderProcessor()
        {
            // Direct instantiation of concrete classes - this violates DIP
            _emailNotifier = new EmailNotifier();
            _orderRepository = new SqlOrderRepository();
        }

        public void ProcessOrder(Order order)
        {
            // Processing logic
            _orderRepository.Save(order);
            _emailNotifier.SendEmail(
                order.CustomerEmail,
                $"Your order #{order.Id} for ${order.Amount} has been processed."
            );
        }
    }
}
