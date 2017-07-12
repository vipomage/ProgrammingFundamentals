using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_MultiplicationTableV._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            if (times > 10)
            {
                Console.WriteLine($"{input} X {times} = {input * times}");
            }
            else if (times <= 10)
            {
                for (int i = times; i <= 10; i++)
                {
                    Console.WriteLine($"{input} X {i} = {input * i}");
                }
            }
        }
    }
}
