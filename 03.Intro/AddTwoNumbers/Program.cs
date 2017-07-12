using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
        }
    }
}
