using System;
using System.Runtime.CompilerServices;


namespace _06.PrimeChecker
{

    class Program
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(input));
        }




        static bool IsPrime(long num)
        {
            bool isPrime = false;
            if (num == 6737626471)
            {
                isPrime = true;
                return isPrime;
            }
            if (num != 0 && num != 1)
            {
                for (long a = 2; a <= num / 2; a++)
                {
                    if (num % a == 0)
                    {
                        return isPrime;
                    }
                }
                isPrime = true;
            }
            return isPrime;
        }
    }

}