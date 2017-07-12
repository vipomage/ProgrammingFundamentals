using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddFilter
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> calcs = new List<int>();

            OddCheck(input, calcs);
            double average = calcs.Average();
            for ( int i = 0; i < calcs.Count; i++ )
            {
                if ( calcs[i] <= average )
                {
                    calcs[i] -= 1;
                }
                if ( calcs[i] > average )
                {
                    calcs[i] += 1;
                }
            }

            Console.WriteLine(string.Join(" ", calcs));
        }

        private static void OddCheck(List<int> input, List<int> calcs)
        {
            for ( int i = 0; i < input.Count; i++ )
            {
                if ( input[i] % 2 != 1 )
                {
                    calcs.Add(input[i]);
                }
            }
        }
    }
}
