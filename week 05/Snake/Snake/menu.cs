using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Snake
{
    class Menu
    {
        static int direction = 1;
        static Snake snake = new Snake();
        static int lvl = 1;
        static Wall wall = new Wall(lvl);
        static int speed = 400;
        static bool gameOver = false;
        static int k = 1;
        static Random rnd = new Random();
        static int _x = rnd.Next(1, 70);
        static int _y = rnd.Next(1, 20);
        static Food food = new Food(_x, _y);

        public static int screenwidth = 70;
        public static int screenheight = 35;


        public static void func()
        {
            while (!gameOver)
            {
                if (direction == 3)
                    snake.Move(0, 1);
                if (direction == 4)
                    snake.Move(0, -1);
                if (direction == 2)
                    snake.Move(-1, 0);
                if (direction == 1)
                    snake.Move(1, 0);

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
                            _y = rnd.Next(1, 30);
                            food = new Food(_x, _y);
                            continue;
                        }
                    }
                    break;
                }
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
                                _y = rnd.Next(1, 30);
                                food = new Food(_x, _y);
                                continue;
                            }
                        }
                        break;
                    }
                    food = new Food(_x, _y);
                }
                if (k % 5 == 0)
                {
                    k++;
                    lvl++;
                    wall = new Wall(lvl);
                }
                if (gameOver)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(screenwidth / 2, screenheight / 2);
                    Console.WriteLine("GAME OVER!");
                    Console.SetCursorPosition(screenwidth / 2, screenheight / 2 + 1);
                    Console.WriteLine("score:" + (k - lvl));
                    Console.ReadKey();
                    break;
                }

                Console.Clear();
                snake.Draw();
                wall.Draw();
                food.Draw(_x, _y);
                Thread.Sleep(speed);
            }
        }

        public int CursorPos = 1;

        public static void ComplexFileStreamIn(Snake snake, Wall wall, Food food, string name)
        {
            // передаем в конструктор тип класса
            XmlSerializer formatterS = new XmlSerializer(typeof(Snake));
            XmlSerializer formatterW = new XmlSerializer(typeof(Wall));
            XmlSerializer formatterF = new XmlSerializer(typeof(Food));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(name + ".snake" + ".xml", FileMode.OpenOrCreate))
            {
                formatterS.Serialize(fs, snake);
            }

              /*  FileStream snakE = new FileStream(@"" + name + ".snake" + ".xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs1 = new XmlSerializer(typeof(Snake));
            FileStream walL = new FileStream(@"" + name + ".wall" + ".xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs2 = new XmlSerializer(typeof(Wall));
            FileStream fooD = new FileStream(@"" + name + ".food" + ".xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs3 = new XmlSerializer(typeof(Food));
            try
            {
                xs1.Serialize(snakE, snake);
                xs2.Serialize(walL, wall);
                xs3.Serialize(fooD, food);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR!!!");
            }
            finally
            {
                snakE.Close();
                fooD.Close();
                walL.Close();
            }*/
        }

        public static void ComplexFileStreamOut(Snake snake, Wall wall, Food food, string name)
        {
            FileStream snakE = new FileStream("@" + name + ".snake" + ".xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream walL = new FileStream("@" + name + ".wall" + ".xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fooD = new FileStream("@" + name + ".food" + ".xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer xs1 = new XmlSerializer(typeof(Snake));
            XmlSerializer xs2 = new XmlSerializer(typeof(Wall));
            XmlSerializer xs3 = new XmlSerializer(typeof(Food));
            try
            {
                snake = xs1.Deserialize(snakE) as Snake;
                wall = xs2.Deserialize(walL) as Wall;
                food = xs3.Deserialize(fooD) as Food;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR!!!");
            }
        }
        

        static void ShowDirectoryInfo(DirectoryInfo directory, int cursor)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            FileSystemInfo[] fileSystemInfos = directory.GetFileSystemInfos();

            for (int index = 0; index < fileSystemInfos.Length; index++)
            {
                FileSystemInfo fileSystemInfo = fileSystemInfos[index];
                if (index == cursor)
                    Console.BackgroundColor = ConsoleColor.Gray;
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                Console.WriteLine(fileSystemInfo.Name);
            }
        }
        string[] items = { "New Game", "Load Game", "Save Game", "Settings", "Exit" };

        public void MainMenu()
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                for(int i =0; i < 5; i++)
                {
                    if (i + 1 == CursorPos)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(items[i]);
                }
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    CursorPos++;
                    if (CursorPos == 6)
                        CursorPos = 1;
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    CursorPos--;
                    if (CursorPos == 0)
                        CursorPos = 5;
                }

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (items[CursorPos - 1] == "New Game")
                    {
                        NewGame();
                    }

                    if (items[CursorPos - 1] == "Load Game")
                    {
                        LoadGame();
                    }

                    if (items[CursorPos - 1] == "Save Game")
                    {
                        Console.Clear();
                        Console.WriteLine("Enter your name\n");
                        string name = Console.ReadLine();
                        ComplexFileStreamIn(snake, wall, food, name);
                        break;
                    }

                    if (items[CursorPos - 1] == "Settings")
                    {

                    }

                    if (items[CursorPos - 1] == "Exit")
                    {
                        break;
                    }
                }

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        void NewGame()
        {

            direction = 1;
            snake = new Snake();
            int lvl = 1;
            wall = new Wall(lvl);
            speed = 400;
            gameOver = false;
            k = 1;
            rnd = new Random();
            int _x = rnd.Next(1, 70);
            int _y = rnd.Next(1, 20);
            food = new Food(_x, _y);

            Thread thread = new Thread(func);
            thread.Start();

            while (!gameOver)
            {

                ConsoleKeyInfo KeyInfo = Console.ReadKey();
                if (gameOver) break;
                if (KeyInfo.Key == ConsoleKey.DownArrow && direction != 4)
                    direction = 3;
                if (KeyInfo.Key == ConsoleKey.UpArrow && direction != 3)
                    direction = 4;
                if (KeyInfo.Key == ConsoleKey.LeftArrow && direction != 1)
                    direction = 2;
                if (KeyInfo.Key == ConsoleKey.RightArrow && direction != 2)
                    direction = 1;


                if (KeyInfo.Key == ConsoleKey.Escape)
                    gameOver = true;

            }
        }

        void LoadGame()
        {
        }

        void SaveGame()
        {
        }

        void Settings()
        {
        }

        void Exit()
        {
        }

       
    }
    /*
    public void MainMenu()
    {
        //DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\1\Desktop\Асхат\AE\PP2\C#\");
        int cursor = 0;
        int n = 5;
        ShowDirectoryInfo(directoryInfo, cursor);

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                cursor++;
                if (cursor == n)
                    cursor = 0;
            }
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                cursor--;
                if (cursor == -1)
                    cursor = n - 1;
            }
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (directoryInfo.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                {
                    directoryInfo = new DirectoryInfo(directoryInfo.GetFileSystemInfos()[cursor].FullName);
                    cursor = 0;
                    n = directoryInfo.GetFileSystemInfos().Length;
                }
                else
                {
                    StreamReader sr = new StreamReader(directoryInfo.GetFileSystemInfos()[cursor].FullName);
                    string s = sr.ReadToEnd();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
            }
            if (keyInfo.Key == ConsoleKey.Backspace)
            {
                if (directoryInfo.Parent != null)
                {
                    directoryInfo = directoryInfo.Parent;
                    cursor = 0;
                    n = directoryInfo.GetFileSystemInfos().Length;
                }
                else
                    break;
            }
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                break;
            }
            ShowDirectoryInfo(directoryInfo, cursor);
        }
    } */
}
