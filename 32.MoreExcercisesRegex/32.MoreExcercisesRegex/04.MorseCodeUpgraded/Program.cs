using System;
using System.Text.RegularExpressions;

namespace _04.MorseCodeUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            string result = String.Empty;

            foreach ( string s in input )
            {
                int sum = 0;
                MatchCollection zeroCollection = Regex.Matches(s, "0");
                MatchCollection zeroConsequtive = Regex.Matches(s, "0{2,50}");
                MatchCollection oneCollection = Regex.Matches(s, "1");
                MatchCollection oneConsequtive = Regex.Matches(s, "1{2,50}");

                sum += zeroCollection.Count * 3;
                sum += oneCollection.Count * 5;

                foreach ( Match match in zeroConsequtive )
                {
                    sum += match.Length;
                }
                foreach ( Match match in oneConsequtive )
                {
                    sum += match.Length;
                }

                result += (char)sum;
            }
            Console.WriteLine(result);
        }
    }
}
