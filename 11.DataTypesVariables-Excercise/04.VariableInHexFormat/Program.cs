using System;

namespace _04.VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int decValue = Convert.ToInt32(input, 16);

            Console.WriteLine(decValue);
        }
    }
}
