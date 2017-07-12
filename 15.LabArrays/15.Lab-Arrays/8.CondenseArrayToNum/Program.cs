using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _8.CondenseArrayToNum
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while (myInts.Length != 1)
            {
                int[] condensed = new int[myInts.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = myInts[i] + myInts[i + 1];
                }
                myInts = (int[])condensed.Clone();

            }
            if (myInts.Length == 1)
            {
                Console.WriteLine(myInts[0]);
            }
        }
    }

}
