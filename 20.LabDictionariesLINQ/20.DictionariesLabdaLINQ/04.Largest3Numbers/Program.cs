using System;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ", input.OrderByDescending(x => x).Take(3)));
        }
    }
}