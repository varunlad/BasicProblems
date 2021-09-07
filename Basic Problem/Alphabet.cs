using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problem
{
    class Alphabet
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any Alphabet: ");
            ch = Convert.ToChar(Console.ReadLine());


            // Condition for vowel checking
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel.");

            }
            else 
            {
                Console.WriteLine(ch + " is Consonant.");
            }

            Console.ReadLine();
        }
    }

}
