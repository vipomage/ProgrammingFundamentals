using System;

namespace _04.CharMultiplier
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(StringValue(input[0], input[1]));
        }

        static long StringValue(string first, string second)
        {
            int sum = 0;
            int length;
            bool firstIsLonger = false;
            if ( first.Length > second.Length )
            {
                length = second.Length;
                firstIsLonger = true;
            }
            else
            {
                length = first.Length;
            }
            for ( int i = 0; i < length; i++ )
            {
                sum += first[i] * second[i];
            }
            if ( first.Length != second.Length )
            {

                for ( int i = Math.Min(first.Length, second.Length); i < Math.Max(first.Length, second.Length); i++ )
                {
                    if ( firstIsLonger )
                    {
                        sum += first[i];
                    }
                    else
                    {
                        sum += second[i];
                    }
                }
            }
            return sum;
        }
    }
}
