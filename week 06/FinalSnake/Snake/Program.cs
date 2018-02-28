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
        static int direction = 1; // 1 - right, 2 - left, 3 - down, 4 - up
        static int level = 1;
        static Snake snake = new Snake();
        static Wall wall = new Wall(1);
        static int speed = 400;
        static bool gameOver = false;
        public static void func()
        {
            while (true)
            {

                if (direction == 3)
                    snake.Move(0, 1);
                if (direction == 4)
                    snake.Move(0, -1);
                if (direction == 2)
                    snake.Move(-1, 0);
                if (direction == 1)
                    snake.Move(1, 0);
                if (gameOver)
                    break;
                Console.Clear();
                snake.Draw();
                wall.Draw();
                Thread.Sleep(speed);
            }
        }
        static void Main(string[] args)
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 70;
            Snake snake = new Snake();
            int lvl = 1;
            Wall wall = new Wall(lvl);
            Console.CursorVisible = false;
            Thread thread = new Thread(func);
            thread.Start();

            Random rnd = new Random();
            int _x = rnd.Next(1, 70);
            int _y = rnd.Next(1, 20);
            Food food = new Food(_x, _y);


            while (true)
            {
                foreach (Point p in wall.body)
                {
                    if (p.x == food.body[0].x && p.y == food.body[0].y)
                    {
                        rnd = new Random();
                        _x = rnd.Next(1, 70);
                        _y = rnd.Next(1, 20);
                        food = new Food(_x, _y);
                        continue;
                    }
                }
                for (int p = 1; p <= snake.body_cnt; p++)
                {
                    if (snake.body[p].x == food.body[0].x && snake.body[p].y == food.body[0].y)
                    {
                        rnd = new Random();
                        _x = rnd.Next(1, 70);
                        _y = rnd.Next(1, 20);
                        food = new Food(_x, _y);
                        continue;
                    }
                }
                break;
            }
            int k = 1;

            while (!gameOver)
            {
                while (true)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.DownArrow && direction != 4)
                        direction = 3;
                    if (keyInfo.Key == ConsoleKey.UpArrow && direction != 3)
                        direction = 4;
                    if (keyInfo.Key == ConsoleKey.LeftArrow && direction != 1)
                        direction = 2;
                    if (keyInfo.Key == ConsoleKey.RightArrow && direction != 2)
                        direction = 1;

                    if (keyInfo.Key == ConsoleKey.R)
                    {
                        level = 1;
                        snake = new Snake();
                        wall = new Wall(level);
                    }
                    if (keyInfo.Key == ConsoleKey.Escape)
                        gameOver = true;
                    foreach (Point p in wall.body)
                    {
                        if (p.x == snake.body[0].x && p.y == snake.body[0].y)
                        {
                            gameOver = true;
                        }
                    }
                    for (int p = 1; p <= snake.body_cnt; p++)
                    {
                        if (snake.body[p].x == snake.body[0].x && snake.body[p].y == snake.body[0].y)
                        {
                            gameOver = true;
                        }
                    }


                    if (food.body[0].x == snake.body[0].x && food.body[0].y == snake.body[0].y)
                    {
                        k++;
                        snake.Add();
                        _x = rnd.Next(1, 70);
                        _y = rnd.Next(1, 20);
                        food = new Food(_x, _y);
                        bool ok = true;
                        while (ok)
                        {
                            foreach (Point p in wall.body)
                            {
                                if (p.x == food.body[0].x && p.y == food.body[0].y)
                                {
                                    _x = rnd.Next(1, 70);
                                    _y = rnd.Next(1, 20);
                                    food = new Food(_x, _y);
                                }
                            }
                            for (int p = 1; p <= snake.body_cnt; p++)
                            {
                                if (snake.body[p].x == food.body[0].x && snake.body[p].y == food.body[0].y)
                                {
                                    _x = rnd.Next(1, 70);
                                    _y = rnd.Next(1, 20);
                                    food = new Food(_x, _y);
                                }
                            }
                            ok = false;
                        }
                    }
                    if (k % 5 == 0)
                    {
                        k = 1;
                        lvl++;
                        wall = new Wall(lvl);
                    }
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(35, 12);
                Console.WriteLine("GAME OVER!");
                Console.ReadKey();
            }
        }
    }
}
