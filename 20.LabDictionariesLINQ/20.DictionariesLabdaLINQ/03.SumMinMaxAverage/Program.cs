using System;
using System.Linq;

namespace _03.SumMinMaxAverage
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal[] input = new decimal[n];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(
                $"Sum = {input.Sum()}\nMin = {input.Min()}\nMax = {input.Max()}\nAverage = {input.Average()}");
        }
    }
}
