using System;

namespace DAY8
{
   public class RefractorClass
    {


        public const int IS_PART_TIME = 1;

        public const int IS_FULL_TIME = 2;

        public const int Emp_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;

        public const int MAX_HRS_IN_MONTH = 10;

        public static int ComputeEmpWage()
        {
            //Variables

            int EmpHrs = 8, totalEmpHrs = 0;

            int totalWorkingDays = 0;

            //Computation
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            { 
            totalWorkingDays++;

            Random random = new Random();

            int EmpCheck = random.Next(0, 3);
            switch (EmpCheck)
            {
                case IS_PART_TIME:

                    EmpHrs = 4; break;

                case IS_FULL_TIME:

                    EmpHrs = 8;

                    break;
                default:

                    EmpHrs = 0; break;
            }
            totalEmpHrs += EmpHrs;
            Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs:" + EmpHrs);
        }
            int totalEmpWage = totalEmpHrs * Emp_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
            return totalEmpWage;
        }
        
    }
}