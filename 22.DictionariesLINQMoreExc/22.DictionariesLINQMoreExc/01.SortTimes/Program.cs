using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TimeSpan> dateTimes = new List<TimeSpan>();
            string[] inputs = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);


            foreach ( string input in inputs )
            {
                int[] timeArray = input.Split(':').Select(int.Parse).ToArray();
                TimeSpan interval = new TimeSpan(0, timeArray[0], timeArray[1], 0);
                dateTimes.Add(interval);
            }
            dateTimes.Sort();
            int count = 0;
            foreach ( TimeSpan time in dateTimes )
            {
                count++;
                if ( count == dateTimes.Count )
                {
                    Console.Write($"{time.Hours:D2}:{time.Minutes:D2}");
                }
                else
                {
                    Console.Write($"{time.Hours:D2}:{time.Minutes:D2}");
                    Console.Write(", ");
                }
            }
        }
    }
}