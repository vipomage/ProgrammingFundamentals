using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberInt = int.Parse(Console.ReadLine());
            BigInteger result = numberInt;

            for (int i = 1; i < numberInt; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result.ToString());

        }
    }
}
