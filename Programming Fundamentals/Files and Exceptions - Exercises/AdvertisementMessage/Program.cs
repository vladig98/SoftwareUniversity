using System;
using System.Collections.Generic;
using System.IO;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";

            int until = int.Parse(File.ReadAllText(path + "input.txt"));

            string[] phrases = File.ReadAllLines(path + "phrases.txt");

            string[] events = File.ReadAllLines(path + "events.txt");

            string[] authors = File.ReadAllLines(path + "authors.txt");

            string[] cities = File.ReadAllLines(path + "cities.txt");

            Random rnd = new Random();

            List<string> results = new List<string>();

            for (int i = 0; i < until; i++)
            {
                int index = -1;
                index = rnd.Next(0, phrases.Length);
                string phrase = phrases[index];

                index = rnd.Next(0, events.Length);
                string event_ = events[index];

                index = rnd.Next(0, authors.Length);
                string author = authors[index];

                index = rnd.Next(0, cities.Length);
                string city = cities[index];

                results.Add($"{phrase} {event_} {author} - {city}");
            }

            File.WriteAllLines(path + "output.txt", results);
        }
    }
}
