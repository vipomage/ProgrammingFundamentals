using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstQ  = int.Parse(Console.ReadLine());
            int secondQ = int.Parse(Console.ReadLine());
            int thirdQ  = int.Parse(Console.ReadLine());
            int fourthQ = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", firstQ, secondQ, thirdQ, fourthQ);
        }
    }
}
