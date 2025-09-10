using System;

namespace Exemple_03.Before
{
    public class EmployeeService
    {
        private string name;
        private double income;
        private DateTime dateOfJoining;

        public EmployeeService(string name, double income, DateTime dateOfJoining)
        {
            this.name = name;
            this.income = income;
            this.dateOfJoining = dateOfJoining;
        }

        public string GetName()
        {
            return name;
        }

        public double GetIncome()
        {
            return income;
        }

        public DateTime GetDateOfJoining()
        {
            return dateOfJoining;
        }

        public bool IsPromotionIsDueThisYear()
        {
            int yearsWorked = DateTime.Now.Year - dateOfJoining.Year;
            return yearsWorked > 0 && yearsWorked % 5 == 0;
        }

        public double CalculateIncomeTaxForCurrentYear()
        {
            return income * 0.20;
        }
    }
}