using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            input.RemoveRange(0, inputArray[1]);

            if ( input.Contains(inputArray[2]) )
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
/*
 * First number represents the number of elements you have to take from the list (starting from the first one).
 * Second number represents the number of elements you have to delete from the numbers you took (starting from the first one). 
 * Last number is the number we search in our collection after the manipulations. If it is present print: “YES!”, otherwise print “NO!”. 
*/
