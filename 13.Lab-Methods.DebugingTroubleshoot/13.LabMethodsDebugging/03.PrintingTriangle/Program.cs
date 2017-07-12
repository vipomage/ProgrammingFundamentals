using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void UpperTriangle(int x)
        {
            for (int i = 1; i < x; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{j.ToString()} ");
                }
                Console.WriteLine();
            }
        }
        static void MiddleLine(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void BottomTriangle(int x)
        {
            for (int i = x; i >= 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write($"{j.ToString()} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            UpperTriangle(n);
            MiddleLine(n);
            BottomTriangle(n);
        }
    }
}
