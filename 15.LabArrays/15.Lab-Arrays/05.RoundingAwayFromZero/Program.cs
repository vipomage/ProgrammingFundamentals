using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] myNumArray = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).
                Select(decimal.Parse).ToArray();


            for (int i = 0; i < myNumArray.Length; i++)
            {
                Console.WriteLine($"{myNumArray[i]} => {Math.Round(myNumArray[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
