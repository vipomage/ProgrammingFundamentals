using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04.ReverseOrderANumber
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ReverseTheNumber(decimal.Parse(Console.ReadLine())));
        }




        private static decimal ReverseTheNumber(decimal input)
        {
            string number = input.ToString();
            string reversed = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
                reversed += number[i];
            return decimal.Parse(reversed);
        }
    }

}