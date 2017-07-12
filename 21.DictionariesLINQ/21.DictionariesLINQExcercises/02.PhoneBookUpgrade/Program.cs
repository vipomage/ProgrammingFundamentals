using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PhoneBookUpgrade
{
    class Program
    {
        static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();
            string[] input = Console.ReadLine().Split();
            while ( input[0] != "END" )
            {
                if ( input[0] == "A" )
                {
                    phonebook[input[1]] = input[2];
                }
                if ( input[0] == "S" )
                {
                    if ( phonebook.ContainsKey(input[1]) )
                    {
                        foreach ( var entry in phonebook )
                        {
                            if ( entry.Key == input[1] )
                            {
                                Console.WriteLine($"{entry.Key} -> {entry.Value}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                if ( input[0] == "ListAll" )
                {
                    foreach ( var entry in phonebook )
                    {
                        Console.WriteLine($"{entry.Key} -> {entry.Value}");
                    }
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}
