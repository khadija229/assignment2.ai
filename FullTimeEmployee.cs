using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class FullTimeEmployee : Employee
    {
        private decimal monthlySalary;

        public FullTimeEmployee(int id, string name, decimal monthlySalary) : base(id, name, monthlySalary)
        {
            this.monthlySalary = monthlySalary;
        }

        public override decimal CalculateSalary()
        {
            return monthlySalary;
        }

        public override void Work()
        {
            Console.WriteLine("Full-time employee is working.");
        }

        public override string EmployeeType
        {
            get { return "Full-time"; }
        }
    }
}
