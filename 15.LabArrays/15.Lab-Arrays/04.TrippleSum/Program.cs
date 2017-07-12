using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04.TrippleSum
{

    class Program
    {
        static void Main()
        {
            int a = 0, b = 0, c = 0;
            bool result = false;
            int[] myInts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();

            for (int i = myInts.Length - 1; i >= 0; i--)
            {
                for (int j = myInts.Length - 1; j >= i; j--)
                {
                    for (int k = myInts.Length - 1; k >= j; k--)
                    {
                        a = myInts[i];
                        b = myInts[j];
                        c = myInts[k];

                        if (a + b == c)
                        {
                            Console.WriteLine($"{a} + {b} == {c}");
                            result = true;
                        }
                    }
                }
            }


            if (!result)
            {
                Console.WriteLine("No");

            }
        }
    }
}