using System.Collections.Generic;

namespace LSP.Exemple_01.Before
{
    // Order processing
    public class Order
    {
        private List<Product> _products = new List<Product>();
        private Discount _discount;

        public Order(Discount discount)
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
                // This might throw an exception with FreeProductDiscount
                decimal discountedPrice = _discount.ApplyDiscount(product.Price);
                total += discountedPrice;
            }

            return total;
        }
    }
}
