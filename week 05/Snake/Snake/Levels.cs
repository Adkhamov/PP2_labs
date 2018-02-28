using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    [Serializable]
    class Levels
    {
        public void First()
        {
            for (int i = 0; i <= 70; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("■");
                Console.SetCursorPosition(i, 70);
                Console.Write("■");
            }
        }

        public void Second()
        {
            for (int i = 0; i <= 35; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                Console.SetCursorPosition(70, i);
                Console.Write("■");
            }
        }

        public void Third()
        {
            for (int i = 0; i <= 35; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                Console.SetCursorPosition(70, i);
                Console.Write("■");
            }
            for (int i = 0; i <= 35; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                Console.SetCursorPosition(70, i);
                Console.Write("■");
            }
        }
    }
}
