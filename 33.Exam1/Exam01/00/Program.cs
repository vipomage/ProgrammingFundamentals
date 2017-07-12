using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] racers = Console.ReadLine().Split(' ').ToArray();
            decimal[] terrLayout = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            int[] checkPoints = Console.ReadLine().Split(' ').Select(int.Parse).Select(x => Math.Abs(x)).ToArray();

            foreach ( var racer in racers )
            {
                string message;
                decimal fuel = racer[0];
                int checkPointsCounter = 0;

                for ( int i = 0; i < terrLayout.Length; i++ )
                {
                    bool isEqual = checkPoints.Any(t => i == t);

                    if ( isEqual )
                    {
                        fuel += terrLayout[i];
                    }
                    else
                    {
                        fuel -= terrLayout[i];
                    }

                    if ( fuel > 0 )
                    {
                        checkPointsCounter++;
                    }
                    else
                    {
                        message = $"{racer} - reached {checkPointsCounter}";
                        Console.WriteLine(message);
                        break;
                    }

                }
                if (fuel <= 0) continue;
                message = $"{racer} - fuel left {fuel:f2}";
                Console.WriteLine(message);
            }

        }
    }
}