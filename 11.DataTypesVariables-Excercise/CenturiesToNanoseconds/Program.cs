using System;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            long years = input * 10;
            long days = (years * 365242);
            TimeSpan output = TimeSpan.FromDays(days/100);

            Console.WriteLine($"{input} centuries " +
                              $"= {years * 10} years " +
                              $"= {days / 100} days " +
                              $"= {output.TotalHours} hours " +
                              $"= {output.TotalMinutes} minutes " +
                              $"= {output.TotalSeconds} seconds " +
                              $"= {output.TotalMilliseconds} milliseconds " +
                              $"= {output.TotalMilliseconds}000 microseconds " +
                              $"= {output.TotalMilliseconds}000000 nanoseconds");
        }
    }
}