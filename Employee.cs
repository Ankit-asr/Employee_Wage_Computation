using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    class Employee
    {
        const int IS_FULL_TIME = 1;
        public void Employee_Attendance()
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            if (result == IS_FULL_TIME)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
