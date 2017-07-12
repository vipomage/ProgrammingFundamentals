using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.FootballStandings
{
    class Team
    {
        public string Name { get; set; }

        public int GoalsScored { get; set; }

        public int Points { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teamDictionary = new Dictionary<string, Team>();

            string key = Console.ReadLine();
            string keyChars = @"\\" + string.Join(@"\\", key.ToArray());

            string input = Console.ReadLine();

            while ( input.ToLower() != "final" )
            {
                input = input.Replace(key, "000");
                string[] teamSplit = Regex.Split(input.ToLower(), $@"[000](?<team>\w+)[000]");


                string firstTeam = string.Join("", teamSplit[1].Trim('0').ToUpper().ToCharArray().Reverse().ToArray());
                string[] scores = teamSplit.Last().Split(':');
                int firstTeamScore = int.Parse(scores[0].Last().ToString());
                int secondTeamScore = int.Parse(scores[1].Last().ToString());
                string secondTeam = string.Join("", teamSplit[3].Trim('0').ToUpper().ToCharArray().Reverse().ToArray());

                int firstTeamPoints = 0;
                int secondTeamPoints = 0;
                if ( firstTeamScore > secondTeamScore )
                {
                    firstTeamPoints = 3;
                    secondTeamPoints = 0;
                }
                if ( firstTeamScore < secondTeamScore )
                {
                    secondTeamPoints = 3;
                    firstTeamPoints = 0;
                }
                if ( firstTeamScore == secondTeamScore )
                {
                    firstTeamPoints = 1;
                    secondTeamPoints = 1;
                }

                Team team1 = new Team()
                {
                    GoalsScored = firstTeamScore,
                    Name = firstTeam,
                    Points = firstTeamPoints
                };

                Team team2 = new Team()
                {
                    GoalsScored = secondTeamScore,
                    Name = secondTeam,
                    Points = secondTeamPoints
                };

                if ( teamDictionary.ContainsKey(team1.Name) )
                {
                    teamDictionary[team1.Name].Points += team1.Points;
                    teamDictionary[team1.Name].GoalsScored += team1.GoalsScored;
                }
                else
                {
                    teamDictionary[team1.Name] = team1;
                }
                if ( teamDictionary.ContainsKey(team2.Name) )
                {
                    teamDictionary[team2.Name].Points += team2.Points;
                    teamDictionary[team2.Name].GoalsScored += team2.GoalsScored;
                }
                else
                {
                    teamDictionary[team2.Name] = team2;
                }
                input = Console.ReadLine();
            }
            int standing = 1;
            Console.WriteLine("League standings:");
            foreach ( KeyValuePair<string, Team> keyValuePair in teamDictionary.OrderByDescending(t => t.Value.Points).ThenBy(n => n.Value.Name) )
            {
                Console.WriteLine($"{standing}. {keyValuePair.Key} {keyValuePair.Value.Points}");
                standing++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach ( var keyValuePair in teamDictionary.OrderByDescending(g => g.Value.GoalsScored).ThenBy(n => n.Value.Name).Take(3) )
            {
                Console.WriteLine($"- {keyValuePair.Key} -> {keyValuePair.Value.GoalsScored}");
            }
        }
    }
}
