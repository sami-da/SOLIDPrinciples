namespace OCP.Exemple_01.After
{
    public class DiscountStrategyFactory : IDiscountStrategyFactory
    {
        public IDiscountStrategy GetDiscountStrategy(string customerType)
        {
            switch (customerType)
            {
                case "Regular": return new RegularCustomerDiscount();
                case "Premium": return new PremiumCustomerDiscount();
                case "VIP": return new VipCustomerDiscount();
                default: return new NoDiscount();
            }
        }
    }
}
