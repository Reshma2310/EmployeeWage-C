using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_C
{
    internal class EmployeeAttendance
    {
        Random random = new Random();
        public void AttendanceCheck()
        {
            if (random.Next(0,2) == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
