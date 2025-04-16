namespace LSP.Exemple_01.After
{
    // Special promotion discount
    public class SpecialPromoDiscount : IDiscount
    {
        public bool CanApplyDiscount(decimal originalPrice)
        {
            return true; // Can always apply special discount
        }

        public decimal ApplyDiscount(decimal originalPrice)
        {
            return originalPrice * 0.8m; // 20% discount
        }
    }
}
