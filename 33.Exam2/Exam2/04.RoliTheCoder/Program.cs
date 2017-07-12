using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.RoliTheCoder
{
    public class Event
    {
        public string EventId { get; set; }

        public string EventName { get; set; }


        public List<string> Paricipants = new List<string>();

    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Event> events = new List<Event>();

            string input = Console.ReadLine();
            while ( input.ToLower() != "time for code" )
            {
                Regex pattern = new Regex(@"(?<id>\d+)\s+#(?<eventName>\w+)(\s+(?<participants>@[A-Za-z0-9'-]+\s*)+)?");
                #region CheckingForID&Name
                bool sameId = events.Any(e => e.EventId == input.Split(' ')[0]);
                bool sameIdnEvent = events.Any(e => e.EventId == input.Split(' ')[0] && e.EventName == input.Split()[1].TrimStart('#'));


                if ( sameId && sameIdnEvent )
                {

                    foreach ( Event @event in events.Where(i => i.EventId == input.Split()[0]) )
                    {
                        MatchCollection collectedUser = Regex.Matches(input, @"@\b[\w\'\-]+");
                        foreach ( Match match in collectedUser )
                        {
                            @event.Paricipants.Add(match.Value);

                        }
                    }
                }
                #endregion
                else if ( !sameId )
                {



                    #region AddingEventID&Name


                    string IDTest = Regex.Match(input, @"\A\b([0-9]+)\b\s+#\b([\w]+)\b\s").Groups[1].ToString();
                    string NameTest = Regex.Match(input, @"\A\b([0-9]+)\b\s+#\b([\w^\d]+)\b\s").Groups[2].ToString();



                    Event party = new Event()
                    {
                        EventId = Regex.Match(input, @"\A\b([0-9]+)\b\s+#\b([\w]+)\b\s").Groups[1].ToString(),
                        EventName = Regex.Match(input, @"\A\b([0-9]+)\b\s+#\b([\w]+)\b\s").Groups[2].ToString(),
                    };

                    #endregion

                    if ( party.EventName == "" && party.EventId == "" )
                    {
                        party.EventName = input.Split()[1].TrimStart('#');
                        party.EventId = input.Split()[0];
                    }
                    else
                    {



                        #region CollectingUsers

                        MatchCollection collectedUsers = Regex.Matches(input, @"@\b[\w\'\-]+");


                        foreach ( Match user in collectedUsers )
                        {
                            party.Paricipants.Add(user.Value);
                        }


                    }
                    events.Add(party);
                    #endregion
                }

                input = Console.ReadLine();
            }
            foreach ( Event @event in events.OrderByDescending(e => e.Paricipants.Count).ThenBy(n => n.EventName) )
            {
                Console.WriteLine($"{@event.EventName} - {@event.Paricipants.Distinct().ToList().Count}");

                foreach ( var eventParicipants in @event.Paricipants.OrderBy(n => n).Distinct() )
                {
                    Console.WriteLine($@"{eventParicipants}");
                }
            }

        }
    }
}
//Event ID and EventName Regex -  ([\d])\s#([\w]+)

// Paricipant list Regex - \@[\w\'\-]+

//([\d])\s#([\w]+)(\s\@[\w\'\-]+)+