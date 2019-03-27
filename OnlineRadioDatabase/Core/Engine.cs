using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineRadioDatabase.Core
{
    public class Engine
    {
        private List<Song> songs;

        public Engine()
        {
            this.songs = new List<Song>();
        }

        public void Run()
        {
            int songsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < songsNumber; i++)
            {

                try
                {
                    string[] input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                    if (input.Length != 3)
                    {
                        throw new InvalidSongException();
                    }

                    string autor = input[0];
                    string songName = input[1];
                    string[] time = input[2].Split(':', StringSplitOptions.RemoveEmptyEntries);
                    int minets = 0;
                    int seconds = 0;

                    bool isMinets = int.TryParse(time[0], out minets);
                    bool isSeconds = int.TryParse(time[1], out seconds);

                    if (!isMinets || !isSeconds)
                    {
                        throw new InvalidSongLengthException();
                    }

                    Song song = new Song(autor, songName, minets, seconds);

                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            Print();
        }
        void Print()
        {
            Console.WriteLine($"Songs added: {songs.Count}");

            int totalSeconds = songs.Sum(x => x.Seconds + x.Minutes * 60);

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

            Console.WriteLine($"Playlist length: {time.Hours}h {time.Minutes}m {time.Seconds}s");
        }
    }
}
