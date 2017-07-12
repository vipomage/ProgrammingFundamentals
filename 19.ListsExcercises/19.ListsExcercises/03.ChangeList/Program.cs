using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ChangeList
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        repeat:
            List<string> command = Console.ReadLine().ToLower().Split(' ').ToList();
            List<int> outputList = new List<int>();

            if ( command[0] == "delete" || command[0] == "insert" )
            {
                if ( command[0] == "delete" )
                {
                    input.RemoveAll(a => a == int.Parse(command[1]));
                }
                if ( command[0] == "insert" )
                {
                    input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                goto repeat;
            }
            if ( command.Contains("odd") )
            {
                foreach ( int i in input )
                {
                    if ( i % 2 == 1 )
                    {
                        outputList.Add(i);
                    }
                }
                Console.WriteLine(string.Join(" ", outputList));
            }
            if ( command.Contains("even") )
            {
                foreach ( int i in input )
                {
                    if ( i % 2 == 0 )
                    {
                        outputList.Add(i);
                    }
                }
                Console.WriteLine(string.Join(" ", outputList));
            }
        }
    }
}
