using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name      = Console.ReadLine();
            double volume    = double.Parse(Console.ReadLine());
            double energy100 = double.Parse(Console.ReadLine());
            double sugar100  = double.Parse(Console.ReadLine());


            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars ",volume,name,volume*(energy100/100),(volume/100*(sugar100)));
        }
    }
}
