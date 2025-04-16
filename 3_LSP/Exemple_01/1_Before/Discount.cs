namespace LSP.Exemple_01.Before
{
    // Base class representing a standard discount
    public class Discount
    {
        public virtual decimal ApplyDiscount(decimal originalPrice)
        {
            // Standard 10% discount
            return originalPrice * 0.9m;
        }
    }
}
