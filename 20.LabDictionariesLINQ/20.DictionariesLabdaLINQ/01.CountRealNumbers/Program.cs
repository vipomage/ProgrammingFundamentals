using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var counts = new SortedDictionary<double, int>();

            foreach ( double num in input )
                if ( counts.ContainsKey(num) )
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            foreach (var count in counts.Keys)
            {
                Console.WriteLine($"{count} -> {counts[count]}");
            }
        }
    }
}
