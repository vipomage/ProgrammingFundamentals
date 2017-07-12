using System;
using System.Linq;

namespace _06.Heists
{
    class Program
    {
        static void Main()
        {
            long[] jewelsNdGold = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string total = String.Empty;
            string inputLane = Console.ReadLine();
            while (inputLane != "Jail Time")
            {
                if (inputLane != "Jail Time")
                {
                    total += string.Join(" ", inputLane, "");
                }
                inputLane = Console.ReadLine();
            }
            string[] lootNdExp = total.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string loot = String.Empty;
            long expences = 0;
            for (long i = 0; i < lootNdExp.Length / 2L; i++)
            {
                loot += lootNdExp[i + i];
                expences += long.Parse(lootNdExp[1 + i + i]);

            }
            long jewels = CountForMe(loot, '%') * jewelsNdGold[0];
            long gold = CountForMe(loot, '$') * jewelsNdGold[1];

            if (jewels + gold >= expences)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", jewels + gold - expences);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", expences - (jewels + gold));
            }
        }
        static long CountForMe(string strings, char chars)
        {
            int counter = 0;
            foreach (char character in strings)
            {
                if (character == chars)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
