using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    class Snake
    {
        public List<Point> body;
        public string sign = "■";
        public ConsoleColor color = ConsoleColor.White;
        public static int eat = 1;
       
        
        public void Move(int dx, int dy)
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }
            body[0].X += dx;
            body[0].Y += dy;

            if (body[0].X < 1)
                body[0].X = Console.WindowWidth - 1;
            if (body[0].X > Console.WindowWidth - 1)
                body[0].X = 1;

            if (body[0].Y < 1)
                body[0].Y = Console.WindowHeight - 1;
            if (body[0].Y > Console.WindowHeight - 1)
                body[0].Y = 1;
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


        public bool CollisionWall(Wall wall)
        {
            foreach (Point p in wall.body)
            {
                if (p.Equals(body[0]))
                {
                    return true;
                }
            }
            
            return false;
        }


        public bool CollisionSelf()
        {

            foreach (Point p in body)
            {
                if (p == body[0])
                    continue;

                else if (p.Equals(body[0]))
                {
                    return true;
                }
            }
            return false;
        }


        public bool CollisionFood(Food food)
        {
            if (body[0].Equals(food.body[0])){
                return true;
            }
            return false;
        }
        

    }

}
        
