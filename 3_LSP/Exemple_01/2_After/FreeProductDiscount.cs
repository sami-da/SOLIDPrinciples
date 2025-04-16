namespace LSP.Exemple_01.After
{
    // Free product discount with explicit eligibility check
    public class FreeProductDiscount : IDiscount
    {
        public bool CanApplyDiscount(decimal originalPrice)
        {
            return originalPrice >= 10; // Only applicable to products $10 or more
        }

        public decimal ApplyDiscount(decimal originalPrice)
        {
            if (!CanApplyDiscount(originalPrice))
            {
                return originalPrice; // Return original price if discount can't be applied
            }

            return 0; // Free product
        }
    }
}
