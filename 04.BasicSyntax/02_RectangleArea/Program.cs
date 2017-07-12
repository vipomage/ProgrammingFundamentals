using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width  = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", (width * height));
        }
    }
}
