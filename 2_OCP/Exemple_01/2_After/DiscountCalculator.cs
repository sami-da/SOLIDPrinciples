using OCP.Example_01.After;
using System;
using System.Collections.Generic;
namespace OCP.Exemple_01._2_After
{
    public class DiscountCalculator
    {
        private readonly IDiscountStrategy _discountStrategy;

        public DiscountCalculator(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateDiscount(decimal totalAmount)
        {
            return _discountStrategy.CalculateDiscount(totalAmount);
        }
    }
}
