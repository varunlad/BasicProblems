using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem
{
    class power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int ans = 1;
            for (int i=1;i<=n;i++)
            {
                 ans = 2 * ans;
                Console.WriteLine(" "+ans);
            }
            Console.ReadLine();
        }
    }
}
