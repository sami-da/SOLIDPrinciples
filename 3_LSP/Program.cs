//using LSP.Exemple_01.Before;
using LSP.Exemple_01.After;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemple01 Before

            //// This works fine
            //Discount standardDiscount = new Discount();
            //Order order1 = new Order(standardDiscount);
            //order1.AddProduct("Budget Item", 5.99m);
            //decimal total1 = order1.CalculateTotal(); // Works fine

            //// This throws an exception
            //Discount freeDiscount = new FreeProductDiscount();  // Using polymorphism
            //Order order2 = new Order(freeDiscount);
            //order2.AddProduct("Budget Item", 5.99m);
            //decimal total2 = order2.CalculateTotal(); // Throws InvalidOperationException

            #endregion

            #region Exemple 01 After

            IDiscount standardDiscount = new StandardDiscount();
            Order order1 = new Order(standardDiscount);
            order1.AddProduct("Budget Item", 5.99m);
            decimal total1 = order1.CalculateTotal(); // Works fine

            IDiscount freeDiscount = new FreeProductDiscount();  // Using polymorphism
            Order order2 = new Order(freeDiscount);
            order2.AddProduct("Budget Item", 5.99m);
            decimal total2 = order2.CalculateTotal();  // Works fine

            #endregion

        }
    }
}
