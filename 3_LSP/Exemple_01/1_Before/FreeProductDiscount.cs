using System;

namespace LSP.Exemple_01.Before
{
    // Subclass for free products (violates LSP)
    public class FreeProductDiscount : Discount
    {
        public override decimal ApplyDiscount(decimal originalPrice)
        {
            if (originalPrice < 10)
            {
                // For products under $10, we don't allow free items
                throw new InvalidOperationException("Cannot apply free product discount to items under $10");
            }

            // Free product means 100% discount
            return 0;
        }
    }
}
