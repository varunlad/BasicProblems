using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem
{
    class Quotientand_Remainder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Divisor");
            int m = Convert.ToInt32(Console.ReadLine());
            int quotient = n / m;
            int remainder = n % m;
            Console.WriteLine("The quotient is : "+quotient);
            Console.WriteLine("The Remainder is : "+remainder );
            Console.ReadLine();

        }
    }
}
