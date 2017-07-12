using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;


namespace _12.MasterNumbers
{
    class Program
    {
        static void Main()

        {
            int input = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < input; i++)
            {
                if (IsPalindrome(i) && IsDivisibleBySeven(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }

        static bool ContainsEvenDigit(int input)
        {
            bool even = false;

            List<int> myInts = new List<int>();

            while (input != 0)
            {
                myInts.Add(input % 10);
                input /= 10;
            }
            foreach (int myInt in myInts)
            {
                if (myInt % 2 == 0)
                {
                    even = true;
                    break;
                }
                else
                {
                    even = false;
                }
            }
            return even;
        }

        static bool IsDivisibleBySeven(int input)
        {
            bool divisble = false;
            int sum = 0;
            while (input != 0)
            {
                sum += input % 10;
                input /= 10;
            }
            if (sum % 7 == 0)
            {
                divisble = true;
            }
            else
            {
                divisble = false;
            }
            return divisble;
        }

        static bool IsPalindrome(int input)
        {
            if (input < 0)
                return false;
            int div = 1;
            while (input / div >= 10)
            {
                div *= 10;
            }
            while (input != 0)
            {
                int l = input / div;
                int r = input % 10;
                if (l != r)
                    return false;
                input = (input % div) / 10;
                div /= 100;
            }
            return true;
        }
    }
}