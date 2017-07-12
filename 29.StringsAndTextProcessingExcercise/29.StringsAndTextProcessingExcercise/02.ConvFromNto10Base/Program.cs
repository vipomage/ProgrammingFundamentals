using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.ConvFromNto10Base
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Console.WriteLine(FromBase(BigInteger.Parse(input[1]), BigInteger.Parse(input[0])));


        }
        public static BigInteger FromBase(BigInteger value, BigInteger @base)
        {
            string number = value.ToString();
            BigInteger n = 1;
            BigInteger r = 0;

            for ( int i = number.Length - 1; i >= 0; --i )
            {
                r += n * ( number[i] - '0' );
                n *= @base;
            }

            return r;
        }

    }
}
