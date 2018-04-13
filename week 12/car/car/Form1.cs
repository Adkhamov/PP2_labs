using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
    public partial class Form1 : Form
    {
        /*Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        Tank t = new Tank(50, 50);

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (t.direction == 0)
                t.x += 2;
            else
                t.y += 2;

            g.Clear(Color.White);
            t.Draw(g);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
                t.direction = 1;
            if (e.KeyCode == Keys.D)
                t.direction = 0;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }*/

        public static int x = 200, y = 150;
        public static int height = 25, width = 50, nheight = height, nwidth = 100;
        public static GraphicsPath g;
        public static Graphics gg;
        public static Pen pen, pen1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = new GraphicsPath();
            gg = CreateGraphics();
            pen = new Pen(Color.Red, 3);
            pen1 = new Pen(Color.Black, 3);
        }

        public static void DrawCar()
        {
            Rectangle rec = new Rectangle(x, y, width, height);
            Rectangle rec1 = new Rectangle(x - (width / 2), y + height, nwidth, nheight);
            Rectangle rec2 = new Rectangle(x, y + height + height, 10, 10);
            Rectangle rec3 = new Rectangle(x + width, y + height + nheight, 10, 10);

            g.AddRectangle(rec);
            g.AddRectangle(rec1);
            g.AddEllipse(rec2);
            g.AddEllipse(rec3);

            gg.DrawPath(pen1, g);
        }

        private void Move(object sender, EventArgs e)
        {
            g.Reset();
            gg.Clear(Color.White);
            x += 10;
            DrawCar();
        }
    }
}
