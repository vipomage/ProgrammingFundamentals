using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ProblemX
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= size; rows++)// ROWS
            {
                for (int cols = 1; cols <= size; cols++)//COLS
                {
                    if (rows == cols || cols == (size + 1) - rows)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}