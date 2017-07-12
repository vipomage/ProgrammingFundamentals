using System;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startEndSeq = Console.ReadLine().Split(new[] { '<', '|', '\\' }, StringSplitOptions.RemoveEmptyEntries);
            Regex patternRegex = new Regex($@"{startEndSeq[0]}.*?{startEndSeq[2]}");
            string input = Console.ReadLine();

            MatchCollection collection = Regex.Matches(input, $"{patternRegex}");

            string result = String.Empty;
            foreach ( Match match in collection )
            {
                result += match.Value.Substring(startEndSeq[0].Length,
                    match.Value.Length - startEndSeq[0].Length - startEndSeq[2].Length);
            }
            Console.WriteLine(result == String.Empty ? "Empty result" : result);
        }
    }
}
