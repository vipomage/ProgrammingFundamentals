using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.NetherRealms
{
    public class RealmsMain
    {
        public static void Main(string[] args)
        {
            var demons = Console.ReadLine().Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(d => d).ToArray();

            foreach ( var demon in demons )
            {
                var demonHealth = GetDemonHealth(demon);
                var demonDamage = GetDemonDamage(demon);
                Console.WriteLine($"{demon} - {demonHealth} health, {demonDamage:F2} damage");
            }
        }

        public static decimal GetDemonDamage(string demon)
        {
            var demontDamagePattern = @"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)";
            var regex = new Regex(demontDamagePattern);
            var collection = regex.Matches(demon);
            decimal damage = 0;
            foreach ( var number in collection )
                damage += decimal.Parse(number.ToString());

            foreach ( var c in demon.Where(c => c == '*' || c == '/') )
                if ( c == '*' )
                    damage *= 2;
                else
                    damage /= 2;

            return damage;
        }

        public static double GetDemonHealth(string demon)
        {
            var demonHealthPattern = @"[^\d\.\+\-\*\/\s\,]";
            var regex = new Regex(demonHealthPattern);
            var collection = regex.Matches(demon);
            double health = 0;
            foreach ( Match str in collection )
                foreach ( var c in str.ToString() )
                    health += c;

            return health;
        }
    }
}