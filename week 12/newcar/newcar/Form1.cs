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

namespace newcar
{
    public partial class Form1 : Form
    {

        Graphics g;

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

        public class Tank
        {
            public GraphicsPath gp;
            public int direction = 0;
            public int x, y;
            public Tank(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Draw(Graphics g)
            {
                gp = new GraphicsPath();
                int w = 30;
                int h = 30;
                gp.AddRectangle(new Rectangle(x, y, w, h));
                gp.AddEllipse(new Rectangle(x, y, w, h));
                if (direction == 0)
                    gp.AddLine(x + w / 2, y + h / 2, x + w + w / 2, y + h / 2);
                if (direction == 1)
                    gp.AddLine(x + w / 2, y + h / 2, x + w / 2, y + h + h / 2);
                g.DrawPath(new Pen(Color.Red, 2), gp);
            }
        }
    }
}
