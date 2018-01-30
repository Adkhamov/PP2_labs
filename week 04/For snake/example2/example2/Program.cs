using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            while (true)
            {
                try
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                        y--;
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                        y++;
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                        x--;
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                        x++;
                    if (keyInfo.Key == ConsoleKey.Escape)
                        break;
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("*");
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR!!!");
                    Console.ReadKey();
                }

            }
        }
    }
}