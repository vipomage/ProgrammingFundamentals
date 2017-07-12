using System;

namespace _17.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                char c = Convert.ToChar(i);
                Console.Write($"{c} ");
            }
        }
    }
}
