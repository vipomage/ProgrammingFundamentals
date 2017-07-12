using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseArrIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] integers = new int[n];

            for (int i = 0; i < n; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = integers.Length - 1; i >= 0; i--)
            {
                Console.Write(integers[i]);
                Console.Write(' ');

            }
            
        }
    }
}
