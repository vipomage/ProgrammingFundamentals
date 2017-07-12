using System;

namespace _01.PracticeIntegerNumbers
{
    class Program
    {
        static void Main()
        {
            sbyte input1   =   sbyte.Parse(Console.ReadLine());
            byte input2    =    byte.Parse(Console.ReadLine());
            short input3   =   short.Parse(Console.ReadLine());
            ushort input4  =  ushort.Parse(Console.ReadLine());
            uint input5    =    uint.Parse(Console.ReadLine());
            int input6     =     int.Parse(Console.ReadLine());
            long input7    =    long.Parse(Console.ReadLine());

            Console.WriteLine($"{input1}\n" +
                              $"{input2}\n" +
                              $"{input3}\n" +
                              $"{input4}\n" +
                              $"{input5}\n" +
                              $"{input6}\n" +
                              $"{input7}");
        }
    }
}