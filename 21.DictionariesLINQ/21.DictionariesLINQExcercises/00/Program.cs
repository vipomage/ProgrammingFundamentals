using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<List<string>, List<string>> myDictionary = new Dictionary<List<string>, List<string>>();


            string[] input = Console.ReadLine().Split(new[] { '=', ' ' }).ToArray();
            while ( input[0] != "end" )
            {
                string user = input[5];
                string ip = input[1];
                string message = input[3];

                myDictionary[user] = new List<string>();



                input = Console.ReadLine().Split(new[] { '=', ' ' }).ToArray();


            }
        }
    }
}
