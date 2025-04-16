namespace OCP.Example_01.After
{
    public class NoDiscount : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return 0; // No discount
        }
    }
}