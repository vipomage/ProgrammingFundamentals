using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.CubicMessages
{
    class Message
    {
        public string msg { get; set; }

        public int key { get; set; }

        public string verifier { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Message> messages = new List<Message>();

            string input = Console.ReadLine();
            while ( input != "Over!" )
            {
                string message = input;
                int key = int.Parse(Console.ReadLine());

                Regex wordmatch = new Regex($"^(?<firstD>[0-9]+)(?<word>[A-Za-z]+)(?<secondD>[^a-zA-Z]*)$",
                    RegexOptions.IgnoreCase);
                Regex digitsmatch = new Regex("[\\d]+");

                MatchCollection match = Regex.Matches(message, $"{wordmatch}");

                string text = String.Empty;

                foreach ( Match match1 in match )
                {
                    if ( match1.Success && match1.Groups["word"].Value.Length == key )
                    {
                        text = match1.Groups["word"].Value;
                        List<int> digits = new List<int>();

                        foreach ( char c in match1.Groups["firstD"].Value )
                        {
                            digits.Add(c - 48);
                        }
                        foreach ( char c in match1.Groups["secondD"].Value.SkipWhile(c => c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9') )
                        {
                            digits.Add(c - 48);
                        }


                        string verifier = string.Empty;

                        foreach ( int index in digits )
                        {
                            if ( index < text.Length && index >= 0 )
                            {
                                verifier += text[index];
                            }
                            else
                            {
                                verifier += ' ';
                            }
                        }


                        messages.Add(new Message()
                        {
                            msg = text,
                            key = key,
                            verifier = verifier
                        });
                    }
                }


                input = Console.ReadLine();
            }
            foreach ( Message message in messages )
            {
                Console.WriteLine($"{message.msg} == {message.verifier}");
            }
        }
    }
}
