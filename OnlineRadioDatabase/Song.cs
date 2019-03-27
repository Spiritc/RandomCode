using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class Song
    {
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;

        }

        public string ArtistName
        {
            get => artistName;
            private set
            {
                if (value.Length > 2 && value.Length < 21)
                {
                    artistName = value;
                }
                else
                {
                    throw new InvalidArtistNameException();
                }
            }
        }
        public string SongName
        {
            get => songName;
            private set
            {
                if (value.Length > 2 && value.Length < 21)
                {
                    songName = value;
                }
                else
                {
                    throw new InvalidSongNameException();
                }
            }
        }
        public int Minutes
        {
            get => minutes;
            private set
            {
                if (value >= 0 && value < 15)
                {
                    minutes = value;
                }
                else
                {
                    throw new InvalidSongMinutesException();
                }
            }
        }

        public int Seconds
        {
            get => seconds;
            private set
            {
                if (value >= 0 && value < 60)
                {
                    seconds = value;
                }
                else
                {
                    throw new InvalidSongSecondsException();
                }
            }
        }
    }
}
