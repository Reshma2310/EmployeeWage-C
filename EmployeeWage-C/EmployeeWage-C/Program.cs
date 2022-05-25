namespace EmployeeWage_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Welcome to Employee Wage Program");
            EmployeeWageCalculation empWageBuilder = new EmployeeWageCalculation();
            empWageBuilder.AddCompanyEmpWage("DMart", 20, 6, 100);
            empWageBuilder.AddCompanyEmpWage("Reliance", 18, 12, 120);
            empWageBuilder.ComputeEmpWage();*/
            Console.WriteLine("Enter number of companies for which wages have to be calculated:");
            int noOfCompanies = Convert.ToInt32(Console.ReadLine());
            EmployeeWage_C.EmployeeWageCalculation employeeWage = new EmployeeWage_C.EmployeeWageCalculation(noOfCompanies);

            for (int i = 1; i <= noOfCompanies; i++)
            {
                Console.WriteLine("Enter Company Name");
                string company = Console.ReadLine();
                Console.WriteLine("Enter Employee Wage per Hour");
                int empRatePerHour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number of Working Days of {0} Company", company);
                int numOfWorkingDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Maximum Working Hours of {0} Company", company);
                int maxHoursPerMonth = Convert.ToInt32(Console.ReadLine());
                employeeWage.AddCompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
                employeeWage.ComputeEmpWage();
            }            
        }
    }
}
