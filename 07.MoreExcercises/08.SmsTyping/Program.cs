using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace _08.SmsTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            int n = int.Parse(Console.ReadLine());//Number of inputs

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();//The Input

                int lenght = input.Length;
                string firstDigit = input.Remove(1,(lenght-1));
                int main = int.Parse(firstDigit);
                int offset = (main - 2) * 3;
                if (main > 7)
                {
                    index = (offset + lenght);
                }
                else
                {
                    index = (offset + lenght - 1);
                }
                int table = 97 + index;
                char c = Convert.ToChar(table);
                if (main == 0)
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.Write(c);
                }
            }
        }
    }
}