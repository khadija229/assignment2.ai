using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public abstract class Employee : IWorkable
    {
        private decimal _salary;
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Salary
        {
            get { return _salary; }
            private set { _salary = value; }
        }

        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            _salary = salary;
        }

        protected void UpdateSalary(decimal newSalary)
        {
            _salary = newSalary;
        }

        public abstract decimal CalculateSalary();
        public abstract void Work();
        public abstract string EmployeeType { get; }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
            Console.WriteLine($"Type: {EmployeeType}");
            Console.WriteLine($"Salary: {Salary} JOD");
        }
    }
}
