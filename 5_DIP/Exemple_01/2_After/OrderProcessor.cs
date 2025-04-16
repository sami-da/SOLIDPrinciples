namespace DIP.Exemple_01.After
{
    // High-level module depending on abstractions
    public class OrderProcessor
    {
        private readonly INotificationService _notificationService;
        private readonly IOrderRepository _orderRepository;

        // Dependencies are injected through constructor
        public OrderProcessor(
            INotificationService notificationService,
            IOrderRepository orderRepository)
        {
            _notificationService = notificationService;
            _orderRepository = orderRepository;
        }

        public void ProcessOrder(Order order)
        {
            // Processing logic
            _orderRepository.Save(order);
            _notificationService.Notify(
                order.CustomerEmail,
                $"Your order #{order.Id} for ${order.Amount} has been processed."
            );
        }
    }
}
