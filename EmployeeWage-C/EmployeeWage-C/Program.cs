using System;
using EmployeeWage_C;

Console.WriteLine("Welcome to Employee Wage Program");
EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 6, 100);
EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 18, 12, 120);
dMart.computeEmpWage();
Console.WriteLine(dMart.toString());
reliance.computeEmpWage();
Console.WriteLine(reliance.toString());