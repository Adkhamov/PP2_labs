using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0  && textBox2.Text.Length != 0)
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                Pen pen = new Pen(Color.Red);
                Rectangle rec = new Rectangle(x, y, 50, 50);
                g.DrawEllipse(pen, rec);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                Pen pen = new Pen(Color.Red);

                g.DrawLine(pen, x, y, x + 30, y + 30);
                g.DrawLine(pen, x, y, x - 30, y + 30);
                g.DrawLine(pen, x + 30, y + 30, x - 30, y + 30);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                Pen pen = new Pen(Color.Red);
                Rectangle rec = new Rectangle(x, y, 50, 50);
                g.DrawRectangle(pen, rec);

            }
        }
    }
}
