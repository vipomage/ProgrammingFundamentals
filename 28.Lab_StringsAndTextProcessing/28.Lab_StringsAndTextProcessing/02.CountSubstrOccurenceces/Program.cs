using System;

namespace _02.CountSubstrOccurenceces
{
    class Program
    {
        static void Main()
        {
            int index;
            int occurenceCounter = 0;
            int lastIndex = -1;

            string inputString = Console.ReadLine();
            string checkString = Console.ReadLine();

            while ( ( index = inputString.IndexOf(checkString, lastIndex + 1, StringComparison.OrdinalIgnoreCase) ) != -1 )
            {
                occurenceCounter++;
                lastIndex = index;
            }
            Console.WriteLine(occurenceCounter);
        }
    }
}
