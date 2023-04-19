using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<User> Friends { get; set; }

        public User(int id, string username)
        {
            Id = id;
            Username = username;
            Playlists = new List<Playlist>();
            Friends = new List<User>();
        }

        public void AddPlaylist(Playlist playlist)
        {
            Playlists.Add(playlist);
        }

        public void RemovePlaylist(Playlist playlist)
        {
            Playlists.Remove(playlist);
        }

        public void AddFriend(User friend)
        {
            Friends.Add(friend);
        }

        public void RemoveFriend(User friend)
        {
            Friends.Remove(friend);
        }
    }
}
