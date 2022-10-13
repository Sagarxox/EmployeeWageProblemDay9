using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY9
{
    public class MultipleCompany
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        public int wages(string company, int EmpRateprHr, int NumWorkingDay, int MaxHrPrMonth)
        {
            //variable
            int Emphr = 0;
            int totalEmphr = 0;
            int totalworkingday = 0;
            Console.WriteLine("monthly wages of Employee");
            Console.WriteLine("------------------------------");
            while (totalEmphr <= MaxHrPrMonth && totalworkingday < NumWorkingDay)
            {
                totalworkingday++;
                Random random = new Random();
                int Empcheck = random.Next(0, 3);
                switch (Empcheck)
                {
                    case FULL_TIME:
                        Console.WriteLine("Employee is FullTime");
                        Emphr = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("Employee is PartTime");
                        Emphr = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        Emphr = 0;
                        break;

                }
                totalEmphr += Emphr;
                Console.WriteLine("days {0}:", totalworkingday + " Emp hour " + Emphr);

            }
            Console.WriteLine("total Employee hour is {0}", totalEmphr);

            int totalEmpwage = totalEmphr * EmpRateprHr;
            Console.WriteLine("total Employee wage for company {0} and total Employee wage {1} ", company, totalEmpwage);
            return totalEmpwage;
        }
    }
}
