namespace OCP.Exemple_01.After
{
    public class DiscountCalculator
    {
        private readonly IDiscountStrategyFactory _discountStrategyFactory;

        public DiscountCalculator()
        {
            _discountStrategyFactory = new DiscountStrategyFactory();
        }

        public decimal CalculateDiscount(string customerType, decimal totalAmount)
        {
            var discountStrategy = _discountStrategyFactory.GetDiscountStrategy(customerType);
            var discount = discountStrategy.CalculateDiscount(totalAmount);
            return discount;
        }
    }
}
