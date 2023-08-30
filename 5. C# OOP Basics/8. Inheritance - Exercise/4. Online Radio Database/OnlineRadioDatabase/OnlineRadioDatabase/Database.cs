using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class Database
    {
        private List<Song> songs;
        private int totalSeconds;

        public Database()
        {
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
            Console.WriteLine("Song added.");
            totalSeconds += int.Parse(song.Length.Split(":")[0]) * 60 + int.Parse(song.Length.Split(":")[1]);
        }

        public override string ToString()
        {
            return string.Format($"Songs added: {songs.Count}" + Environment.NewLine +
            $"Playlist length: {GetHours()}h {GetMinutes()}m {GetSeconds()}s");
        }

        private int GetHours()
        {
            return (int)Math.Floor(totalSeconds / 3600.0);
        }

        private int GetMinutes()
        {
            return (totalSeconds - GetHours() * 3600) / 60;
        }

        private int GetSeconds()
        {
            return totalSeconds - GetHours() * 3600 - GetMinutes() * 60;
        }
    }
}
