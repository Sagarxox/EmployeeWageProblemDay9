using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8
{
    public class PartTimeWage
    {
        
        
            public void Calculate()
            {
                int Is_FullTime = 1;
                int Is_PartTime = 2;
                int EmpWage_PerHr = 20;

                int EmpHrs = 0;
                int EmpWage = 0;

                Random random = new Random();
                int EmpCheck = random.Next(0, 3);

                if (EmpCheck == Is_FullTime)
                {
                    EmpHrs = 8;
                }
                else if (EmpCheck == Is_PartTime)
                {
                    EmpHrs = 4;
                }
                else
                {
                    EmpHrs = 0;
                }

                EmpWage = EmpHrs * EmpWage_PerHr;
                Console.WriteLine("Employee Wage : " + EmpWage);
            }
        
    }
}
