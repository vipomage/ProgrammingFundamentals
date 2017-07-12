using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayStrings
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] myStrings = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(myStrings);
            //foreach (string myString in myStrings)
            //{

            //    Console.Write(String.Join(" ", myString));
            //}
            for (int i = 0; i < myStrings.Length; i++)
            {
                if (i != myStrings.Length-1)
                {
                    Console.Write(myStrings[i] + " ");
                }
                else
                {
                    Console.Write(myStrings[i]);
                }
            }
        }
    }

}
