using System;

namespace _02.PracticeFloatingPointNumbers
{
    class Program
    {
        static void Main()
        {
            decimal input1 = decimal.Parse(Console.ReadLine());
            double input2 = double.Parse(Console.ReadLine());
            decimal input3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{input1}\n" +
                              $"{input2}\n" +
                              $"{input3}");
        }
    }
}