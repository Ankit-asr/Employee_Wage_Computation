using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeWageBuilder dmart = new EmployeeWageBuilder("DMART", 10, 20, 100);
            EmployeeWageBuilder bridge = new EmployeeWageBuilder("BRIDGELABZ", 12, 25, 120);
            dmart.EmployeeWage();
            bridge.EmployeeWage();

        }
    }
}