using System;
using System.Linq;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{string.Join("", Console.ReadLine().Reverse().ToArray())}");
        }
    }
}