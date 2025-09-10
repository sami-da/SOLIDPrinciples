using System;
namespace Exemple_03.After
{
    public class Employee
    {
        private string name;
        private double income;
        private DateTime dateOfJoining;

        public Employee(string name, double income, DateTime dateOfJoining)
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
    }
}

