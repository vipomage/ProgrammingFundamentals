using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.KarateStrings
{
    class KarateStrings
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().ToList();
            var punch = '>';
            List<char> subLine = inputLine;
            var punchStrength = 0;

            for ( int i = 0; i < inputLine.Count - 1; i++ )
            {
                var currentChar = inputLine[i];

                if ( currentChar != punch )
                {
                    continue;
                }

                punchStrength += (int)inputLine[i + 1] - 48;
                punchStrength = Math.Min(punchStrength, inputLine.Count - 1 - i);

                while ( punchStrength > 0 )
                {
                    var count = 1;

                    if ( inputLine[i + count] != punch )
                    {
                        inputLine.RemoveAt(i + count);
                    }
                    else
                    {
                        break;
                    }

                    punchStrength--;
                }
            }
            Console.WriteLine(string.Join("", inputLine));
        }
    }
}