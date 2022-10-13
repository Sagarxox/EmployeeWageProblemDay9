using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \t Practice problem day 8");
            Console.WriteLine("\n --------------------------\n");


           MultipleCompany company1 = new MultipleCompany();
           company1.wages("Dmart", 20, 12, 30);
            MultipleCompany company2 = new MultipleCompany();
            company2.wages("jio", 19, 10, 20);

        }
    }
}
