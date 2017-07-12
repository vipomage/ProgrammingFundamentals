using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _05.FibonacciNumbers
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(int.Parse(Console.ReadLine())));
        }


        static int Fib(int number)
        {
            int a = 0;
            int b = 1;
            for (int i = 1; i <= number; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b;
        }
    }

}