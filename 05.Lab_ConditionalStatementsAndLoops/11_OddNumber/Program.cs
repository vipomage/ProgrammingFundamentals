using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            input:
            int input = int.Parse(Console.ReadLine());

            if (input %2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                goto input;
            }
            else
            {
                Console.WriteLine("The number is: {0}",Math.Abs(input));
            }
        }
    }
}
