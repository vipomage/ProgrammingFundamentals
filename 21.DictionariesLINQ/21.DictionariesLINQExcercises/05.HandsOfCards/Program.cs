using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main()
        {
            var game = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

            while ( input[0] != "stop" )
            {
                if ( input[0] == "JOKER" )
                {
                    var output = new Dictionary<string, int>();

                    foreach ( var pair in game )
                    {
                        foreach ( string cardComb in pair.Value )
                        {
                            int power = 0;
                            int type = 0;
                            int sum = 0;
                            switch ( cardComb[0] )
                            {
                                case 'A': power = 14; break;
                                case 'K': power = 13; break;
                                case 'Q': power = 12; break;
                                case 'J': power = 11; break;
                                default: power = cardComb[0] - 48; break;
                            }
                            switch ( cardComb[cardComb.Length - 1] )
                            {
                                case 'C': type = 1; break;
                                case 'D': type = 2; break;
                                case 'H': type = 3; break;
                                case 'S': type = 4; break;
                            }
                            if ( cardComb.Length > 2 )
                            {
                                power += 9;
                            }
                            sum = power * type;

                            if ( output.ContainsKey(pair.Key) )
                            {
                                output[pair.Key] += sum;
                            }
                            else
                            {
                                output[pair.Key] = sum;
                            }
                        }

                    }
                    foreach ( var outs in output )
                    {
                        Console.WriteLine($"{outs.Key}: {outs.Value}");
                    }
                    return;
                }
                List<string> cards = input[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

                if ( game.ContainsKey(input[0]) )
                {
                    foreach ( string card in cards )
                    {
                        if ( !game[input[0]].Contains(card) )
                        {
                            game[input[0]].Add(card);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    game[input[0]] = cards;

                }
                input = Console.ReadLine().Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
