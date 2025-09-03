namespace OCP.Exemple_01.After
{
    public class VipCustomerDiscount : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return totalAmount * 0.3m; // 30% discount
        }
    }
}