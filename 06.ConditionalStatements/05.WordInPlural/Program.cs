using System;
using System.IO;

namespace _05.WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            int length = 0;
            if (noun.EndsWith("y"))
            {
                length = noun.Length;
                noun = noun.Remove(length - 1, 1);
                noun = noun.Insert(length - 1, "ies");
                Console.WriteLine(noun);
                goto end;
            }
            else if (noun.EndsWith("o")
                     || noun.EndsWith("ch")
                     || noun.EndsWith("s")
                     || noun.EndsWith("sh")
                     || noun.EndsWith("x")
                     || noun.EndsWith("z"))
            {
                length = noun.Length;
                noun = noun.Insert(length, "es");
                Console.WriteLine(noun);
            }
            else
            {
                length = noun.Length;
                noun = noun.Insert(length, "s");
                Console.WriteLine(noun);
            }
            end:
            ;
        }
    }
}
