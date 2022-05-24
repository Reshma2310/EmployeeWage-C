using System;

Console.WriteLine("Welcome to Employee Wage Program");
EmployeeWage_C.EmpWageBuilderObject dMart = new EmployeeWage_C.EmpWageBuilderObject("DMart", 20, 6, 100);
EmployeeWage_C.EmpWageBuilderObject reliance = new EmployeeWage_C.EmpWageBuilderObject("Reliance", 18, 12, 120);
dMart.computeEmpWage();
Console.WriteLine(dMart.toString());
reliance.computeEmpWage();
Console.WriteLine(reliance.toString());