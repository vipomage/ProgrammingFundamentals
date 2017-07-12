using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNums
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<int> reversedList = new List<int>();
            foreach ( string s in input )
            {
                List<int> single = new List<int>();
                foreach ( char ch in s )
                {
                    single.Add((int)Char.GetNumericValue(ch));
                }
                single.Reverse();
                string num = String.Empty;
                foreach ( var i in single )
                {
                    num += i;
                }
                reversedList.Add(int.Parse(num));
                single = null;
            }

            Console.WriteLine(reversedList.Sum());
        }
    }
}

