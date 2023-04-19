using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp
{
    internal class VriendenMenu
    {
        private List<string> friends = new List<string>();
        public void Display()
        {
            int optie = 0;

            do
            {
                Console.WriteLine("Selecteer an option:");
                Console.WriteLine("1. Zie vrienden");
                Console.WriteLine("2. Voeg vriend toe");
                Console.WriteLine("3. Afspeelijst van vrienden");
                Console.WriteLine("0. Exit");
                Console.Write("Optie: ");
                optie = int.Parse(Console.ReadLine());

                // Bepaal welke optie moet worden uitgevoerd op basis van het ingevoerde nummer
                switch (optie)
                {
                    case 1:
                        Console.WriteLine("Viewing friends...");
                        ViewFriends();
                        break;
                    case 2:
                        Console.WriteLine("Adding friend...");
                        AddFriend();
                        break;
                    case 3:
                        Console.WriteLine("Viewing friend's playlist...");
                        ViewFriendPlaylist();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine();
            } while (optie != 0);
        }
        private void ViewFriends()
        {
            Console.WriteLine("Friends List:");
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }
        }

        private void AddFriend()
        {
            Console.Write("Enter friend's name: ");
            string friend = Console.ReadLine();
            friends.Add(friend);
            Console.WriteLine($"Added {friend} to friends list.");
        }

        private void ViewFriendPlaylist()
        {
           // Console.Write("Enter friend's name: ");
           // string friend = Console.ReadLine();
           // Console.WriteLine($"Viewing {friend}'s playlist...");
            // TODO: functie om de vriendelijst te zien.
        }

    }
}
