using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)

        {
            int count = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b - a < Math.Abs(5))
            {
                Console.WriteLine("No");
            }
            else
            {
                int n1 = a;
                int n2 = n1 +1;
                int n3 = n2 +1;
                int n4 = n3 +1;
                int n5 = n4 +1;

                for (n1 = a; n1 < n2; n1++)
                {
                    for (n2 = n1 + 1; n2 < n3; n2++)
                    {
                        for (n3 = n2 + 1; n3 < n4; n3++)
                        {
                            for (n4 = n3 + 1; n4 < n5; n4++)
                            {
                                for (n5 = n4 + 1; n5 <= b; n5++)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
