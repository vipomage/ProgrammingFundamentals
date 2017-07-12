using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();
            var myDict = new Dictionary<string, int>();
            foreach ( var num in input )
                if ( myDict.ContainsKey(num))
                {
                    myDict[num]++;
                }
                else
                {
                    myDict[num] = 1;
                }
            var output = new Dictionary<string,int>();          
            foreach (var i in myDict)
            {
                if (i.Value%2==1)
                {
                    output.Add(i.Key,0);
                }
            }
            Console.WriteLine(string.Join(", ", output.Keys));
        }
    }
}
