namespace SpotifyApp.Menus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int optie = 0;

            do
            {
                Console.WriteLine("Select option");
                Console.WriteLine("1, Albums");
                Console.WriteLine("2, Playlists");
                Console.WriteLine("3, Friend list");
                Console.WriteLine("4, Profiel");
                Console.WriteLine("0, Exit");
                Console.Write("Optie: ");
                optie = int.Parse(Console.ReadLine());

                switch (optie)
                {
                    case 1:
                        Console.WriteLine("Navigating to Albums...");
                        AlbumMenu albumsMenu = new AlbumMenu();
                        albumsMenu.Display();
                        break;
                    case 2:
                        Console.WriteLine("Navigating to Playlists...");
                        PlaylistMenu playlistMenu = new PlaylistMenu();
                        playlistMenu.Display();
                        break;
                    case 3:
                        Console.WriteLine("Navigating to Friendlist...");
                        VriendenMenu vriendenMenu = new VriendenMenu();
                        vriendenMenu.Display();
                        break;
                    case 4:
                        Console.WriteLine("Navigating to Profile...");
                        ProfileMenu profileMenu = new ProfileMenu();
                        profileMenu.Display();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid Option.");
                        break;
                }

                Console.WriteLine();
            } while (optie != 0);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
