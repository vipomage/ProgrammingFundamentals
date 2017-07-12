using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().ToLower().Split(new[]{' ',
                '.',
                ',',
                ':',
                ';',
                '\'',//TODO I HATE YOU
                '(',
                ')',
                '[',
                ']',
                '"',
                '\\',//TODO Hate+=1000000000000000000000;
                '/',
                '!',
                '?'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine(string.Join(", ", input.Where(a => a.Length < 5).OrderBy(a => a).Distinct()));
        }
    }
}