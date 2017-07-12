using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.WinningTicket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for ( int i = 0; i < tickets.Length; i++ )
            {
                if ( tickets[i].Length != 20 )
                {
                    tickets[i] = String.Empty;
                }
            }


            foreach ( string ticket in tickets )
            {
                if ( ticket == "" )
                {
                    Console.WriteLine($"invalid ticket");
                }
                else
                {
                    var collection = Regex.Matches(ticket, @"(\@{6,})|(\${6,})|(\^{6,})|(\#{6,})");

                    if ( collection.Count < 1 )
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                    if ( collection.Count > 1 )
                    {
                        foreach ( Match match in collection )
                        {
                            if ( match.Value.First() != match.NextMatch().Value.First() )
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - no match");
                                goto end;
                            }
                            else
                            {
                                goto skipper;
                            }
                        }
                    }
                    skipper:
                    {
                        foreach ( Match match in collection )
                        {
                            if ( collection.Count < 2 && match.Value.Length != 20 )
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - no match");
                                break;
                            }
                            if ( match.Length >= 10 )
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - 10{match.Value.First()} Jackpot!");
                                break;
                            }
                            if ( match.Length > 2 )
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {match.Length}{match.Value.First()}");
                                break;
                            }
                        }
                    }
                    end:
                    ;
                }
            }
        }
    }
}
/*
 *
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(',').Select(t => t.Trim()).ToList();
            var patterns = new string[] { @"@{6,10}", @"#{6,10}", @"\^{6,10}", @"\${6,10}" };

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var firstHalf = ticket.Substring(0, 10);
                var secondHalf = ticket.Substring(10);
                var isMatch = false;
                var winningSymbol = ' ';
                int countWinningSymbolFirstHalf = 0;
                int countWinningSymbolSecondtHalf = 0;

                foreach (var pattern in patterns)
                {
                    Match left = Regex.Match(firstHalf, pattern);
                    Match right = Regex.Match(secondHalf, pattern);

                    if (!left.Success || !right.Success)
                    {
                        continue;
                    }

                    winningSymbol = left.ToString()[0];
                    countWinningSymbolFirstHalf = left.Length;
                    countWinningSymbolSecondtHalf = right.Length;
                    isMatch = true;
                    break;
                }

                if (!isMatch)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }

                var winningCount = Math.Min(countWinningSymbolFirstHalf, countWinningSymbolSecondtHalf);

                Console.WriteLine((countWinningSymbolFirstHalf == 10 && countWinningSymbolSecondtHalf == 10)
                    ? $"ticket \"{ticket}\" - {winningCount}{winningSymbol} Jackpot!"
                    : $"ticket \"{ticket}\" - {winningCount}{winningSymbol}");
            }
        }
    }
}
 */
