namespace OCP.Exemple_01.After
{
    public class RegularCustomerDiscount : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return totalAmount * 0.1m; // 10% discount
        }
    }
}