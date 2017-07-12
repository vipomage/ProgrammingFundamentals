using System;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceM = float.Parse(Console.ReadLine());
            float hours     = float.Parse(Console.ReadLine());
            float minutes   = float.Parse(Console.ReadLine());
            float seconds   = float.Parse(Console.ReadLine());


            float totalSeconds = (hours * 60) * 60 + (minutes * 60) + seconds;
            float totalMinutes = (totalSeconds / 60);
            float totalHours = totalMinutes / 60;

            //TODO Meters per second
            float meterS = distanceM / totalSeconds;
            //TODO kilometers per hour
            float kilometersH = (distanceM / 1000) / totalHours;
            //TODO miles per hour
            float milesH = (distanceM / 1609) / totalHours;
            Console.WriteLine($"{meterS}\n{kilometersH}\n{milesH}");

        }
    }
}
