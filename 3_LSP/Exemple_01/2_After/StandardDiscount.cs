namespace LSP.Exemple_01.After
{
    // Standard discount implementation
    public class StandardDiscount : IDiscount
    {
        public bool CanApplyDiscount(decimal originalPrice)
        {
            return true; // Can always apply standard discount
        }

        public decimal ApplyDiscount(decimal originalPrice)
        {
            return originalPrice * 0.9m; // 10% discount
        }
    }
}
