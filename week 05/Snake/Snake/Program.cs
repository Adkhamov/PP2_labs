using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 70;
            Snake snake = new Snake();
            int lvl = 1;
            Wall wall = new Wall(lvl);

            bool gameOver = false;
            Console.CursorVisible = false;

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
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    snake.Move(0, -1);
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    snake.Move(0, 1);
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    snake.Move(-1, 0);
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    snake.Move(1, 0);
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


                Console.Clear();
                snake.Draw();
                wall.Draw();
                food.Drow(_x, _y);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(35, 12);
            Console.WriteLine("GAME OVER!");
            Console.ReadKey();
        }
    }
}
