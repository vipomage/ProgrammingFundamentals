using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.MaxMethod
{

    internal static class Program
    {
        private static int GetMin(int a, int b, int c)
        {
            if ( a > b && a > c )
                return a;
            if ( b > a && b > c )
                return b;
            else
                return c;
        }




        private static void Main(string[] args)
        {
            Console.WriteLine(
                GetMin(
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine())
                ));
        }
    }

}