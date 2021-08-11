using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    class EmployeeWageBuilder
    {
        public string company;
        public int empWagePerHour;
        public int maxWorkingDaysInMonth;
        public int maxHoursPerMonth;
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public int empHrs = 0;
        public int empWage = 0;
        public EmployeeWageBuilder(string company, int empWagePerHour, int maxWorkingDaysInMonth, int maxHoursPerMonth)
        {
            this.company = company;
            this.empWagePerHour = empWagePerHour;
            this.maxWorkingDaysInMonth = maxWorkingDaysInMonth;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void EmployeeWage()
        {
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < maxWorkingDaysInMonth)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * empWagePerHour;
                totalEmpHrs += empHrs;
            }
            int totalEmpWage = totalEmpHrs * empWagePerHour;
            Console.WriteLine(company + " Company Employee Wage for a Month is " + totalEmpWage);
        }
    }
}