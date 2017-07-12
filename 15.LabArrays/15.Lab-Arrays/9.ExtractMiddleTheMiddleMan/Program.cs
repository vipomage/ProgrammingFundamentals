using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _9.ExtractMiddleTheMiddleMan
{

    class Program
    {
        static void Main(string[] args)
        {
            bool single = false;
            bool even = false;
            bool odd = false;
            int[] myInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (myInts.Length == 1)
            {
                single = true;
            }
            if (myInts.Length % 2 == 0)
            {
                even = true;
            }
            if (myInts.Length % 2 == 1 && myInts.Length != 1)
            {
                odd = true;
            }
            if (single)
            {
                Console.WriteLine("{{ {0} }}", myInts[0]);
            }
            if (even)
            {
                Console.WriteLine("{{ {0}, {1} }}", myInts[myInts.Length / 2 - 1], myInts[myInts.Length / 2]);
            }
            if (odd)
            {
                Console.WriteLine("{{ {0}, {1}, {2} }}", myInts[myInts.Length / 2 - 1],
                                  myInts[myInts.Length / 2], myInts[myInts.Length / 2 + 1]);
            }
        }
    }

}
