using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.", 
                "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", 
                "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", 
                "I feel great!"
            };

            string[] authors = new string[]
            {
                "Diana", 
                "Petya", 
                "Stella", 
                "Elena", 
                "Katya", 
                "Iva", 
                "Annie", 
                "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas", 
                "Sofia", 
                "Plovdiv", 
                "Varna", 
                "Ruse"
            };

            Random rnd = new Random();

            int index = -1;
            index = rnd.Next(0, phrases.Length);
            string phrase = phrases[index];

            index = rnd.Next(0, events.Length);
            string event_ = events[index];

            index = rnd.Next(0, authors.Length);
            string author = authors[index];

            index = rnd.Next(0, cities.Length);
            string city = cities[index];

            Console.WriteLine($"{phrase} {event_} {author} - {city}");
        }
    }
}
