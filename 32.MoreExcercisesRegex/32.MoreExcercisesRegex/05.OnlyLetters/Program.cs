using System;
using System.Text.RegularExpressions;

namespace _05.OnlyLetters
{
    class Program
    {
        static void Main()
        {
            int shrink = 0;
            string message = Console.ReadLine();

            MatchCollection matchCollection = Regex.Matches(message, "\\d+");

            foreach (Match match in matchCollection)
            {
                try
                {
                    message = message.Replace((match.Value), $"{message[match.Index + match.Value.Length - shrink]}");
                    if (match.Value.Length > 1)
                    {
                        shrink++;
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.WriteLine(message);
        }
    }
}
