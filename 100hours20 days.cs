using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8
{




    public class MonthlyWage2
    {
        public void Calculate2()
        {
            const int Is_Full_time = 1;
            const int Is_Part_time = 2;
            const int Emp_Rate_per_hour = 20;
            //Variables
            int Num_Of_Working_days = 20;
            int toatal_Wroking_Hrs = 100;
            int TotalWorkingDays = 0;
            int TotalHrs = 0;
            int TotalWage = 0;
            int EmpHrs = 0;
            int EmpWage = 0;
            while (TotalHrs < toatal_Wroking_Hrs && TotalWorkingDays < Num_Of_Working_days)
            {
                TotalWorkingDays++;
                Random rand = new Random();
                int EmpCheck = rand.Next(3);

                //Computation
                switch (EmpCheck)
                {
                    case Is_Full_time:
                        EmpHrs = 8;
                        break;

                    case Is_Part_time:
                        EmpHrs = 4;
                        break;

                    default:
                        EmpHrs = 0;
                        break;
                }
                TotalHrs += EmpHrs;
                EmpWage = EmpHrs * Emp_Rate_per_hour;
                TotalWage += EmpWage;
                Console.WriteLine(" employee wage " + EmpWage);

            }
            Console.WriteLine("Total working hours: {0}", TotalHrs);
            Console.WriteLine("Total Worked Days {0}", TotalWorkingDays);
            Console.WriteLine("total employee wage " + TotalWage);
        }
    }
}