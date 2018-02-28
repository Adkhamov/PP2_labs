using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewSnake
{
    class Game
    {   
        public static int speed = 700;
        public static int boardW = 70;
        public static int boardH = 35;
        public static char direction = 'L';

        public static bool isAlive;

        public void Start()
        {
            Snake snake = new Snake();
            Wall wall = new Wall();
            Food food = new Food();

            wall.ReadLevel(wall);
            Random rnd = new Random();
            int _x = rnd.Next(1, Console.WindowWidth - 2);
            int _y = rnd.Next(1, Console.WindowHeight - 2);
            food.body.Add(new Point(_x, _y));

            Console.SetCursorPosition(boardW / 2, boardH / 2);
            
        }

        public void Play()
        {
            Snake snake = new Snake();
            Wall wall = new Wall();
            Food food = new Food();

            wall.ReadLevel(wall);
            food.Creat(snake, wall);

            while (isAlive)
            {
                if (direction == 'D')
                    snake.Move(0, 1);
                if (direction == 'U')
                    snake.Move(0, -1);
                if (direction == 'L')
                    snake.Move(-1, 0);
                if (direction == 'R')
                    snake.Move(1, 0);

                if (snake.CollisionFood(food))
                {
                    snake.body.Add(new Point(food.body[0].X, food.body[0].Y));
                    Snake.eat++;
                    food.Creat(snake, wall);
                }
                else if (snake.CollisionWall(wall) || snake.CollisionSelf())
                {
                    isAlive = false;
                    break;
                }



                if (Snake.eat == 6)
                {
                    Wall.level++;
                    wall.ReadLevel(wall);
                    Snake.eat = 1;
                }

                Console.Clear();
                wall.Draw();
                snake.Draw();
                food.Draw();

                Thread.Sleep(speed);               
            }
        }


        public void PressKey()
        {
            while (isAlive)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow && direction != 'U')
                    direction = 'D';
                if (keyInfo.Key == ConsoleKey.UpArrow && direction != 'D')
                    direction = 'U';
                if (keyInfo.Key == ConsoleKey.LeftArrow && direction != 'R')
                    direction = 'L';
                if (keyInfo.Key == ConsoleKey.RightArrow && direction != 'L')
                    direction = 'R';
            }
        }

    }
}
