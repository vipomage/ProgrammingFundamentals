using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ulong> demonNameHp = new Dictionary<string, ulong>();
            Dictionary<string, decimal> demonNameDmg = new Dictionary<string, decimal>();
            string[] input = Console.ReadLine().Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(d => d).ToArray();

            foreach ( string s in input )
            {
                MatchCollection hpMatches = Regex.Matches(s, @"[^\d\.\+\-\*\/\s\,]");
                string name = String.Empty;
                foreach ( Match hpMatch in hpMatches )
                {
                    name += hpMatch.Value;
                }
                //string name = string.Join("", s.Split(new[] { '+', '-', '*', '/', '.', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ' ', '\t', '\n' },
                //    StringSplitOptions.RemoveEmptyEntries));
                MatchCollection dmgMatches = Regex.Matches(s, @"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)");

                foreach ( char c in name )
                {
                    if ( demonNameHp.ContainsKey(s) )
                    {
                        demonNameHp[s] += c;
                    }
                    else
                    {
                        demonNameHp[s] = c;
                        demonNameDmg[s] = 0;
                    }
                }
                foreach ( Match match in dmgMatches )
                {
                    demonNameDmg[s] += decimal.Parse(match.ToString());
                }
                foreach ( char c in s )
                {
                    if ( c == '/' )
                    {
                        demonNameDmg[s] /= 2;
                    }
                    if ( c == '*' )
                    {
                        demonNameDmg[s] *= 2;
                    }
                }
                if ( demonNameDmg[s] < 0 )
                {
                    demonNameDmg[s] = 0;
                }
            }
            foreach ( var kp in demonNameHp )
            {
                Console.WriteLine($"{kp.Key} - {kp.Value} health, {demonNameDmg[kp.Key]:F2} damage");
            }
        }
    }
}
//M3ph-0.5s+0.5t0.0**/
