using System;
using System.Collections.Generic;
using System.Globalization;

namespace _06.ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> hexValues = new List<string>();
            string[] input = Console.ReadLine().Split();

            for ( int i = 0; i < input.Length; i++ )
            {
                if ( input[i].Length != 2 )
                {
                    input[i] = null;
                }
                else
                {
                    string value = input[i];
                    string reversd = ( $"{value[1]}" + $"{value[0]}" );
                    input[i] = reversd;
                    hexValues.Add(input[i]);
                }
            }
            hexValues.Reverse();
            string result = String.Empty; ;

            foreach ( var hexValue in hexValues )
            {
                int num = int.Parse(hexValue, NumberStyles.AllowHexSpecifier);
                char cnum = (char)num;
                result += cnum;

            }
            Console.WriteLine(result);
        }
    }
}
