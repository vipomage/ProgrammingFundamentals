using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MathPower
{
    class Program
    {
        static double MathPower(double value, int power)
        {
            return Math.Pow(value, power);
        }
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            int    power  = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(value, power));
        }
    }
}
