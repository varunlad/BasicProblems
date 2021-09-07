using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem
{
    class Harmonic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            float n = Single.Parse(Console.ReadLine());
            float ans = 1;
            for (float i=2; i<=n;i++)
            {
                ans = ans + (1 / i);
            }
            Console.WriteLine("Sum of Harmonics =  "+ans);
            Console.ReadLine();
        }
    }
}
