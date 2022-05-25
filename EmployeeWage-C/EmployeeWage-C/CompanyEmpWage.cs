using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_C
{
    public interface ICompanyEmpWage
    {
        public void AddCompanyEmpWage(string company, int noOfWorkingDays, int maxWorkHours, int empRatePerHour);
        public void ComputeEmpWage();
    }
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour, numOfWorkingDays, maxHoursPerMonth, totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string ToString()

        {
            return "Total Employee Wage for company: " + this.company + "is : " + totalEmpWage;
        }
    }
}
