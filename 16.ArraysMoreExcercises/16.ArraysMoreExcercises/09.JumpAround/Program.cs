using System;
using System.Linq;


namespace _09.JumpAround
{

    class Program
    {
        static void Main(string[] args)
        {
            bool toright = true;
            int count = 0;
            int start = 0;
            int sum = 0;
            int lastnum = 0;
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = start; count < 2;)
            {
                try
                {
                    if (toright)
                    {
                        sum += input[i];
                        start = input[i];
                        lastnum = input[i];
                        i = sum;
                    }
                    if (!toright)
                    {
                        start = lastnum;
                        //start = sum-lastnum;
                        sum += input[i];
                        i = start-input[i];
                    }
                }
                catch (Exception )
                {
                    sum += start;
                    count++;
                    toright = !toright;
                }
            }
            Console.WriteLine(sum/2 +count);
        }
    }

}