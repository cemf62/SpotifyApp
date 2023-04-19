using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp
{
    internal class SongMenu
    {
        public void Display()
        {
            Console.WriteLine("Select a song:");
            Console.WriteLine("1. Song 1");
            Console.WriteLine("2. Song 2");
            Console.WriteLine("3. Song 3");
            Console.WriteLine("4. Song 4");
            Console.Write("Song: ");
            int song = int.Parse(Console.ReadLine());

            Console.WriteLine($"Speelt song {song}...");
            Console.WriteLine();
        }
    }
}
