using System;
using System.Linq;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string foldingPart = String.Empty;

            foldingPart += string.Join(" ", input.Take(input.Length / 4).Reverse());
            foldingPart += " ";
            foldingPart += string.Join(" ", input.Reverse().Take(input.Length / 4));
            int[] foldedArray = foldingPart.Split(' ').Select(int.Parse).ToArray();

            int[] leftArray = input.Skip(input.Length / 4).Take(input.Length / 2).ToArray();

            var sum = foldedArray.Select((x, index) => x + leftArray[index]);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}