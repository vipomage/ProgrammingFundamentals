using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            begin:
            try
            {
                int input = int.Parse(Console.ReadLine());
                count += 1;
                goto begin;
            }
            catch (Exception e)
            {
                Console.WriteLine(count);
                
            }
        }
    }
}
