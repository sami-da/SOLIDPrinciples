using DIP.Exemple_01;
using DIP.Exemple_01.After;

namespace DIP_Tests.Exemple_01
{
    public class MockOrderRepository : IOrderRepository
    {
        public void Save(Order order)
        {
        }
    }
}
