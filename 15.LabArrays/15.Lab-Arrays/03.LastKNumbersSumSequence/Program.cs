using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSumSequence
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            myArray[0] = 1;


            for (int i = 1; i < n; i++)
            {
                int end = i - k;
                if (end < 0)
                {
                    end = 0;
                }
                for (int j = i - 1; j >= end; j--)
                {
                    myArray[i] += myArray[j];
                }
                //   i             j 
                //myArray[1] += myArray[0];
                //   i             j             j   
                //myArray[2] += myArray[1] + myArray[0];
                //   i             j             j            j 
                //myArray[3] += myArray[2] + myArray[1] + myArray[0];
                //   i             j             j            j
                //myArray[4] += myArray[3] + myArray[2] + myArray[1];
                //   i             j             j            j
                //myArray[5] += myArray[4] + myArray[3] + myArray[2];

            }
            foreach (int myArrayValue in myArray)
            {

                Console.Write($"{myArrayValue} ");

            }

            //for (int j = 0; j < n; j++)
            //{
            //    Console.Write($"{myArray[j]}");

            //}
        }
    }
}
