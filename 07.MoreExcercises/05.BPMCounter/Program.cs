using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            double   bpm   = double.Parse(Console.ReadLine());
            double   beats = double.Parse(Console.ReadLine());

            double bars = beats / 4;
            double time = ((beats)/bpm)*60;
            TimeSpan minSpan = TimeSpan.FromSeconds(time);
            Console.WriteLine($"{Math.Round(bars, 1)} bars - {minSpan.Minutes}m {minSpan.Seconds}s");
        }
    }
}