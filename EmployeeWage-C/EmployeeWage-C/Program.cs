namespace EmployeeWage_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.AddCompanyEmpWage("DMart", 20, 6, 100);
            empWageBuilder.AddCompanyEmpWage("Reliance", 18, 12, 120);
            empWageBuilder.ComputeEmpWage();
        }
    }
}
