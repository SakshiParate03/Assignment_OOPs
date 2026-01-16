using HRLib;
namespace EmpApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");
            Console.WriteLine("\n----------Trainee Details----------\n");
            Trainee trainee = new Trainee();
            double sal = trainee.CalculateSalary();
            Console.WriteLine(trainee.ToString());
            Console.WriteLine("\n\n");
            Console.WriteLine("\n----------Confirmed Employee Details----------\n");
            ConfirmEmployee employee = new ConfirmEmployee();
            double salary = employee.CalculateSalary();
            Console.WriteLine($"Salary is: {salary}");
            Console.WriteLine("\n\n");
            Console.WriteLine(employee.ToString());
            Console.WriteLine("\n\n");
            Console.WriteLine("GitHub Testing.");
        }
    }
}
