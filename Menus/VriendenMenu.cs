using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp.Menus
{
    internal class VriendenMenu
    {
        /// <summary>
        /// hardcoded lijst friends word opgehaald. 
        /// </summary>
        private List<string> friends = new List<string> { "John", "Jane", "Jack" };
        /// <summary>
        /// methode die input vraagt en vanuit hier kan de user navigeren naar Viewfriends waar vrienden hardcoded staan of ze kunnen kiezen om terug naar het menu te gaan. 
        /// </summary>
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

        /// <summary>
        ///  view friends method die de lijst die boven de code is opgehaald met private list displayed. in een string worden friends onderelkaar geprint.
        /// </summary>
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
