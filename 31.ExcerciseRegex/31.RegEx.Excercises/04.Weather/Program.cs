using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = new Regex(@"[A-Z]{2}[\d]{2}[.][\d]+[A-z]+\|");
            SortedDictionary<string, decimal> averageTemp = new SortedDictionary<string, decimal>();
            SortedDictionary<string, string> weather = new SortedDictionary<string, string>();

            string input = Console.ReadLine();
            while ( input.ToLower() != "end" )
            {
                MatchCollection matches = Regex.Matches(input, $"{pattern}");
                if ( matches.Count > 0 && input.ToLower() != "end" )
                {
                    averageTemp[matches[0].Value.Substring(0, 2)] = decimal.Parse(Regex.Match(input, "\\d+.\\d+").ToString());
                    weather[matches[0].Value.Substring(0, 2)] = Regex.Match(input, "[A-z]+\\|").ToString().TrimEnd('|');
                }
                input = Console.ReadLine();
            }
            foreach ( var dataKey in averageTemp.OrderBy(pair => pair.Key).ThenBy(pair => pair.Value) )
            {
                decimal value = dataKey.Value;
                string forecast = weather[dataKey.Key]; //TODO FIX Forecast Result;

                Console.WriteLine($"{dataKey.Key} => {value:F2} => {forecast}");
            }
        }
    }
}