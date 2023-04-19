using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp
{
    internal class AlbumMenu
    {
        public void Display()
        {
            
            Console.WriteLine("Select an album:");
            Console.WriteLine("1. Album 1");
            Console.WriteLine("2. Album 2");
            Console.WriteLine("3. Album 3");
            Console.WriteLine("4. Album 4");
            Console.Write("Album: ");
            int album = int.Parse(Console.ReadLine());

            Console.WriteLine($"Showing songs for album {album}...");
            Console.WriteLine("Song 1");
            Console.WriteLine("Song 2");
            Console.WriteLine("Song 3");
            Console.WriteLine("Song 4");
            Console.WriteLine();
        }
    }
}
