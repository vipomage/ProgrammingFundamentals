using System;
using System.Linq;

namespace _06.MaxSeqOfEqualEllmnts
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] result = Checker(inputArray);
            Console.WriteLine(string.Join(" ", result));
        }

        static string[] Checker(int[] arrayOfIntegers)
        {
            int start = 1;
            int length = 1;
            string[] result = new string[1];

            for (int i = start; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] == arrayOfIntegers[i - 1])
                {
                    length++;
                    if (length > result.Length)
                    {
                        result = new string[length];
                        for (int j = 0; j < result.Length; j++)
                        {
                            result[j] += arrayOfIntegers[i];
                        }
                    }
                }
                else
                {
                    start = arrayOfIntegers[i];
                    length = 1;
                }
            }
            return result;
        }
    }

}