using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp.Menus
{
    internal class AlbumMenu
    {
        private List<Song> songs = new List<Song>();

        public void Display()
        {
            int optie = 0;

            do
            {
                Console.WriteLine("Select an album:");
                Console.WriteLine("1. Lijpe - Jackpot");
                Console.WriteLine("2. Drake - Winner ");
                Console.WriteLine("3. Jackson - Dancing to the moon");
                Console.WriteLine("0. Back to menu");
                Console.Write("Album: ");
                optie = int.Parse(Console.ReadLine());

                switch (optie)
                {
                    case 1:
                        songs = Song.GetSongsForAlbum(1);
                        DisplaySongsForAlbum("Lijpe - Jackpot", songs);
                        break;
                    case 2:
                        songs = Song.GetSongsForAlbum(2);
                        DisplaySongsForAlbum("Drake - Winner", songs);
                        break;
                    case 3:
                        songs = Song.GetSongsForAlbum(3);
                        DisplaySongsForAlbum("Jackson - Dancing to the moon", songs);
                        break;
                    case 0:
                        Console.WriteLine("Going back to main menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine();
            } while (optie != 0);
        }

        private void DisplaySongsForAlbum(string albumName, List<Song> songs)
        {
            int optie = 0;
            bool loopSong = false;

            do
            {
                Console.WriteLine($"Showing songs for {albumName}...");
                Console.WriteLine();

                for (int i = 0; i < songs.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {songs[i].ToString()}");
                }

                Console.WriteLine("0. Back to album");
                Console.Write("Song: ");
                optie = int.Parse(Console.ReadLine());

                if (optie == 0)
                {
                    break;
                }

                Song selectedSong = songs[optie - 1];

                Console.WriteLine($"Selected Song: {selectedSong.ToString()}");
                Console.WriteLine("--------------------------------------------");

                do
                {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Play Song");
                    Console.WriteLine("2. Pause Song");
                    Console.WriteLine("3. Loop Song");
                    Console.WriteLine("4. Add Song to Playlist");
                    Console.WriteLine("5. Back to album");
                    Console.Write("Option: ");
                    optie = int.Parse(Console.ReadLine());

                    switch (optie)
                    {
                        case 1:
                            Console.WriteLine("Song is now being played");
                            break;
                        case 2:
                            Console.WriteLine("Song is now being paused");
                            break;
                        case 3:
                            if (!loopSong)
                            {
                                Console.WriteLine("Song is now being looped");
                                loopSong = true;
                            }
                            else
                            {
                                Console.WriteLine("Song is no longer being looped");
                                loopSong = false;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Add song to playlist (lateupdater)");
                            // TODO: Functionality to add a song to a playlist
                            break;
                        case 5:
                            Console.WriteLine("Going back to album...");
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }

                    Console.WriteLine();
                } while (optie != 5);
            } while (true);
        }
    }
}
