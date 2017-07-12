using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();
           
            Random rnd = new Random();
            for ( int pos1 = 0  ; pos1 < words.Length; pos1++ )
            {
                int pos2 = rnd.Next(words.Length);
                if (pos2!=pos1)
                {
                    var old = words[pos1];
                    words[pos1] = words[pos2];
                    words[pos2] = old;
                }
            }
            Console.WriteLine(string.Join("\r\n", words));
        }
    }
}
