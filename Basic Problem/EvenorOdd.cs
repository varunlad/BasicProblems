using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem
{
    class EvenorOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("Its an even number");
            }
            else 
            {
                Console.WriteLine("Its an Odd number");
            }
            Console.ReadLine();
        }
    }
}
