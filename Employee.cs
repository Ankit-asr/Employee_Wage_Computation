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
        //Global Variables
        int empHrs = 0;
        int empWage = 0;
        /// <summary>
        /// Check if an Employee is Part Time or Full Time and Calculate Wage
        /// </summary>
        public void EmployeeType()
        {
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("Employee is Part Time");

            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Full Time");

            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");

            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Daily Wage of Employee is : " + empWage);
        }
    }
}
