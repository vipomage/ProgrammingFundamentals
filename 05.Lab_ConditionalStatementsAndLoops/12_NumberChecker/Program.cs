using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            try
            {
                input = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
