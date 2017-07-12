using System;
using System.Numerics;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 2; i <= input; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }
}
