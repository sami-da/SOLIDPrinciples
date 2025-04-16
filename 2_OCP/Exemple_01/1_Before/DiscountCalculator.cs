namespace OCP.Example_01.Before
{
    // This class violates the Open/Closed Principle because it requires modification
    // to add new discount types. Each time a new customer type is added, we need to
    // modify this class.
    //
    // The class is not open for extension (adding new discount types) and closed for
    // modification (changing existing code).}

    public class DiscountCalculator
    {
        public decimal CalculateDiscount(string customerType, decimal totalAmount)
        {
            if (customerType == "Regular")
            {
                return totalAmount * 0.1m; // 10% discount
            }
            else if (customerType == "Premium")
            {
                return totalAmount * 0.2m; // 20% discount
            }
            else if (customerType == "VIP")
            {
                return totalAmount * 0.3m; // 30% discount
            }
            else
            {
                return 0; // No discount
            }
        }
    }
}