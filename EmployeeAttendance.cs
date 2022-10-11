using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8
{
    public class EmployeeAttendance
    {
        public void Check()
        {
            
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);

            if (EmpCheck == 1)
            {
                Console.WriteLine("Empolyee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
