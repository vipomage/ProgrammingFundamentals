using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input,@"\s([a-z]+[\w\.\-_])+@([\w]+[\.\-_])+[\w]+",RegexOptions.ExplicitCapture);

            foreach ( Match match1 in matches )
            {
                Console.WriteLine(match1.Value.TrimEnd(' ').TrimStart(' '));
            }
        }
    }
}