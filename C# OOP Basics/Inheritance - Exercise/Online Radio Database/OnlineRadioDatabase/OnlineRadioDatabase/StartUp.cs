using System;
using System.Collections.Generic;

namespace OnlineRadioDatabase
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            Database database = new Database();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(";");

                try
                {
                    Song song = new Song(inputTokens[0], inputTokens[1], inputTokens[2]);
                    database.AddSong(song);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(database);
        }
    }
}
