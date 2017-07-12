using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _07.MaxSequenceOIncreasingElmnts
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = Checker(inputArray);
            Array.Reverse(result);
            Console.WriteLine(string.Join(" ", result));
        }
        
        static int[] Checker(int[] arrayOfIntegers)
        {
            int start = 0;
            int length = 1;
            int longer = 1;
            int[] result = new int[1];
            for (int i = start; i < arrayOfIntegers.Length - 1; i++)
            {
                if (arrayOfIntegers[i] < arrayOfIntegers[i + 1] )
                {
                    length++;
                    if (length > result.Length && length > longer)
                    {
                        longer = length;
                        result = new int[length];
                        for (int j = 0; j < result.Length; j++)
                        {
                            result[j] += arrayOfIntegers[i - j + 1];
                        }
                    }
                }
                else
                {                    
                    length = 1;
                }
            }
            return result;
        }
    }
}
