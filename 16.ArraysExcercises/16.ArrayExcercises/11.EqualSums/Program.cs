using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(checker(Console.ReadLine().Split(' ').Select(int.Parse).ToArray()));
        }

        static string checker(int[] inputArray)
        {
            string result = $"no";
            foreach (int i in inputArray)
            {
                int rightSum = 0;
                int leftSum = 0;
                int indexOfI = Array.IndexOf(inputArray, i);
                for (int j = 0; j < indexOfI; j++)
                {
                    for (int k = indexOfI - 1; k >= 0; k--)
                    {
                        if (k == j)
                        {
                            break;
                        }
                    }
                    if (j < indexOfI || j == 0)
                    {
                        leftSum += inputArray[j];
                    }
                }
                for (int k = inputArray.Length - 1; k > indexOfI; k--)
                {
                    for (int j = 0; j <= indexOfI; j++)
                    {
                        if (k == j)
                        {
                            break;
                        }
                    }
                    if (k > indexOfI)
                    {
                        rightSum += inputArray[k];
                    }
                }
                if (rightSum == leftSum)
                {
                    result = indexOfI.ToString();
                    break;
                }
            }
            return result;
        }
    }
}
