using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem
{
    class Factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            float n = Single.Parse(Console.ReadLine());
            Console.WriteLine("The Prime Factors are ");
            for (int i=2; i<=n;i++)
            {
                if (n % i == 0) 
                {
                    Console.WriteLine(" "+i);
                    n = n / i;
                }
               
            }
            Console.ReadLine();
        }
     }
}
