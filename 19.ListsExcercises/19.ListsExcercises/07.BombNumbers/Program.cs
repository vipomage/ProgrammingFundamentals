using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while ( input.Contains(int.Parse(command[0])) )
            {
                int indexOfBomb = input.IndexOf(int.Parse(command[0]));
                int powerOfbomb = int.Parse(command[1]);

                int startPos = indexOfBomb - powerOfbomb;
                try
                {
                    if ( startPos <= 0 )
                    {
                        startPos = 0;
                    }
                    input.RemoveRange(startPos, powerOfbomb * 2 + 1);
                }
                catch ( Exception )
                {
                    input.RemoveRange(startPos, input.Count - startPos);
                }
            }
            Console.WriteLine(input.Sum());
        }
    }
}
