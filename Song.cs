using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Duration { get; set; }

        public Song(int id, string title, string artist, string album, int duration)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Album = album;
            Duration = duration;
        }
    }

}
