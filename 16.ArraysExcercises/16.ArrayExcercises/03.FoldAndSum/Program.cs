using System;
using System.Linq;


namespace _03.FoldAndSum
{

    class Program
    {
        static void Main()
        {
            int[] myInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstNdLast = new int[myInts.Length / 2];
            int[] middleInts = new int[myInts.Length / 2];
            for (int j = 0; j < firstNdLast.Length / 2; j++)
            {
                firstNdLast[j] = myInts[j];
                firstNdLast[firstNdLast.Length - 1 - j] = myInts[myInts.Length - 1 - j];
                middleInts[j] = myInts[myInts.Length / 4 + j];
                middleInts[middleInts.Length - 1 - j] =
                    myInts[(myInts.Length / 2) + middleInts.Length / 2 - 1 - j];
            }
            int[] firstHalf = new int[firstNdLast.Length / 2];
            for (int i = 0; i < firstNdLast.Length / 2; i++)
            {
                firstHalf[i] = firstNdLast[firstNdLast.Length / 2 - 1 - i];
            }
            int[] secondhalf = new int[firstNdLast.Length / 2];
            for (int i = 0; i < secondhalf.Length; i++)
            {
                secondhalf[i] = firstNdLast[firstNdLast.Length - 1 - i];
            }
            string total = String.Empty;
            for (int i = 0; i < firstHalf.Length; i++)
            {
                total += $"{firstHalf[i]} ";
            }
            for (int i = 0; i < secondhalf.Length; i++)
            {
                if (i == secondhalf.Length - 1)
                {
                    total += $"{secondhalf[i]}";
                }
                else
                {
                    total += $"{secondhalf[i]} ";
                }
            }
            firstNdLast = total.Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < firstNdLast.Length; i++)
            {
                Console.Write($"{firstNdLast[i] + middleInts[i]} ");
            }
        }
    }

}