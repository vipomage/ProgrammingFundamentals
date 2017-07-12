using System;

namespace _09_RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool special = false;
            int sum =0;
            for (int num = 1; num <= n; num++)
            {
                int digit = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{digit} -> {special}");
                sum = 0;
                num = digit;
            }

        }
    }
}
