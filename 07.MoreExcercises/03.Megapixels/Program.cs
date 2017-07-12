using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double horizontal = double.Parse(Console.ReadLine());
            double vertical   = double.Parse(Console.ReadLine());

            Console.WriteLine($"{horizontal}x{vertical} => {Math.Round((horizontal*vertical)/1000000,1)}MP");
        }
    }
}
