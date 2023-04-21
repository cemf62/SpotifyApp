namespace SpotifyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int optie = 0;

            
            do
            {
                Console.WriteLine("Selecteer een optie");

                Console.WriteLine("1, Albums");

                Console.WriteLine("2, Playlist");

                Console.WriteLine("3, Vrienden lijst");

                Console.WriteLine("4, Profiel");
                Console.WriteLine("0, Exit");
                Console.WriteLine("Optie: ");

                optie = int.Parse(Console.ReadLine());
                    
                
                switch (optie)
                {
                    case 1:
                        Console.WriteLine("Navigating to Albums...");
                        AlbumMenu albumsMenu = new AlbumMenu();
                        albumsMenu.Display();
                        break;
                    case 2:
                        Console.WriteLine("Navigating to Songs...");
                        SongMenu songsMenu = new SongMenu();
                        songsMenu.Display();
                        break;
                    case 3:
                        Console.WriteLine("Vriendenlijst...");
                        VriendenMenu.vriendMenu = new VriendenMenu();
                        VriendenMenu.dis
                        break;
                    case 4:
                        Console.WriteLine("Profiel...");
                        break;
                    case 0:
                        Console.WriteLine("Exit...");
                        break;
                    default:
                        Console.WriteLine("Onjuiste optie.");
                        break;
                }

                Console.WriteLine();
            } while (optie != 0);

            // Wacht tot de gebruiker op een toets drukt voordat het programma wordt afgesloten
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        }
    }
