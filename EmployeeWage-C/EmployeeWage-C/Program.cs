using System;

Console.WriteLine("Welcome to Employee Wage Program");
EmployeeWage_C.EmployeeWageCalculation calculation = new EmployeeWage_C.EmployeeWageCalculation();
calculation.AttendanceCheck();
calculation.DailyWage();
calculation.PartTimeWage();
calculation.WorkHoursWage();