using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] myChars = new char[26];
            for (int i = 'a'; i <=122; i++)
            {
               myChars[i-97] = (char)i;
            }
            
            char[] input = Console.ReadLine().ToLower().ToArray();

            foreach (char c in input)
            {
                int index1 = Array.IndexOf(myChars,c);
                Console.WriteLine($"{c} -> {index1}");
            }

        }
    }
}
