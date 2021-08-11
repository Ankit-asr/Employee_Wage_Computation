using System;
using System.Collections.Generic;

namespace Employee_Wage_Computation
{
    class Program
    {
        public static List<CompanyEmployeeWage> Company = new List<CompanyEmployeeWage>();
        public static void Main(string[] args)
        {
            EmployeeWageBuilder emp = new EmployeeWageBuilder();
            Company.Add(new CompanyEmployeeWage()
            { Company_Name = "Bridgelabz", Wage_Per_Hour = 20 , Max_Working_Days = 25, Max_Working_Hours = 120 });
            Company.Add(new CompanyEmployeeWage()
            { Company_Name = "DMART", Wage_Per_Hour = 22, Max_Working_Days = 30, Max_Working_Hours = 100 });
            Company.Add(new CompanyEmployeeWage()
            { Company_Name = "VMART", Wage_Per_Hour = 15, Max_Working_Days = 20, Max_Working_Hours = 110 });
            emp.Wage_Computation();
        }
    }
}