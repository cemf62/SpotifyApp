using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp.Menus
{
    internal class PlaylistMenu
    {
        public void Display()
        {
            int optie = 0;
            int playlistcount = 0;
            do
            {
                Console.WriteLine("Select a playlist:");
                Console.WriteLine("1. Create new playlist");
                Console.WriteLine("2. View playlist ");
                Console.WriteLine("3. Back to menu");
                if (playlistcount == 1) {
                    Console.Write("Choose a playlist ");
                }
                else Console.WriteLine("Create Playlist");
                optie = int.Parse(Console.ReadLine());
            } while (optie != 0);


        }
    }
    }

