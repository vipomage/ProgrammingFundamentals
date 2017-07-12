using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            for (int d1 = n; d1 >= 1; d1--)
            {
                for (int d2 = 1; d2 <= m; d2++)
                {
                    if (sum >= max)
                    {
                        counter++;
                        break;
                    }
                    sum += (d1 * d2) * 3;
                    counter++;
                }
            }
            if (sum >= max)
            {
                Console.WriteLine($"{counter-2} combinations");
                Console.WriteLine($"Sum: {sum} >= {max}");
            }
            if (sum < max)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
