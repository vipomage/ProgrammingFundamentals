using System;

namespace _14.IntegerToHexBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(input, 16).ToUpper());
            Console.WriteLine(Convert.ToString(input, 2).ToUpper());
        }
    }
}
