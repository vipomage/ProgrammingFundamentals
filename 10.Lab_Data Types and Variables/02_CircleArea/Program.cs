using System;

namespace _02_CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI*radius*radius:F12}");
        }
    }
}