using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_C
{
    public class EmployeeWageCalculation:ICompanyEmpWage
    {
        public const int isPartTime = 1, isFullTime = 2;
        private int numOfCompanies = 0, count = 0;
        List<CompanyEmpWage> companyEmpWageList = new List<CompanyEmpWage>();
        public EmployeeWageCalculation(int companies)
        {
            this.numOfCompanies = companies;
        }
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageList.Add(new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth));
            count++;
        }
        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyempWage in companyEmpWageList)
            {
                companyempWage.SetTotalEmpWage(this.ComputeEmpWage(companyempWage));                
            }
        }
        public int ComputeEmpWage(CompanyEmpWage empWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= empWage.maxHoursPerMonth && totalWorkingDays <= empWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
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
                Console.WriteLine("Day: " + totalWorkingDays + "Employee Hours: " + empHrs);
            }
            int totalWage = totalEmpHrs* empWage.empRatePerHour;
            Console.WriteLine("Total Employee Wage of company {0} is {1} ", empWage.company, totalWage);
            return totalWage;
        }          
    }
}
