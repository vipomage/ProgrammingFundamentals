using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class Program
    {
        static int AsciiConvert()
        {// MY FIRST WORKING METHOD!!!!! ^^
            char character = char.Parse(Console.ReadLine());
            int ascii = (int) character;
            return ascii;
        }
        //   USAGE          int  n1 = AsciiConvert({char});
        static char ReverseAscii(int a)
        {//MY SECOND WORKING METHOD!!!!! ^^
            int number = a;
            char ascii = (char) number;
            return ascii;
        }
        //   USAGE          char n2 = ReverseAscii({int});

        static void Main(string[] args)
        {
            int n1 = AsciiConvert();
            int n2 = AsciiConvert();
            int n3 = AsciiConvert();

            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= n2; j++)
                {
                    for (int k = n1; k <= n2; k++)
                    {
                        string text = $"{ReverseAscii(i)}{ReverseAscii(j)}{ReverseAscii(k)} ";
                        if (text.Contains(ReverseAscii(n3)))
                        {
                            
                        }
                        else
                        {
                            Console.Write(text);
                        }
                    
                    }
                }
            }
        }
    }
}
