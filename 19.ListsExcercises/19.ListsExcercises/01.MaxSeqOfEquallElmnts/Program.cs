using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MaxSeqOfEquallElmnts
{
    class Program
    {
        static void Main()
        {
            List<int> myArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> duplicates = new List<int>();
            List<int> result = new List<int>();
            for ( int i = 0; i < myArray.Count; i++ )
            {
                duplicates = myArray.FindAll(a => a == myArray[i]);
                if ( duplicates.Count > result.Count )
                {
                    result = duplicates;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}