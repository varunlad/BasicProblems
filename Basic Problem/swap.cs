using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem
{
    class swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int m = Convert.ToInt32(Console.ReadLine());
            int temp=n;
            n =m ;
            m = temp;
            Console.WriteLine("After Swap");
            Console.WriteLine("The first number is :"+n);
            Console.WriteLine("The second number is :" + m);
            Console.ReadLine();

        }
    }
}
