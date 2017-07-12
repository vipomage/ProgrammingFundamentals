using System;
using System.Text.RegularExpressions;

namespace _07.HideOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();
            string[] clue = Console.ReadLine().Split();
            while ( !Regex.IsMatch(map, $"\\{clue[0]}{{{clue[1]},}}") )
            {
                clue = Console.ReadLine().Split();
            }
            Console.WriteLine(
                $"Hideout found at index " +
                $"{Regex.Match(map, $"\\{clue[0]}{{{clue[1]},}}").Index}" +
                $" and it is with size {Regex.Match(map, $"\\{clue[0]}{{{clue[1]},}}").Length}!");
        }
    }
}
