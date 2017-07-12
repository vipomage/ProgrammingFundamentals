using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myNumList = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int[]> myListofArrays = new List<int[]>();

            foreach ( var nums in myNumList )
            {

                myListofArrays.Add(nums.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            }

            myListofArrays.Reverse();
            foreach ( int[] myListofArray in myListofArrays )
            {
                foreach ( int number in myListofArray )
                {
                    Console.Write(number + " ");
                }

            }

        }
    }
}
