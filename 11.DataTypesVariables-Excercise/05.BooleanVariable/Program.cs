using System;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(input ? "Yes" : "No");
        }
    }
}