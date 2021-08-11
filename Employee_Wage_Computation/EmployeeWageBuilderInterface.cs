using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    interface EmployeeWageBuilderInterface
    {
        public void Wage_Computation();
        public void Display(CompanyEmployeeWage cmp);
    }
}
