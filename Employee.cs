using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    class Employee
    {
        //Constants
        const int IS_FULL_TIME = 1;
        const int EMP_RATE_PER_HOUR = 20;
        //Global Variables
        int empHrs = 0;
        int empWage = 0;
        /// <summary>
        /// Check daliy Wage of an Employee
        /// </summary>
        public void DailyEmployeeWage()
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            if (result == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Daily Wage of Employee is : " + empWage);
        }
    }
}
