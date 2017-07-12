using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterOfTwoValues
{
    class Program
    {

        static int MaxValue(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char MaxValue(char first, char second)
        {
            if ((int)first > (int)second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string MaxValue(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first  = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(MaxValue(first, second));
            }
            if (type == "char")
            {
                char first  = Char.Parse(Console.ReadLine());
                char second = Char.Parse(Console.ReadLine());
                Console.WriteLine(MaxValue(first, second));
            }
            if (type == "string")
            {
                string first  = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(MaxValue(first, second));
            }
        }
    }
}
