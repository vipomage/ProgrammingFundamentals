using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.LargestCommonEnd
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();
            int leftCount = 0;
            int rightCount = 0;
            int shorter = Math.Min(input1.Length, input2.Length);
            for (int i = 0; i < shorter; i++)
            {
                if (input1[i] == input2[i])
                {
                    leftCount++;
                }
                if (input1[input1.Length - 1 - i] == input2[input2.Length - 1 - i])
                {
                    rightCount++;
                }
            }
            Console.WriteLine(Math.Max(rightCount, leftCount));
        }
    }

}