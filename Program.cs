﻿using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;
        const int EMP_RATE_PER_HOUR = 20;
        public static int empHrs = 0;
        public static int empWage = 0;
        public static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Welcome to the Employee Wage Computation Program");
            Program.EmployeeWage("DMART" , 10 , 20 , 100);
            Program.EmployeeWage("BRIDGELABZ", 8 , 25, 120);


        }
        public static void EmployeeWage(String Company, int empWagePerHour, int MAX_WORKING_DAYS_IN_MONTH, int MAX_HRS_IN_MONTH)
        {
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;

                while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < MAX_WORKING_DAYS_IN_MONTH)
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
                   // Console.WriteLine("Day:" + totalWorkingDays + "Employee Work Hours:" + empHrs + "   Wage:" + empWage);
                }
                int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            // Console.WriteLine("Total Employee Wage For Month : " + totalEmpWage);
            Console.WriteLine( Company + " Comapany Employee Wage for a Month is " + totalEmpWage);

        }
    }
    }

