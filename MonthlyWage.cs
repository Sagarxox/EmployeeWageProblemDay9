using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8
{
    public class MonthlyWage
    {

        public void Calculate()
        {
            const int Is_Full_Time = 1;
            const int Is_Part_Time = 2;
            const int Emp_Rate_per_hour = 20;
            const int Num_Of_Working_days = 20;
            //Variables

            int TotalHrs = 0;
            int EmpHrs = 0;
            int EmpWage = 0;
            int TotalWage = 0;
            for (int i = 0; i < Num_Of_Working_days; i++)
            {
                Random obj = new Random();
                int EmpCheck = obj.Next(3);

                //Computation
                switch (EmpCheck)
                {
                    case Is_Full_Time:
                        EmpHrs = 8;
                        break;

                    case Is_Part_Time:
                        EmpHrs = 4;
                        break;

                    default:
                        EmpHrs = 0;
                        break;
                }
                  
                EmpWage = EmpHrs * Emp_Rate_per_hour;
                TotalWage += EmpWage;
                Console.WriteLine(" employee wage " + EmpWage);

            }
            Console.WriteLine("total employee wage " + TotalWage);

        }



    }
}
