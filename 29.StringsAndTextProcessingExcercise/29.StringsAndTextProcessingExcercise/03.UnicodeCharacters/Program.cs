using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();

            var chars = value.Select(c => (int)c).Select(c => $@"\u{c:x4}");

            var result = string.Concat(chars);
            Console.WriteLine(result);
        }
    }
}