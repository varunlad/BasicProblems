using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem
{
    class CoinToss
    {
      
        static void Main(string[] args)
        {
            int head =0, tail=0 ;
            Random random = new Random();
           
            Console.WriteLine("Enter the number of times the coin flip should be performed  :");
            float num = float.Parse(Console.ReadLine());
            while (num > 0)
            {
                int x = random.Next(0, 2);
                if (x == 1)
                {
                    Console.WriteLine("Its Head");
                    head++;
                }
                else
                {
                    Console.WriteLine("Its Tail");
                    tail++;
                }
                num--;
            }

            float Percent1 = head  / num;
            float Percent2 = tail / num;
            Console.WriteLine("The Percentage of occurance of Head is :" + Percent1);
            Console.WriteLine("The Percentage of occurance of Tail is :" + Percent2);

            Console.ReadLine();
        }
    }
}
