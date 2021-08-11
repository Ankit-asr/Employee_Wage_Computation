using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    class CompanyEmployeeWage
    {
        public String Company_Name { get; set; }
        public int Wage_Per_Hour { get; set; }
        public int Max_Working_Days { get; set; }
        public int Max_Working_Hours { get; set; }
        public int Total_Wage = 0;
    }
}
