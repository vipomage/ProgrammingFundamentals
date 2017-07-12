using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionaryUserIP = new Dictionary<string, List<string>>();
            var dictioinaryUserMessage = new Dictionary<string, List<string>>();
            List<string> users = new List<string>();

            string[] input = Console.ReadLine().Split(new[] { '=', ' ' }).ToArray();


            while ( input[0] != "end" )
            {
                string ip = input[1];
                string message = input[3];
                string user = input[5];

                if ( dictionaryUserIP.ContainsKey(user) )
                {
                    dictionaryUserIP[user].Add(ip);
                    dictioinaryUserMessage[user].Add(message);
                }
                else
                {
                    dictionaryUserIP[user] = new List<string>() { ip };
                    dictioinaryUserMessage[user] = new List<string>() { message };

                }

                input = Console.ReadLine().Split(new[] { '=', ' ' }).ToArray();
            }




        }
    }
}
