using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp.Menus
{
    internal class VriendenMenu
    {
        private List<string> friends = new List<string> { "John", "Jane", "Jack" };

        public void Display()
        {
            int optie = 0;

            do
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Show Friends");
                Console.WriteLine("2. Back to menu");
                Console.Write("Option: ");
                optie = int.Parse(Console.ReadLine());


                switch (optie)
                {
                    case 1:
                        Console.WriteLine("Show Friends....");
                        ViewFriends();
                        break;
                    case 2:
                        Console.WriteLine("Back to menu...");
                        optie = 2;
                        break;
                    default:
                        Console.WriteLine("Onjuiste Keuze.");
                        break;
                }

                Console.WriteLine();
            } while (optie != 2);
        }

        private void ViewFriends()
        {
            Console.WriteLine("Friends List:");
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }
        }
    }
}
