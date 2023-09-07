using BookShop.Data;
using BookShop.Initializer;
using BookShop.Models;
using BookShop.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BookShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var db = new BookShopContext())
            {
                //DbInitializer.ResetDatabase(db);

                //2. Age Restriction
                //string input = Console.ReadLine();
                //Console.WriteLine(GetBooksByAgeRestriction(db, input));

                //3. Golden Books
                //Console.WriteLine(GetGoldenBooks(db));

                //4. Books by Price
                //Console.WriteLine(GetBooksByPrice(db));

                //5. Not Released In
                //int year = int.Parse(Console.ReadLine());
                //Console.WriteLine(GetBooksNotReleasedIn(db, year));

                //6. Book Titles by Category
                //string input = Console.ReadLine();
                //Console.WriteLine(GetBooksByCategory(db, input));

                //7. Released Before Date
                //string date = Console.ReadLine();
                //Console.WriteLine(GetBooksReleasedBefore(db, date));

                //8. Author Search
                //string input = Console.ReadLine();
                //Console.WriteLine(GetAuthorNamesEndingIn(db, input));

                //9. Book Search
                //string input = Console.ReadLine();
                //Console.WriteLine(GetBookTitlesContaining(db, input));

                //10. Book Search by Author
                //string input = Console.ReadLine();
                //Console.WriteLine(GetBooksByAuthor(db, input));

                //11. Count Books
                //int length = int.Parse(Console.ReadLine());
                //Console.WriteLine(CountBooks(db, length));

                //12. Total Book Copies
                //Console.WriteLine(CountCopiesByAuthor(db));

                //13. Profit by Category
                //Console.WriteLine(GetTotalProfitByCategory(db));

                //14. Most Recent Books
                //Console.WriteLine(GetMostRecentBooks(db));

                //15. Increase Prices
                //IncreasePrices(db);

                //16. Remove Books
                //Console.WriteLine(RemoveBooks(db));
            }
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books.Where(x => x.Copies < 4200).ToList();

            context.Books.RemoveRange(books);

            context.SaveChanges();

            return books.Count();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books.Where(x => x.ReleaseDate.Value.Year < 2010).ToList();

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var categories = context.Categories.Include(x => x.CategoryBooks)
                .Select(x => new { x.Name, Books = x.CategoryBooks.Select(y => y.Book).OrderByDescending(y => y.ReleaseDate).Take(3).ToList() })
                .OrderBy(x => x.Name).ToList();

            foreach (var category in categories)
            {
                sb.AppendLine($"--{category.Name}");
                foreach (var book in category.Books)
                {
                    sb.AppendLine($"{book.Title} ({book.ReleaseDate.Value.Year})");
                }
            }

            return sb.ToString();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var categories = context.Categories.Include(x => x.CategoryBooks)
                .Select(x => new { x.Name, Price = x.CategoryBooks.Sum(y => y.Book.Price * y.Book.Copies) })
                .OrderByDescending(x => x.Price).ThenBy(x => x.Name).ToList();

            foreach (var category in categories)
            {
                sb.AppendLine($"{category.Name} ${category.Price:f2}");
            }

            return sb.ToString();
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var authors = context.Authors.Include(x => x.Books)
                .Select(x => new { Name = x.FirstName + " " + x.LastName, Copies = x.Books.Sum(y => y.Copies) })
                .OrderByDescending(x => x.Copies).ToList();

            foreach (var author in authors)
            {
                sb.AppendLine($"{author.Name} - {author.Copies}");
            }

            return sb.ToString();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var books = context.Books.Where(x => x.Title.Length > lengthCheck).ToList();

            return books.Count();
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var books = context.Books.Where(x => x.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .Include(x => x.Author).OrderBy(x => x.BookId).ToList();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} ({book.Author.FirstName} {book.Author.LastName})");
            }

            return sb.ToString();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var books = context.Books.Where(x => x.Title.ToLower().Contains(input.ToLower())).OrderBy(x => x.Title).ToList();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var authors = context.Authors.Where(x => x.FirstName.EndsWith(input)).OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            foreach (var author in authors)
            {
                sb.AppendLine($"{author.FirstName} {author.LastName}");
            }

            return sb.ToString();
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            StringBuilder sb = new StringBuilder();

            DateTime dateToCompare = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context.Books.Where(x => x.ReleaseDate.Value.CompareTo(dateToCompare) < 0)
                .OrderByDescending(x => x.ReleaseDate).ToList();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType.ToString()} - ${book.Price:f2}");
            }

            return sb.ToString();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var categoriesNames = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToList();

            var categoriesIds = context.Categories.Where(x => categoriesNames.Contains(x.Name.ToLower())).Select(x => x.CategoryId).ToList();
            var bookCategories = new List<BookCategory>();

            foreach (var bookCategory in context.Books.Select(x => x.BookCategories).ToList())
            {
                bookCategories.AddRange(bookCategory);
            }

            var bookIds = bookCategories.Where(x => categoriesIds.Contains(x.CategoryId)).Select(x => x.BookId).ToList();

            var books = context.Books.Where(x => bookIds.Contains(x.BookId)).Distinct().OrderBy(x => x.Title).ToList();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);  
            }

            return sb.ToString();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            StringBuilder sb = new StringBuilder();

            var books = context.Books.Where(x => x.ReleaseDate.HasValue).Where(x => x.ReleaseDate.Value.Year != year)
                .OrderBy(x => x.BookId).ToList();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var books = context.Books.Where(x => x.Price > 40).OrderByDescending(x => x.Price).ToList();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return sb.ToString();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var goldenEditionBooks = context.Books.Where(x => x.EditionType == EditionType.Gold && x.Copies < 5000).OrderBy(x => x.BookId).ToList();

            foreach (var book in goldenEditionBooks)
            {
                sb.AppendLine(book.Title);
            }

            return sb.ToString().Trim();
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            StringBuilder sb = new StringBuilder();
                
            Enum.TryParse(command, true, out AgeRestriction ageEnum);

            var bookTitles = context.Books.Where(x => x.AgeRestriction == ageEnum).Select(x => x.Title).OrderBy(x => x).ToList();

            foreach (var bookTitle in bookTitles)
            {
                sb.AppendLine(bookTitle);
            }

            return sb.ToString().Trim();
        }
    }
}
