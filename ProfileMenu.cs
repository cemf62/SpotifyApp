using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp
{
    internal class ProfileMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome, John Dirk!");
            Console.WriteLine("Your subscription will end on: " + DateTime.Now.AddDays(30).ToString("dd/MM/yyyy"));
        }
    }
}
