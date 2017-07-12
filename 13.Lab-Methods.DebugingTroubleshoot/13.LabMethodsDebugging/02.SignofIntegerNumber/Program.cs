using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SignofIntegerNumber
{
    class Program
    {
        static void PrintSign(int input)
        {
            string result = String.Empty;
            
            if (input > 0)
            {
                result = ($"The number {input} is positive.");
            }
            if (input == 0)
            {
                result = ($"The number {input} is zero.");
            }
            else
            {
                result = ($"The number {input} is negative.");
            }
            Console.WriteLine(result);            
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintSign(input);
        }
    }
}
