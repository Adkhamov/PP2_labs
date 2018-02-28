using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.CursorVisible = false;
            Menu menu = new Menu();
            menu.MainMenu();
            Console.WindowHeight = Menu.screenheight;
            Console.WindowWidth = Menu.screenwidth;


        }
    }
}
