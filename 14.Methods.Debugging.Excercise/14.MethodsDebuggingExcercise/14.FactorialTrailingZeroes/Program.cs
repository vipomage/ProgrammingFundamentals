using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace _14.FactorialTrailingZeroes
{

    class Program
    {
        static void Main(string[] args)
        {
            string result = Factorial();
            string reverse = ReverseAString(result);
            Console.WriteLine(CountZeroes(reverse));
        }




        static string CountZeroes(string text)
        {
            string result = String.Empty;
            int count = 0;
            int charnum = 0;
            while ((text[charnum]) == '0')
            {
                if (text[charnum] == '0')
                {
                    count++;
                    charnum++;
                }
            }
            return result = $"{count}";
        }




        static string Factorial()
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger result = num;
            for (int i = 1; i < num; i++)
            {
                result = result * i;
            }
            return result.ToString();
        }




        static string ReverseAString(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }

}
