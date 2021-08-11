using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    class EmployeeWageBuilder
    {
        Program program = new Program();
        public int Days = 1;
        public int Emp_Hrs = 0;
        public int Working_Hrs = 0;
        public String Choose = "";
        public int counter = 0;
        public void Wage_Computation()
        {
            EmployeeWageBuilder emp = new EmployeeWageBuilder();
            CompanyEmployeeWage obj = new CompanyEmployeeWage();
            foreach (var data in Program.Company)
            {
                while (Days <= data.Max_Working_Days && Working_Hrs <= data.Max_Working_Hours)
                {
                    Random random = new Random();
                    int Emp_Check = random.Next(0, 2);
                    if (Emp_Check == 0)
                    {
                        Choose = "Part_Time";
                    }
                    else
                    {
                        Choose = "Full_Time";
                    }

                    switch (Choose)
                    {
                        case "Part_Time":
                            Emp_Hrs = 4;
                            Console.WriteLine("Employee is Absent" + "       " + "Employee Hrs is : " + Emp_Hrs);
                            break;
                        case "Full_Time":
                            Emp_Hrs = 8;
                            Console.WriteLine("Employee is Present" + "      " + "Employee Hrs is : " + Emp_Hrs);
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    Days++;
                    Working_Hrs = Working_Hrs + Emp_Hrs;
                    data.Total_Wage = Working_Hrs * data.Wage_Per_Hour;
                }
                Days = 0;
                Working_Hrs = 0;
                emp.Display(data);
            }
        }
        public void Display(CompanyEmployeeWage cmp)
        {
            Console.WriteLine("The Company " + cmp.Company_Name + " has a total Employee Wage of " + cmp.Total_Wage);
            Console.WriteLine("  ");
        }
    }
}