namespace LSP.Exemple_01.Before
{
    // Subclass for special promotions
    public class SpecialPromoDiscount : Discount
    {
        public override decimal ApplyDiscount(decimal originalPrice)
        {
            // Special promotion gives 20% discount
            return originalPrice * 0.8m;
        }
    }
}
