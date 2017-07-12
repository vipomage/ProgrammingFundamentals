using System;

namespace _08.PersonalException
{

    class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main()
        {
            while ( true )
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if ( input < 0 )
                    {
                        throw new NegativeNumberException("My first exception is awesome!!!");
                    }
                    Console.WriteLine($"{input}");
                }
                catch ( Exception exception )
                {
                    Console.WriteLine(exception.Message);
                   return;
                }
            }
        }
    }
}