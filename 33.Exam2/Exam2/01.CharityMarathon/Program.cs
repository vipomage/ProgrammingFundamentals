using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            var daysDuration = int.Parse(Console.ReadLine());
            var runnersCount = int.Parse(Console.ReadLine());
            var lapsPerRunner = int.Parse(Console.ReadLine());
            var trackLength = int.Parse(Console.ReadLine());
            var trackCapacityPerDay = int.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            var maxRunnersTrackCapacity = trackCapacityPerDay * daysDuration;

            var maxRunnersCount = maxRunnersTrackCapacity >= runnersCount ? runnersCount : maxRunnersTrackCapacity;

            var totalRunKm = ( (long)maxRunnersCount * lapsPerRunner * trackLength ) / 1000;
            var moneyRaised = 1.0 * totalRunKm * moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}