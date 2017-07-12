using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _05.ArrayManipulator
{
    class Program
    {

        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().ToLower().Split(' ').ToArray();

            while ( command[0] != "print" )
            {
                if ( command[0] == "add" )
                {
                    input.Insert(short.Parse(command[1]), short.Parse(command[2]));
                }
                else if ( command[0] == "addmany" )
                {
                    var index = int.Parse(command[1]);
                    var elements = new List<int>();
                    for ( int i = 2; i < command.Length; i++ )
                    {
                        var currentItem = int.Parse(command[i]);
                        elements.Add(currentItem);
                    }
                    input.InsertRange(index, elements);
                }
                else if ( command[0] == "contains" )
                {
                    if ( input.Contains(int.Parse(command[1])) )
                    {
                        Console.WriteLine(input.IndexOf(int.Parse(command[1])));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }

                }
                else if ( command[0] == "remove" )
                {
                    var index = int.Parse(command[1]);
                    input.RemoveAt(index);
                }
                else if ( command[0] == "shift" )
                {
                    var count = int.Parse(command[1]) % input.Count;
                    for ( int i = 0; i < count; i++ )
                    {
                        input.Add(input[0]);
                        input.RemoveAt(0);
                    }
                }
                else if ( command[0] == "sumpairs" )
                {
                    var pairsSum = new List<int>();

                    for ( int i = 0; i < input.Count; i += 2 )
                    {
                        var currentElement = input[i];
                        var nextElement = 0;
                        if ( i < input.Count - 1 )
                        {
                            nextElement = input[i + 1];
                        }

                        var elementsSum = currentElement + nextElement;

                        pairsSum.Add(elementsSum);
                    }

                    input = pairsSum;
                }

                command = Console.ReadLine().ToLower().Split();
            }
            Console.WriteLine("[{0}]",string.Join(", ", input));
        }
    }
}
