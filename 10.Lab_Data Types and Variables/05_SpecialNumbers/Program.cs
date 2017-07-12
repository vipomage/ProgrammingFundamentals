using System;

namespace _05_SpecialNumbers
{
    class Program
    {      
        static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            bool equal = false;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (SumOfDigits(i) == 5 || SumOfDigits(i) == 7 || SumOfDigits(i) == 11)
                {
                    equal = true;
                    Console.WriteLine($"{i} -> {equal}");
                }
                else
                {
                    equal = false;
                    Console.WriteLine($"{i} -> {equal}");
                }
            }
        }
    }
}
