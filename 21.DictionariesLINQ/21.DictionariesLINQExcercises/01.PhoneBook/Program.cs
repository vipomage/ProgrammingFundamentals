using System;
using System.Collections.Generic;

namespace _01.PhoneBook
{
    class Program
    {
        static void Main()
        {
            var phonebook = new Dictionary<string, string>();
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
                input = Console.ReadLine().Split();
            }
        }
    }
}
