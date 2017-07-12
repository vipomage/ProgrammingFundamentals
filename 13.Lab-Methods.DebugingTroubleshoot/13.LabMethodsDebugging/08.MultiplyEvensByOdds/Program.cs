using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MultiplyEvensByOdds
{
    class Program
    {
        static int ValeOfEvenMultiOdds(int value)
        {

            return Math.Abs(SumOfEvens(value) * SumOfOdds(value));
        }
        private static int SumOfOdds(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (Math.Abs(n) > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
        private static int SumOfEvens(int n)
        {
            int sum = 0;

            while (Math.Abs(n) > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ValeOfEvenMultiOdds(n));

        }

        private static void MyMethod()
        {
            int number = int.Parse(Console.ReadLine());
            string stringOfNumber = number.ToString();
            int  even = 0;
            int  odd = 0;
            for (int i = 0; i < stringOfNumber.Length; i++)
            {
                string singleString = Convert.ToString(stringOfNumber[i]);
                int value = int.Parse(singleString);
                if (value % 2 == 0)
                {
                    even += value;
                }
                else
                {
                    odd += value;
                }
            }
            Console.WriteLine($"Even Value = {even}");
            Console.WriteLine($"Even Value = {odd}");
            Console.WriteLine($"The result is {(even * odd)}");
        }
    }
}
