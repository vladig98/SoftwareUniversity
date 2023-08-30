using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OnlineRadioDatabase
{
    public class Song
    {
        private string artistName;

        public string ArtistName
        {
            get
            {
                return artistName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols.");
                }
                artistName = value;
            }
        }

        private string songName;

        public string SongName
        {
            get
            {
                return songName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException("Song name should be between 3 and 30 symbols.");
                }
                songName = value;
            }
        }

        private string length;

        public string Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        private int minutes;

        private int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
                }
                minutes = value;
            }
        }

        private int seconds;

        private int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
                }
                seconds = value;
            }
        }

        public Song(string artistName, string songName, string length)
        {
            if (string.IsNullOrEmpty(artistName) || string.IsNullOrWhiteSpace(artistName)
                || string.IsNullOrEmpty(songName) || string.IsNullOrWhiteSpace(songName)
                || string.IsNullOrEmpty(length) || string.IsNullOrWhiteSpace(length))
            {
                throw new InvalidSongException("Invalid song.");
            }
            ArtistName = artistName;
            SongName = songName;
            Length = length;
            AssignMinutes();
            AssignSeconds();
        }

        private void AssignMinutes()
        {
            if (string.IsNullOrEmpty(Length) || string.IsNullOrWhiteSpace(Length)
                || !Regex.IsMatch(Length.Split(":")[0].ToString(), @"\d+"))
            {
                throw new InvalidSongLengthException("Invalid song length.");
            }

            Minutes = int.Parse(Length.Split(":")[0]);
        }

        private void AssignSeconds()
        {
            if (string.IsNullOrEmpty(Length) || string.IsNullOrWhiteSpace(Length)
                || !Regex.IsMatch(Length.Split(":")[1].ToString(), @"\d+"))
            {
                throw new InvalidSongLengthException("Invalid song length.");
            }

            Seconds = int.Parse(Length.Split(":")[1]);
        }
    }
}
