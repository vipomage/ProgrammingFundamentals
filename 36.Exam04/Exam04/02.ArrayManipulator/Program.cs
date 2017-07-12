using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayManipulator
{
    public class Program
    {
        public static int[] Exchange(int[] array, int startPosition)
        {
            List<int> firstPart = new List<int>();
            List<int> secondPart = new List<int>();
            List<int> finaList = new List<int>();
            for ( int i = startPosition + 1; i < array.Length; i++ )
            {
                firstPart.Add(array[i]);
            }
            for ( int k = 0; k < startPosition + 1; k++ )
            {
                secondPart.Add(array[k]);
            }
            finaList.AddRange(firstPart);
            finaList.AddRange(secondPart);

            return finaList.ToArray();
        }

        public static void FirstEvenorOdd(int[] array, int count, string type)
        {
            if ( count < 0 || count > array.Length )
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if ( type == "even" )
                {
                    var list = new List<int>();
                    list.AddRange(array.Where(a => a % 2 == 0));
                    if ( list.Count - 1 < count )
                    {
                        Console.WriteLine($"[{string.Join(", ", list)}]");
                    }
                    else
                    {
                        Console.WriteLine($"[{string.Join(", ", list.Take(count))}]");
                    }
                }
                else
                {
                    var list = new List<int>();
                    list.AddRange(array.Where(a => a % 2 != 0));
                    if ( list.Count - 1 < count )
                    {
                        Console.WriteLine($"[{string.Join(", ", list)}]");
                    }
                    else
                    {
                        Console.WriteLine($"[{string.Join(", ", list.Take(count))}]");
                    }
                }
            }
        }

        public static string MinEvenorOdd(int[] array, string type)
        {
            int index = -1;
            int lastValue = int.MaxValue;
            if ( type == "even" )
            {
                for ( int i = 0; i < array.Length; i++ )
                {
                    if ( array[i] % 2 == 0 && array[i] <= lastValue )
                    {
                        index = i;
                        lastValue = array[i];
                    }
                }
            }
            if ( type == "odd" )
            {
                for ( int i = 0; i < array.Length; i++ )
                {
                    if ( array[i] % 2 == 1 && array[i] <= lastValue )
                    {
                        index = i;
                        lastValue = array[i];
                    }
                }
            }
            return index == -1 ? "No matches" : index.ToString();
        }


        public static string MaxEvenorOdd(int[] array, string type)
        {
            int index = -1;
            int lastValue = int.MinValue;
            if ( type == "even" )
            {
                for ( int i = array.Length - 1; i >= 0; i-- )
                {
                    if ( array[i] % 2 == 0 && array[i] > lastValue )
                    {
                        index = i;
                        lastValue = array[i];
                    }
                }
            }
            if ( type == "odd" )
            {
                for ( int i = array.Length - 1; i >= 0; i-- )
                {
                    if ( array[i] % 2 == 1 && array[i] > lastValue )
                    {
                        index = i;
                        lastValue = array[i];
                    }
                }
            }
            return index == -1 ? "No matches" : index.ToString();
        }


        public static void LastEvenorOdd(int[] array, int count, string type)
        {
            if ( count < 0 || count > array.Length )
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if ( type == "even" )
                {
                    var list = new List<int>();
                    list.AddRange(array.Where(a => a % 2 == 0));
                    if ( list.Count == 0 )
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        list.Reverse();
                        if ( list.Count - 1 < count )
                        {
                            Console.WriteLine($"[{string.Join(", ", list)}]");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", list.Take(count))}]");
                        }
                    }
                }
                else
                {
                    var list = new List<int>();
                    list.AddRange(array.Where(a => a % 2 != 0));
                    if ( list.Count == 0 )
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        if ( list.Count - 1 < count )
                        {
                            Console.WriteLine($"[{string.Join(", ", list)}]");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", list.Skip(list.Count - count))}]");
                        }
                    }
                }
            }
        }


        static void Main()
        {
            int[] initialArray = Console.ReadLine()?.Split().Select(int.Parse).ToArray();

            string[] command = Console.ReadLine()?.ToLower().Split();

            while ( command != null && command[0] != "end" )
            {
                switch ( command[0] )
                {
                    case "exchange":
                        if ( initialArray != null && int.Parse(command[1]) > initialArray.Length - 1 )
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            initialArray = Exchange(initialArray, int.Parse(command[1]));
                        }
                        break;
                    case "max":
                        Console.WriteLine(MaxEvenorOdd(initialArray, command[1]));
                        break;
                    case "min":
                        Console.WriteLine(MinEvenorOdd(initialArray, command[1]));
                        break;
                    case "first":

                        FirstEvenorOdd(initialArray, int.Parse(command[1]), command[2]);

                        break;
                    case "last":
                        LastEvenorOdd(initialArray, int.Parse(command[1]), command[2]);
                        break;

                }
                command = Console.ReadLine()?.ToLower().Split();
            }
            Console.WriteLine($"[{string.Join(", ", initialArray)}]");
        }
    }
}