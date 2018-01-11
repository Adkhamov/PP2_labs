using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Rectangle
    {
        string color;
        int width;
        int height;
        int area;
        int perimeter;

        public void findArea()
        {
            area = width * height;
        }

        public void findPer()
        {
            perimeter = 2 * (width + height);
        }

        public Rectangle()
        {
            color = "black";
            width = 1;
            height = 1;
            findArea();
            findPer();
        }

        public Rectangle(string color, int width, int height)
        {
            this.color = color;
            this.width = width;
            this.height = height;
            findArea();
            findPer();
        }
        public override string ToString()
        {
            return "Color is " + color + "\nWidth = " + width + "\nHeight = " + height + "\nArea = " + area + "\nPerimeter = " + perimeter;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write, please, color, width, height of your Rectangle");
            string c, line = Console.ReadLine();
            string[] newline = line.Split(' ');
            c = newline[0];
            int a = int.Parse(newline[1]);
            int b = int.Parse(newline[2]);

            Rectangle r1 = new Rectangle();
            Console.WriteLine("DEFAULD: \n" + r1);
            Rectangle r2 = new Rectangle(c, a, b);
            Console.WriteLine("\nYOUR: \n" + r2);

            Console.WriteLine("\n Press button");
            Console.ReadKey();

        }
    }
}
