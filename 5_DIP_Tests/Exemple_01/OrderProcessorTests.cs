using DIP.Exemple_01;
using DIP.Exemple_01.After;
using Xunit;

namespace DIP_Tests.Exemple_01
{

    // Unit test example
    public class OrderProcessorTests
    {
        [Fact]
        public void ProcessOrder_ShouldSendNotification()
        {
            // Arrange
            var mockNotifier = new MockNotificationService();
            var mockRepository = new MockOrderRepository();
            var orderProcessor = new OrderProcessor(mockNotifier, mockRepository);
            var order = new Order
            {
                Id = 1,
                CustomerEmail = "test@example.com",
                Amount = 100m
            };

            // Act
            orderProcessor.ProcessOrder(order);

            // Assert
            Assert.Single(mockNotifier.SentNotifications);
            Assert.Contains("test@example.com", mockNotifier.SentNotifications[0]);
        }
    }
}
