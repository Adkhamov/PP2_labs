using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {

            int X = 0, Y = 0;
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.SetCursorPosition(X, Y);
                Console.Write("*");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    Y--;
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    Y++;
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    X--;
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    X++;
                if (keyInfo.Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
