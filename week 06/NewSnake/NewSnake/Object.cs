/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    public abstract class Object
    {
        public List<Point> body { get; }
        public char sign { get; }
        public ConsoleColor color { get; }

        public Object(Point firstPoint, ConsoleColor color, char sign)
        {
            this.body = new List<Point>();
            if (firstPoint != null)
            {
                this.body.Add(firstPoint);
            }
            this.sign = sign;
            this.color = color;
        }

        public void Drow()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.WriteLine(sign);
            }
        }



    }
}
*/