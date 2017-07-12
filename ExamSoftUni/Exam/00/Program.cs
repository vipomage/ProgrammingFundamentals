using System;
using System.Diagnostics;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal first = decimal.Parse(Console.ReadLine());
            decimal step = decimal.Parse(Console.ReadLine());
            decimal intY = decimal.Parse(Console.ReadLine());
            decimal halfn = first / 2;
            decimal output = first;
            decimal counter = 0;
            while ( true)
            {
                if (output < step)
                {
                    break;
                }
                output -= step;
                counter++;
                if (output == halfn && intY>0)
                {
                    output = Math.Floor(output / intY);
                }
            }
            Console.WriteLine(output);
            Console.WriteLine(counter);
        }
    }
}
