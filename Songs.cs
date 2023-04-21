using System;
using System.Collections.Generic;

namespace SpotifyApp
{
    internal class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Duration { get; set; }

        public Song(string name, string artist, string album)
        {
            Name = name;
            Artist = artist;
            Album = album;
        }

        public override string ToString()
        {
            return $"{Name} - {Artist} ";
        }

        public static List<Song> GetSongsForAlbum(int albumIndex)
        {
            switch (albumIndex)
            {
                case 1:
                    return new List<Song>()
                    {
                        new Song("Eng", "Lijpe", "Jackpot"),
                        new Song("Waar was je", "Lijpe", "Jackpot")
                    };
                case 2:
                    return new List<Song>()
                    {
                        new Song("Winner", "Drake", "Winner"),
                        new Song("Suspicious", "Drake", "Winner")
                    };
                case 3:
                    return new List<Song>()
                    {
                        new Song("Moonlight", "Jackson", "Dancing to the moon"),
                        new Song("Dark", "Jackson", "Dancing to the moon")
                    };
                default:
                    return new List<Song>();
            }
        }
    }
}
