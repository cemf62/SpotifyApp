namespace SpotifyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User(1, "John");

            Playlist playlist1 = new Playlist(1, "My Playlist");

            user1.AddPlaylist(playlist1);

            Song song1 = new Song(1, "Song Title", "Artist Name", "Album Title", 240);
            playlist1.AddSong(song1);

            foreach (Playlist playlist in user1.Playlists)
            {
                Console.WriteLine(playlist.Name);
            }

            Console.ReadKey();
        }
    }
}