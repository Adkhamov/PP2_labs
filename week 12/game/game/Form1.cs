using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button btn = new Button();
        Random random = new Random();
        Random random1 = new Random();
        int k;
        int scr;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = int.Parse(random1.Next(10, 200).ToString()), y = int.Parse(random1.Next(10, 200).ToString());
            btn.Size = new Size(50, 50);
            btn.Location = new Point(x, y);
            k = int.Parse(random.Next(0,2).ToString());
            if (k == 1)
            {
                btn.BackColor = Color.Red;
            } 
            else 
            {
                btn.BackColor = Color.Blue;
            }
            btn.Click += button_Click;
            Controls.Add(btn);
        }

        private void button_Click(object sender, EventArgs e)
        {

            if (k == 0) // blue
            {
                scr++;
                Score.Text = scr.ToString();

            }
            
            if (k == 1) //red
            {
                timer1.Enabled = false;
                Score.Visible = false;
                label1.Visible = false;
                btn.Text = "Score: " + scr.ToString();
                game_over.Visible = true;
            }

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Score_Click(object sender, EventArgs e)
        {

        }
    }
}
