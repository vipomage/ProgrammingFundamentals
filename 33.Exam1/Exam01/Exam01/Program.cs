using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime leaveTime = DateTime.ParseExact(Console.ReadLine(), "H:mm:ss", null);

            ulong steps = ulong.Parse(Console.ReadLine()) % 86400; ;
            ulong secEachStep = ulong.Parse(Console.ReadLine()) % 86400; ;

            ulong totalSeconds = secEachStep * steps;
            leaveTime = leaveTime.AddSeconds(totalSeconds);
            Console.WriteLine($"Time Arrival: {leaveTime.Hour:D2}:{leaveTime.Minute:D2}:{leaveTime.Second:D2}");
        }
    }
}
