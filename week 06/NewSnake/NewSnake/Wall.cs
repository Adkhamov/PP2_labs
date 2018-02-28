using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    class Wall
    { 
        public static int level = 1; 

        public List<Point> body;
        public string sign = "■";
        public ConsoleColor color = ConsoleColor.White;
        
        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.WriteLine(sign);
            }
        }

        public void ReadLevel(Wall wall)
        {
            StreamReader sr = new StreamReader("level_" + level + ".txt");
            try
            {
                int n = int.Parse(sr.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string s = sr.ReadLine();
                    for (int j = 0; j < s.Length; j++)
                        if (s[j] == '*')
                            wall.body.Add(new Point(j, i));
                }

            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("WIN!");
                Console.ReadKey();
                Console.WriteLine(e.ToString());
            }
            finally
            {
                sr.Close();
            }

        }
    }
}
