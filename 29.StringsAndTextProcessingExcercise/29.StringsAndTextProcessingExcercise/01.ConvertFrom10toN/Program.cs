using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.ConvertFrom10toN
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(Int32ToString(BigInteger.Parse(input[0]), BigInteger.Parse(input[1])));


        }
        public static string Int32ToString(BigInteger toBase, BigInteger value)
        {
            string result = string.Empty;
            do
            {
                result += value % toBase;
                value /= toBase;
            }
            while ( value > 0 );
            result = string.Join("", result.Reverse().ToArray());
            return result;
        }
    }
}
