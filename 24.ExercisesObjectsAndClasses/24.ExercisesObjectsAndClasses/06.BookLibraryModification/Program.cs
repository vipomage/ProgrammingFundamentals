using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library();
            int n = int.Parse(Console.ReadLine());
            for ( int i = 0; i < n; i++ )
            {
                myLibrary.bookList.Add(ReadBook());
            }
            DateTime filterDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var printList = myLibrary.bookList.Where(d => d.ReleaseDate > filterDate).OrderBy(d => d.ReleaseDate)
                .ThenBy(t => t.Title);

            foreach ( Book book in printList )
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }
        }

        static Book ReadBook()
        {
            Book inputBook = new Book();
            string[] input = Console.ReadLine().Split();

            inputBook.Title = input[0];
            inputBook.Author = input[1];
            inputBook.Publisher = input[2];
            inputBook.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", null);
            inputBook.ISBN = input[4];
            inputBook.Price = decimal.Parse(input[5]);

            return inputBook;
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> bookList = new List<Book>();
    }
}
