using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_C
{
    internal class EmployeeAttendance
    {
        int fullTimeHours = 8, partTimeHours = 4, perHourWage = 20;
        int dailyWage,partTimeWage,empWorkHours;

        Random random = new Random();
        const int isFullTime = 1, isPartTime = 2;
        public void AttendanceCheck()
        {
            if (random.Next(0,2) == 0)
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is present");
            }
        }
        public void DailyWage()
        {
            dailyWage = fullTimeHours * perHourWage;
            Console.WriteLine("Daily Wage of Full Time Employee is " + dailyWage);
        }
        public void PartTimeWage()
        {
            partTimeWage = partTimeHours * perHourWage;
            Console.WriteLine("Daily Wage of Part Time Employee is " + partTimeWage);
        }
        public void WorkHoursWage()
        {
            int employee = random.Next(0, 3);
            switch (employee)
            {
                case isFullTime: empWorkHours = 8;
                    break;
                case isPartTime: empWorkHours = 4;
                    break;
                    default: empWorkHours = 0;
                    break;
            }
            int empWage = empWorkHours * perHourWage;
            Console.WriteLine("Employee wage is {0} for total working hours {1}", empWage, empWorkHours);
        }
    }
}
