using ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(1, "Alice", 5000);
        fullTimeEmployee.DisplayInfo();
        Console.WriteLine();

        PartTimeEmployee partTimeEmployee = new PartTimeEmployee(2, "Bob", 20, 80);
        partTimeEmployee.DisplayInfo(); 
        Console.WriteLine();

        Console.WriteLine($"Alice's full-time employee salary: {fullTimeEmployee.CalculateSalary()} JOD");
        Console.WriteLine($"Bob's part-time employee salary: {partTimeEmployee.CalculateSalary()} JOD");
    }
}
