using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CaracterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name       = Console.ReadLine();
            int    hp         = int.Parse(Console.ReadLine());
            int    maxhp      = int.Parse(Console.ReadLine());
            int    energy     = int.Parse(Console.ReadLine());
            int    maxEnergy  = int.Parse(Console.ReadLine());

            Console.Write($"Name: {name}\n");
            Console.Write("Health: |");
            Console.Write(new string('|',hp));
            Console.Write(new string('.', maxhp - hp));
            Console.WriteLine("|");
            Console.WriteLine("Energy: |{0}{1}|",new string('|', energy),new string('.', maxEnergy - energy));
                
        }
    }
}
