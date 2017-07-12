using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.EmailStatistics
{
    class EmailStatistics
    {
        static void Main(string[] args)
        {
            var pattern = @"^(?<userName>[A-Za-z]{5,})@(?<domain>[a-z]{3,}\.(bg|com|org))$";
            var emailCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> emails = new Dictionary<string, List<string>>();
            Regex regex = new Regex(pattern);

            for ( int i = 0; i < emailCount; i++ )
            {
                var inputLine = Console.ReadLine();
                Match emailMatch = regex.Match(inputLine);

                if ( !emailMatch.Success )
                {
                    continue;
                }

                var userName = emailMatch.Groups["userName"].Value;
                var domain = emailMatch.Groups["domain"].Value;

                if ( !emails.ContainsKey(domain) )
                {
                    emails[domain] = new List<string>();
                }

                if ( !emails[domain].Contains(userName) )
                {
                    emails[domain].Add(userName);
                }
            }

            emails = emails.OrderByDescending(d => d.Value.Count()).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach ( var email in emails )
            {
                var domain = email.Key;
                Console.WriteLine($"{domain}:");
                var userNames = email.Value;

                foreach ( var user in userNames )
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}