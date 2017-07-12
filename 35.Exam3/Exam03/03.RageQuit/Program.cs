using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.CommandInterpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            MatchCollection collection = Regex.Matches(input, @"([\d]+)");

            StringBuilder output = new StringBuilder();
            int lastIndex = 0;

            foreach ( Match match in collection )
            {
                for ( int i = 0; i < int.Parse(match.Value); i++ )
                {
                    for ( int j = lastIndex; j < match.Index; j++ )
                    {
                        output.Append(input[j]);
                    }
                }
                lastIndex = match.Index + match.Value.Length;
            }
            var outputStr = output.ToString();
            var uniqueSymbolCount = outputStr.Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbolCount}");
            Console.WriteLine(output.ToString().ToUpper());
        }
    }
}