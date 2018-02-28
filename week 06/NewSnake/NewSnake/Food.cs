using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    class Food
    {
       
        public List<Point> body;
        public string sign = "■";
        public ConsoleColor color = ConsoleColor.White;

        public bool IsOk(Snake snake, Wall wall)
        {
            

            foreach( Point p in snake.body)
            {
                if (p.X == body[0].X && p.Y == body[0].Y)
                {
                    return false;
                }
            }

            foreach (Point p in wall.body)
            {
                if (p.X == body[0].X && p.Y == body[0].Y)
                {
                    return false;
                }
            }

            return true;
        }

        public void Creat(Snake snake, Wall wall)
        {
            while (!IsOk(snake, wall))
            {
                Random rnd = new Random();
                int _x = rnd.Next(1, Console.WindowWidth - 2);
                int _y = rnd.Next(1, Console.WindowHeight - 2);
                body[0] = new Point(_x, _y);
            }
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.WriteLine(sign);
            }
        }

    }
}
