using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp.playlists
{

    internal class Playlist
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
         public void AddSong(Song song)
    {
        Songs.Add(song);
    }
        public Playlist(string name)
        {
            Name = name;

            // Voegt songs to aan playlist (hcode)
            Songs = new List<Song>()
        {
            new Song("Eng", "Lijpe", "Jackpot"),
            new Song("Big Time", "Drake", "Winner"),
            new Song("Suspicious", "Drake", "Winner"),
        };
        }
    }



}
