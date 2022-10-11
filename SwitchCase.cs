using System;

namespace DAY8
{


    public class SwitchCase
    {
        public void EmpWage()
        {
            const int Is_Full_Time = 1;
            const int Is_Part_Time = 2;
            int EmpWage_PerHr = 20;

            int EmpHrs = 0;
            int EmpWage = 0;
            int TotalHrs = 0;



            Random random = new Random();
            int EmpCheck = random.Next(0, 3);

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

            EmpWage = EmpHrs * EmpWage_PerHr;
            Console.WriteLine("Employee Wage : " + EmpWage);
        }
    }



}
