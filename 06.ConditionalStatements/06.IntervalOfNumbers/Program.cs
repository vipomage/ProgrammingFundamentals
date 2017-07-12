using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int temp =0;
            if (n1 > n2)
            {
                temp = n2;
                n2 = n1;
                n1 = temp;
            }
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
