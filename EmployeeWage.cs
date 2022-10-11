using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8
{
    public class EmployeeWage
    {

        public void Calculate()
        {
            int Is_Full_Time = 1;
            int Emp_Rate_PerHr = 20;

            int EmpHrs ;
            int EmpWages ;


            Random random = new Random();
            int EmpCheck = random.Next(2);

            if (EmpCheck == Is_Full_Time)
            {
                EmpHrs = 8;
            }
            else
            {
                EmpHrs = 0;
            }
            EmpWages = EmpHrs * Emp_Rate_PerHr;
            Console.WriteLine("Employee Daily Wages are : " + EmpWages);
        }


    }
}
