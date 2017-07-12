using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> usernameList = new List<string>();
            var patternReg = @"\b[A-Za-z]\w{2,24}\b";
            Regex pattern = new Regex(patternReg);

            foreach ( string s in input )
            {
                Match collection = Regex.Match(s, $"{pattern}");
                if ( collection.Success )
                {
                    usernameList.Add(s);
                }
            }
            Dictionary<string, int> usernames = new Dictionary<string, int>();

            for ( int i = 0; i < usernameList.Count - 1; i += 1 )
            {

                usernames[usernameList[i] + " " + usernameList[i + 1]] =
                    usernameList[i].Length + usernameList[i + 1].Length;
            }
            foreach ( var longestKeyValuePair in usernames.OrderByDescending(pair => pair.Value) )
            {
                string[] firstNSecond = longestKeyValuePair.Key.Split();
                Console.WriteLine(firstNSecond[0] + "\n" + firstNSecond[1]);
                break;
            }



        }
    }
}
// [A-z0-9\_]{3,25}