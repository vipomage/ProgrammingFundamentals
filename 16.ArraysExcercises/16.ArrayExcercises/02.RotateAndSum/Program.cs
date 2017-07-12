using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace _02.RotateAndSum
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] sum = new int[myInts.Length];
            for (int i = 0; i < n; i++)
            {
                myInts = Rotation(myInts, 1);
                for (int j = 0; j < myInts.Length; j++)
                {
                    sum[j] += myInts[j];
                }
            }
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }
        }

        static int[] Rotation(int[] array, int times)
        {
            int[] copy = new int[array.Length];
            for (int i = 0; (i < times); i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (j == array.Length - 1)
                    {
                        Array.Copy(array, j, copy, 0, 1);
                    }
                    else
                    {
                        Array.Copy(array, j, copy, j + 1, 1);
                    }
                }
                array = (int[])copy.Clone();
            }
            return copy;
        }
    }

}