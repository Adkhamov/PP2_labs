using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Thread thread = new Thread(game.Play);
            thread.Start();
            game.PressKey();
            
        }
    }
}
