using SpotifyApp.playlists;
using System;
using System.Collections.Generic;

namespace SpotifyApp.Menus
{
    internal class PlaylistMenu
    {
        private List<Playlist> playlists = new List<Playlist>();

        public void DisplayPlaylistMenu()
        {
            int option = 0;

            do
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Create new playlist");
                Console.WriteLine("2. View playlists");
                Console.WriteLine("3. Back to main menu");
                Console.Write("Option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CreateNewPlaylist();
                        break;
                    case 2:
                        ViewPlaylists();
                        break;
                    case 3:
                        Console.WriteLine("Going back to main menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine();
            } while (option != 3);
        }
        private void CreateNewPlaylist()
        {
            Console.WriteLine("Enter the name for your new playlist:");
            string playlistName = Console.ReadLine();

            Playlist newPlaylist = new Playlist(playlistName);
            playlists.Add(newPlaylist);

            Console.WriteLine($"New playlist '{playlistName}' has been created!");
            Console.WriteLine();

            ViewPlaylists(); 
        }
        private void RemovePlaylist()
        {
            Console.WriteLine("Which playlist do you want to remove?");
            Console.Write("Playlist: ");
            int optie = int.Parse(Console.ReadLine());

            if (optie < 1 || optie > playlists.Count)
            {
                Console.WriteLine("Invalid option.");
                Console.WriteLine();
                return;
            }

            Playlist playlistToRemove = playlists[optie - 1];
            playlists.Remove(playlistToRemove);

            Console.WriteLine($"Playlist '{playlistToRemove.Name}' has been removed.");
        }

        private void ViewPlaylists()
        {
            Console.WriteLine("Playlist Overview:");
            Console.WriteLine();

            if (playlists.Count == 0)
            {
                Console.WriteLine("Currently no playlists available.");
                Console.WriteLine();
                return;
            }

            for (int i = 0; i < playlists.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {playlists[i].Name}");
            }

            Console.WriteLine($"{playlists.Count + 1}. Remove a playlist");
            Console.WriteLine($"{playlists.Count + 2}. Go back to playlist menu");
            Console.Write("Playlist: ");
            int optie = int.Parse(Console.ReadLine());

            if (optie == playlists.Count + 2)
            {
                Console.WriteLine();
                return;
            }

            if (optie < 1 || optie > playlists.Count + 1)
            {
                Console.WriteLine("Invalid option.");
                Console.WriteLine();
                return;
            }

            if (optie == playlists.Count + 1)
            {
                RemovePlaylist();
                Console.WriteLine();
                return;
            }

            Playlist selectedPlaylist = playlists[optie - 1];

            Console.WriteLine();
            Console.WriteLine($"{selectedPlaylist.Name}:");
            Console.WriteLine();

            for (int i = 0; i < selectedPlaylist.Songs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {selectedPlaylist.Songs[i].ToString()}");
            }

            Console.WriteLine($"{selectedPlaylist.Songs.Count + 1}. Go back to playlist overview");
            Console.Write("Song: ");
            optie = int.Parse(Console.ReadLine());

            if (optie == selectedPlaylist.Songs.Count + 1)
            {
                Console.WriteLine();
                return;
            }

            if (optie < 1 || optie > selectedPlaylist.Songs.Count)
            {
                Console.WriteLine("Invalid option.");
                Console.WriteLine();
                return;
            }
        }



    }
} 



