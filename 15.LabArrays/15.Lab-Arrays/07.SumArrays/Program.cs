using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _07.SumArrays
{

    class Program
    {
        static void Main(string[] args)
        {
            bool equal = false;
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int longer = 0;
            if (firstArr.Length == secondArr.Length)
            {
                equal = true;
                longer = firstArr.Length;
            }
            else
            {
                if (firstArr.Length > secondArr.Length)
                {
                    longer = firstArr.Length;
                }
                else
                {
                    longer = secondArr.Length;
                }
            }
            if (equal)
            {
                for (int i = 0; i < longer; i++)
                {
                    int result = firstArr[i] + secondArr[i];
                    Console.Write(result + " ");
                }
            }
            if (!equal)
            {
                int k = 0;
                int j = 0;
                for (int i = 0; i < longer; i++)
                {
                    int result = firstArr[k] + secondArr[j];
                    Console.Write(result + " ");
                    k++;
                    j++;
                    if (k == firstArr.Length && (secondArr.Length > firstArr.Length))
                    {
                        k = 0;
                    }
                    if (j == secondArr.Length && firstArr.Length > secondArr.Length)
                    {
                        j = 0;
                    }
                }
            }
        }
    }

}
