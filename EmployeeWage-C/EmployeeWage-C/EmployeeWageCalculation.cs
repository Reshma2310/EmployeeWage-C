using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_C
{
    internal class EmployeeWageCalculation
    {
        public const int isFullTime = 1, isPartTime = 2;
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        Random random = new Random();

        public void EmployeeWages()
        {
            Console.WriteLine("Enter Company Name");
            string company = Console.ReadLine();
            Console.WriteLine("Enter Employee Wage per Hour");
            int empRatePerHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of Working Days of {0} Company", company);
            int numOfWorkingDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Maximum Working Hours of {0} Company", company);
            int maxHoursPerMonth = Convert.ToInt32(Console.ReadLine());
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isPartTime:
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day {0} Working Hours are {1}", totalWorkingDays, empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee wage for Company {0} is {1}", company, totalEmpWage);
        }
    }
}