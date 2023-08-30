using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";
            string[] input = File.ReadAllLines(path + "input.txt");
            int until = int.Parse(input[0]);

            Library library = new Library();

            DateTime date = new DateTime();

            List<string> results = new List<string>();

            for (int i = 1; i <= until + 1; i++)
            {
                string[] tokens = input[i].Split(" ").ToArray();
                if (tokens.Length == 1)
                {
                    date = DateTime.ParseExact(tokens[0], "dd.MM.yyyy", null);
                    continue;
                }
                Book book = new Book();
                book.Title = tokens[0];
                //book.Author = tokens[1];
                //book.Publisher = tokens[2];
                book.ReleaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", null);
                //book.ISBNNumber = tokens[4];
                //book.Price = double.Parse(tokens[5]);
                library.Books.Add(book);
            }

            var dict = library.Books.Where(x => x.ReleaseDate > date).ToDictionary(x => x.Title, y => y.ReleaseDate);

            dict = dict.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in dict)
            {
                results.Add($"{item.Key} -> {item.Value.ToString("dd.MM.yyyy")}");
            }

            File.WriteAllLines(path + "output.txt", results);
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
