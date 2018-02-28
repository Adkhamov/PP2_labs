using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{   
    
    public class Point
    {
        public int X, Y;
        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
        /*
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            Point p = obj as Point;
            if (p.X == this.X && p.Y == this.Y)
                return true;
            return false;
        }
        */
    }
    

}
