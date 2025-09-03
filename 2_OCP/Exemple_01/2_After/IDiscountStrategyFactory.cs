namespace OCP.Exemple_01.After
{
    public interface IDiscountStrategyFactory
    {
        IDiscountStrategy GetDiscountStrategy(string customerType);
    }
}