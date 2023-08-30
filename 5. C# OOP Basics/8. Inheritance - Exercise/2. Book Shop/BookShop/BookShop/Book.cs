using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BookShop
{
    public class Book
    {
        private string title;

        public string Title
        {
            get 
            { 
                return title; 
            }
            set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }

        private string author;

        public string Author
        {
            get 
            { 
                return author;
            }
            set 
            {
                if (value.Split(" ").Length > 1)
                {
                    if (Regex.IsMatch(value.Split(" ")[1][0].ToString(), "\\d+"))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
                author = value; 
            }
        }

        private decimal price;

        public virtual decimal Price
        {
            get 
            { 
                return price; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value; 
            }
        }

        public override string ToString()
        {
            return string.Format($"Type: {this.GetType().Name}" + Environment.NewLine + 
                $"Title: {Title}" + Environment.NewLine + 
                $"Author: {Author}" + Environment.NewLine 
                + $"Price: {Price:F2}");
        }

        public Book(string author, string title, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    }
}
