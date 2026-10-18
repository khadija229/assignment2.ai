using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class PartTimeEmployee : Employee
    {
        private decimal hourlyRate;
        private int hoursWorked;
        public PartTimeEmployee(int id, string name, decimal hourlyRate, int hoursWorked) : base(id, name, hourlyRate * hoursWorked)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }
        public override decimal CalculateSalary()
        {
            return hourlyRate * hoursWorked;
        }
        public override void Work()
        {
            Console.WriteLine("Part-time employee is working.");
        }
        public override string EmployeeType
        {
            get { return "Part-time"; }
        }
    
    }
}
