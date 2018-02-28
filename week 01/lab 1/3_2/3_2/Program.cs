using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Circle
    {
        public int radius;
        public double area;
        public int diameter;
        public double circumference;
        string color;
        public double segment;

        public Circle()
        {
            color = "black";
            radius = 10;
            findArea();
            findDmt();
            findCir();
        }

        public Circle(string color, int radius)
        {
            this.color = color;
            this.radius = radius;
            findArea();
            findDmt();
            findCir();
        }

        double FindS(int a)
        {
            return (a / 360) * area;
        }

        public void findArea()
        {
            area = Math.PI * radius * radius;
        }
        
        public void findDmt()
        {
            diameter = radius * 2;
        }
        public void findCir()
        {
            circumference = Math.PI * 2 * radius;
        }

        public override string ToString()
        {
            return "Color is " + color + "\nRadius = " + radius + "\nArea = " + area + "\nCircumference = " + circumference + "\nDiameter = " + diameter;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write color, radius of your Circle");
            string c, line = Console.ReadLine();
            string[] newline = line.Split(' ');
            c = newline[0];
            int r = int.Parse(newline[1]);

            Circle c1 = new Circle();
            Console.WriteLine("DEFAULD: \n" + c1);
            Circle c2 = new Circle(c, r);
            Console.WriteLine("\nYOUR: \n" + c2);

            Console.WriteLine("\n Press button");
            Console.ReadKey();

        }
    }
}

