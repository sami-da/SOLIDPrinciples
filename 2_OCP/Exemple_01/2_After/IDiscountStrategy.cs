namespace OCP.Example_01.After
{
    // This interface allows us to define a contract for discount strategies.
    // Each discount strategy can be implemented in its own class, making it easy
    // to add new discount types without modifying existing code.
    public interface IDiscountStrategy
    {
        decimal CalculateDiscount(decimal totalAmount);
    }
}