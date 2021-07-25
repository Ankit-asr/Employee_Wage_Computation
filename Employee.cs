using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    class Employee
    {
        //Constants
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        //Global Variables
        int empHrs = 0;
        int empWage = 0;
        /// <summary>
        /// Calculate Employee Wage for a Month
        /// </summary>
        public void EmployeeWageForMonth()
        {
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage of day:" + (day + 1) + " is : " + empWage);
            }
            Console.WriteLine("Total Employee Wage For Month : " + totalEmpWage);
        }
    }
}
