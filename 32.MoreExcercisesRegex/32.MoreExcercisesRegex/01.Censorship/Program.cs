using System;
using System.Text.RegularExpressions;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex($"{Console.ReadLine()}");
            string[] text = Console.ReadLine().Split();

            for ( int i = 0; i < text.Length; i++ )
            {
                if ( Regex.IsMatch(text[i], $"{pattern}") )
                {
                    text[i] = text[i].Replace($"{pattern}", new string('*', $"{pattern}".Length));
                }
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
