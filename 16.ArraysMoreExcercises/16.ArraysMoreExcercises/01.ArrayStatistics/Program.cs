using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = input.Sum();
            int maxValue = input.Max();
            int minValue = input.Min();
            double average = input.Average();
           
            Console.WriteLine($"Min = {minValue}\nMax = {maxValue}\nSum = {sum}\nAverage = {average}");
        }
    }
}
