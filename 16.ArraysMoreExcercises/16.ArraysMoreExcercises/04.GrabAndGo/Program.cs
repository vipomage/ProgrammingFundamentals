using System;
using System.Linq;

namespace _04.GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            long[] input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int lastIndex = -1;
            long sum = 0;
            for (int i = input.Length-1; i >= 0; i--)
            {
                found = input[i].Equals(number);
                if (found )
                {
                    lastIndex = i;
                    goto calculations;
                }
            }
            if(!found)
            {
                Console.WriteLine($"No occurrences were found!");
                return;
            }              
            calculations:
            if ( found || sum == input[0])
            {
                for (int i = 0; i < lastIndex; i++)
                {
                    sum += input[i];                   
                }
            }
            
            Console.WriteLine(sum);
        }
    }

}
