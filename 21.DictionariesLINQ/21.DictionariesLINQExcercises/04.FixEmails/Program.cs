using System;
using System.Collections.Generic;


namespace _04.FixEmails
{
    class Program
    {
        static void Main()
        {
            var contacts = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while ( input != "stop" )
            {
                contacts[input] = Console.ReadLine();
                input = Console.ReadLine();
            }

            var output = new Dictionary<string, string>();
            foreach ( var contact in contacts )
            {
                if ( !contact.Value.EndsWith("us") )
                {
                    output[contact.Key] = contact.Value;
                }
            }
            if ( input == "stop" )
            {
                foreach ( var contact in output )
                {
                    Console.WriteLine($"{contact.Key} -> {contact.Value}");
                }
            }
        }
    }
}
