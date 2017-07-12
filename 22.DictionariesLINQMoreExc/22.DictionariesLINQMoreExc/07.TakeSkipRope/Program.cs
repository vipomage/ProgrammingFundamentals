using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> chars = new List<char>();
            List<char> charsInts = new List<char>();
            List<char> skipList = new List<char>();
            List<char> takeList = new List<char>();
            Dictionary<List<char>, List<char>> myDictionary = new Dictionary<List<char>, List<char>>() { { skipList, takeList } };


            string input = Console.ReadLine();
            //SPLITING numbers and characters
            foreach ( char c in input )
            {
                if ( c > 47 && c < 58 )
                {
                    charsInts.Add(c);
                }
                else
                {
                    chars.Add(c);
                }
            }
            int counter = 0;
            //Splitting numbers to takelist and skiplist

            foreach ( char charsInt in charsInts )
            {
                counter++;
                if ( counter % 2 == 0 )
                {
                    skipList.Add(Convert.ToChar(charsInt));
                }
                else
                {
                    takeList.Add(Convert.ToChar(charsInt));
                }
            }
            string result = null;
            int total = 0;
            for ( int i = 0; i < skipList.Count; i++ )
            {//Hate++
                int skip = skipList[i] - 48;
                int take = takeList[i] - 48;
                result += new string(chars.Skip(total).Take(take).ToArray());
                total += skip + take;
            }
            Console.WriteLine(result);

        }

    }
}
