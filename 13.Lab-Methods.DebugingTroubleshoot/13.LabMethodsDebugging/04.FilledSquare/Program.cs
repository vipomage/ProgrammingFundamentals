using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FilledSquare
{
    class Program
    {
        static void Border(int n)
        {
            Console.WriteLine($"{new string('-', n * 2)}");
        }
        static void MiddleRows(int n)
        {
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("-");
                for (int i = 1; i <= (n * 2) - 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write(@"\");
                    }
                }
                Console.Write('-');
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Border(n);
            MiddleRows(n);
            Border(n);
        }
    }
}
