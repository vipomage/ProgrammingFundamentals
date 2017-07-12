using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new Dictionary<string, long>();
            string input = Console.ReadLine();
            while ( input != "stop" )
            {
                if ( myDictionary.ContainsKey(input) )
                {
                    myDictionary[input] += long.Parse(Console.ReadLine());
                    input = Console.ReadLine();
                }
                else
                {
                    myDictionary[input] = long.Parse(Console.ReadLine());
                    input = Console.ReadLine();
                }
            }
            foreach ( var entry in myDictionary )
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
