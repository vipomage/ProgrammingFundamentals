using System;
using System.Linq;


namespace _07.PlayCatch
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while ( counter != 3 )
            {
                string[] input = Console.ReadLine().Split();
                try
                {
                    if ( input[0].ToLower() == "replace" )
                    {
                        ints[int.Parse(input[1])] = int.Parse(input[2]);
                    }
                    if ( input[0].ToLower() == "print" )
                    {
                        for ( int i = int.Parse(input[1]); i <= int.Parse(input[2]); i++ )
                        {
                            int start = ints[int.Parse(input[1])];
                            int end = ints[int.Parse(input[2])];
                            if ( i == int.Parse(input[2]) )
                            {
                                Console.Write($"{ints[i]}\n");
                            }
                            else
                            {
                                Console.Write($"{ints[i]}, ");
                            }
                        }
                    }
                    if ( input[0].ToLower() == "show" )
                    {
                        Console.WriteLine($"{ints[int.Parse(input[1])]}");
                    }
                }
                catch ( IndexOutOfRangeException )
                {
                    Console.WriteLine("The index does not exist!");
                    counter++;
                }
                catch ( FormatException )
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    counter++;
                }
            }
            if (counter==3)
            {
                Console.WriteLine(string.Join(", ", ints));
                
            }
        }
    }
}