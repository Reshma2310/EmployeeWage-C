using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_C
{
    internal class EmpWageBuilderArray
    {
        public const int isPartTime = 1, isFullTime = 2;
        private int numOfCompanies = 0;
        private CompanyEmpWage[] CompanyEmpWageArray;
        public EmpWageBuilderArray()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[5];
        }
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            Console.WriteLine(company);
            CompanyEmpWageArray[this.numOfCompanies] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompanies++;
        }
        public void ComputeEmpWage()
        {
            for (int i=0; i < numOfCompanies; i++)
            {
                CompanyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.CompanyEmpWageArray[i]));
                Console.WriteLine(this.CompanyEmpWageArray[i].ToString());
            }
        }        
        public int ComputeEmpWage(CompanyEmpWage empWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= empWage.maxHoursPerMonth && totalWorkingDays < empWage.numOfWorkingDays)
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
            return totalEmpHrs * empWage.empRatePerHour;            
        }
        
    }
}
