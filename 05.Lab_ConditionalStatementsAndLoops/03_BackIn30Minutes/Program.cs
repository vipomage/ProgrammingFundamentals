using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            int sumMins = hours*60 + mins+30;
            int sumHours = (sumMins / 60)%24;
            int finalMins = sumMins % 60;
            Console.WriteLine("{0}:{1:D2}", sumHours, finalMins);
        }
    }
}
