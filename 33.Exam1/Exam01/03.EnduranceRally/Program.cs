using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] driverArray = Console.ReadLine().Split();
            var drivers = new Dictionary<string, decimal>();
            var driversChkCount = new Dictionary<string, int>();
            foreach ( string s in driverArray )
            {
                drivers[s] = s.First();
                driversChkCount[s] = 0;
            }

            List<decimal> trackIndexes = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            List<int> checkPoints = Console.ReadLine().Split().Select(int.Parse).ToList();

            for ( int index = 0; index < trackIndexes.Count; index++ )
            {
                if ( checkPoints.All(chk => chk != index) )
                {
                    trackIndexes[index] *= -1M;
                }
            }
            foreach ( string driversKey in driverArray )
            {
                for ( int i = 0; i < trackIndexes.Count; i++ )
                {
                    drivers[driversKey] += trackIndexes[i];
                    if ( drivers[driversKey] < 1 )
                    {
                        break;
                    }
                    driversChkCount[driversKey]++;
                }
            }


            foreach ( KeyValuePair<string, decimal> keyValuePair in drivers )
            {
                if ( drivers[keyValuePair.Key] > 0 )
                {
                    Console.WriteLine($"{keyValuePair.Key} - fuel left {keyValuePair.Value:F2}");
                }
                else
                {
                    Console.WriteLine($"{keyValuePair.Key} - reached {driversChkCount[keyValuePair.Key]}");
                }
            }
        }
    }
}
/*
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
*/
