using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int until = int.Parse(Console.ReadLine());

            Library library = new Library();

            for (int i = 0; i < until; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ").ToArray();
                Book book = new Book();
                //book.Title = tokens[0];
                book.Author = tokens[1];
                //book.Publisher = tokens[2];
                //book.ReleaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", null);
                //book.ISBNNumber = tokens[4];
                book.Price = double.Parse(tokens[5]);
                library.Books.Add(book);
            }

            var dict = library.Books.GroupBy(x => x.Author).ToDictionary(x => x.Key, y => y.Sum(z => z.Price));

            dict = dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.ToString("F2")}");
            }
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBNNumber { get; set; }
            public double Price { get; set; }
        }

        public class Library
        {
            public Library()
            {
                this.Books = new List<Book>();
            }
            public string Name { get; set; }

            public List<Book> Books { get; set; }
        }
    }
}
