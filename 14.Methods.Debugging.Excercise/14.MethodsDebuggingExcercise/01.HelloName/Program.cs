using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{

    internal class Program
    {
        private static string PrintName(string name)
        {
            return name = $"Hello, {name}!";
        }




        private static void Main()

        {
            string name = Console.ReadLine();
            Console.WriteLine(PrintName(name));
        }
    }
}