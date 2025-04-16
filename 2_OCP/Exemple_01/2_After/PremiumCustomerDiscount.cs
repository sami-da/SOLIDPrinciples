namespace OCP.Example_01.After
{
    public class PremiumCustomerDiscount : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return totalAmount * 0.2m; // 20% discount
        }
    }
}