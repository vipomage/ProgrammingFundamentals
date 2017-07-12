using System;

namespace _03.PracticeCharsStrings
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char first = Char.Parse(Console.ReadLine());
            char second = Char.Parse(Console.ReadLine());
            char third = Char.Parse(Console.ReadLine());
            string final = Console.ReadLine();

            Console.WriteLine($"{input}\n" +
                                  $"{first}\n" +
                                  $"{second}\n" +
                                  $"{third}\n" +
                                  $"{final}");
        }
    }
}