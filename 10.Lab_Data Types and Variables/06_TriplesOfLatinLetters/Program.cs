using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char a = 'a'; a <= n + 97 - 1; a++)
            {
                for (char b = 'a'; b <= n + 97 - 1; b++)
                {
                    for (char c = 'a'; c <= n + 97 - 1; c++)
                    {
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
