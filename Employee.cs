﻿using System;
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
        const int MAX_HRS_IN_MONTH = 100;
        //Global Variables
        int empHrs = 0;
        int empWage = 0;
        /// <summary>
        /// Calculate Employee Wage for a Month based on condition
        /// </summary>
        public void ConditionalWage()
        {
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + "Employee Work Hours:" + empHrs + "   Wage:" + empWage);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage For Month : " + totalEmpWage);
        }
    }
}
