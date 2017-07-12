using System;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {//INPUT
            var nPictures = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var timeToCloud = int.Parse(Console.ReadLine());
            //CALC
            var filteredPictures = (int)Math.Ceiling(nPictures * (filterFactor/100d));
            var filteringTime = (long)nPictures * filterTime;
            var uploading = (long)filteredPictures * timeToCloud ;
            var timeTotal = (filteringTime + uploading );

            //OUTPUT
            TimeSpan total = TimeSpan.FromSeconds(timeTotal);
            Console.WriteLine($"{total.Days:D1}:{total.Hours:D2}:{total.Minutes:D2}:{total.Seconds:D2}");
        }
    }
}