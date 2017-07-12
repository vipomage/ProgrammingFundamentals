using System;

namespace _07.ExchangeVariableName
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Before:\n" +
                              $"a = {b}\n" +
                              $"b = {a}\n" +
                              $"After:\n" +
                              $"a = {a}\n" +
                              $"b = {b}");
        }
    }
}
