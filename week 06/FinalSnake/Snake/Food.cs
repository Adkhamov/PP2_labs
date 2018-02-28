using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        public List<Point> body;
        string sign;
        ConsoleColor color;
        

        public Food(int x, int y)
        {
            body = new List<Point>();
            body.Add(new Point(x, y));
            color = ConsoleColor.Red;
            sign = "*";
        }

        public void Drow(int x, int y)
        {
           
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(sign);
            
        }
        
    }
}
