using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        public int CompareTo([AllowNull] Book other)
        {
            int outcome = Year.CompareTo(other.Year);

            if (outcome == 0)
            {
                outcome = Title.CompareTo(other.Title);
            }

            return outcome;
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
