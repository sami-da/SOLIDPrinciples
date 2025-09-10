using System;

namespace Exemple_03.After
{

    public class FinITCalculations
    {
        public double CalculateIncomeTaxForCurrentYearEmployee(Employee employee)
        {
            return employee.GetIncome() * 0.20; ;
        }
    }
}
