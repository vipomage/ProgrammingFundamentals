using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(
                DateTime.ParseExact(
                    Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture)
                    .DayOfWeek);
        }
    }
}
