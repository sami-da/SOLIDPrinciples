using System.Collections.Generic;

namespace LSP.Exemple_01.After
{
    // Improved Order class
    public class Order
    {
        private List<Product> _products = new List<Product>();
        private IDiscount _discount;

        public Order(IDiscount discount)
        {
            _discount = discount;
        }

        public void AddProduct(string name, decimal price)
        {
            _products.Add(new Product { Name = name, Price = price });
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;

            foreach (var product in _products)
            {
                // Check if discount can be applied
                if (_discount.CanApplyDiscount(product.Price))
                {
                    total += _discount.ApplyDiscount(product.Price);
                }
                else
                {
                    total += product.Price; // Use original price if discount can't be applied
                }
            }

            return total;
        }
    }
}
