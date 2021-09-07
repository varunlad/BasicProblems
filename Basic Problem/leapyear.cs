using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem
{
    class leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year%400!=0 && year%100==0) && year % 4 == 0)
            {
                Console.WriteLine("Its a Leap Year");
            }
            else
            {
                Console.WriteLine("Its not a Leap Year");
            }
            Console.ReadLine();
        }
    }
}
