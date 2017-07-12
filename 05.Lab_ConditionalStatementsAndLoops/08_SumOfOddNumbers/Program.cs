using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 1;
            int oldsum = 0;

            for (int i = 0; i < input; i++)
            {
                oldsum += sum;
                Console.WriteLine(sum);
                sum += 2;
            }
            Console.WriteLine("Sum: {0}", oldsum);
        }
    }
}
