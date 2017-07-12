using System;
using System.Text.RegularExpressions;

namespace _08.Mines
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            MatchCollection collection = Regex.Matches(text, "<\\w{2}>");
            foreach ( Match match in collection )
            {
                int sum = Math.Abs(match.Value[1] - match.Value[2]);

                text = match.Index - sum < 0
                    ? text.Remove(0, sum - match.Index + 1).Insert(0, new string('_', sum - match.Index + 1))
                    : text.Remove(match.Index - sum, sum).Insert(match.Index - sum, new string('_', sum));

                text = sum + match.Index + 4 > text.Length
                    ? text.Remove(text.Length - match.Index, text.Length - match.Index - sum + 1)
                        .Insert(match.Index + 4, new string('_', text.Length - match.Index - sum + 1))
                    : text.Remove(match.Index + 4, sum).Insert(match.Index + 4, new string('_', sum));


                text = text.Replace(match.Value, new string('_', match.Value.Length));
            }
            Console.WriteLine(text);
        }
    }
}
/*
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Mines
{
    class Mines
    {
        static void Main(string[] args)
        {
            var pattern = @"<[A-Za-z]{2}>";
            var inputLine = Console.ReadLine();
            StringBuilder sb = new StringBuilder(inputLine);
            Regex regex = new Regex(pattern);

            MatchCollection minebMatches = regex.Matches(inputLine);

            foreach (Match mine in minebMatches)
            {
                var index = mine.Index;
                var firstChar = inputLine[index + 1];
                var secondChar = inputLine[index + 2];
                var minePower = Math.Abs(firstChar - secondChar);
                var destroyIndex = Math.Max(0, index - minePower);
                var destroyBeforeMine = index - destroyIndex;
                var destroyAfterMine = Math.Min(minePower, inputLine.Length -4-index);
                var destroyLength = destroyBeforeMine + 4 + destroyAfterMine;
                var replaceStr = new string('_', destroyLength);

                inputLine = inputLine.Remove(destroyIndex, destroyLength);
                inputLine = inputLine.Insert(destroyIndex, replaceStr);
              
            }
            Console.WriteLine(inputLine);
        }
    }
}
*/
