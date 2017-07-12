﻿using System;

namespace _02.EadvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new[]{
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new[]{
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = new[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = new[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random result = new Random(0);

            int n = int.Parse(Console.ReadLine());

            for ( int i = 0; i < n; i++ )
            {
                int randomPhrase = result.Next(0, phrases.Length);
                int randomEvent = result.Next(0, events.Length);
                int randomAuthor = result.Next(0, authors.Length);
                int randomCity = result.Next(0, cities.Length);

                Console.WriteLine($"{phrases[randomPhrase]} {events[randomEvent]} {authors[randomAuthor]} – {cities[randomCity]}.");
            }
        }
    }
}
