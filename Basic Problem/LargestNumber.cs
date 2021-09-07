using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem
{
    class LargestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int c= Convert.ToInt32(Console.ReadLine());
            if (a>b && a>c)
            {
                Console.WriteLine(a+" is the Largest number");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine(b+ " is the Largest number");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c + " is the Largest number");
            }
            Console.ReadLine();
        }
    }
}
