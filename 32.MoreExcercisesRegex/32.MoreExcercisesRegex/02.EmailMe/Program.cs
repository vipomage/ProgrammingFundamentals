using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] email = Console.ReadLine().Split('@');

            int sum1 = 0;
            foreach ( char c in email[0] )
            {
                sum1 += c;
            }
            int sum2 = 0;
            foreach ( char c2 in email[1] )
            {
                sum2 += c2;
            }


            if ( sum1 - sum2 >= 0 )
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }

        }
    }
}
