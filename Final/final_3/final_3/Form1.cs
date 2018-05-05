using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool FullLine = false;
        static Button[] Btn = new Button[10];
        static int cnt = 1, clickNum = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Button btn = new Button();
                    btn.Text = "";
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Microsoft Sans Serif", 30);
                    btn.Size = new Size(100, 100);
                    btn.Location = new Point(15 + j * 105, 15 + i * 105);
                    btn.Click += btn_Click;
                    Controls.Add(btn);
                    Btn[cnt] = btn;
                    cnt++;
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (clickNum % 2 == 0)
            {
                btn.Text = "X";
                clickNum++;
            }
            else
            {
                btn.Text = "O";
                clickNum++;
            }
            btn.Enabled = false;

            if (Btn[1].Text == Btn[2].Text && Btn[2].Text == Btn[3].Text && Btn[1].Text != "")
            {
                FullLine = true;
            }
            if (Btn[4].Text == Btn[5].Text && Btn[5].Text == Btn[6].Text && Btn[4].Text != "")
            {
                FullLine = true;
            }
            if (Btn[7].Text == Btn[8].Text && Btn[8].Text == Btn[9].Text && Btn[7].Text != "")
            {
                FullLine = true;
            }
            if (Btn[1].Text == Btn[4].Text && Btn[4].Text == Btn[7].Text && Btn[1].Text != "")
            {
                FullLine = true;
            }
            if (Btn[2].Text == Btn[5].Text && Btn[5].Text == Btn[8].Text && Btn[2].Text != "")
            {
                FullLine = true;
            }
            if (Btn[3].Text == Btn[6].Text && Btn[6].Text == Btn[9].Text && Btn[3].Text != "")
            {
                FullLine = true;
            }
            if (Btn[1].Text == Btn[5].Text && Btn[5].Text == Btn[9].Text && Btn[1].Text != "")
            {
                FullLine = true;
            }
            if (Btn[3].Text == Btn[5].Text && Btn[5].Text == Btn[7].Text && Btn[3].Text != "")
            {
                FullLine = true;
            }


            if (FullLine)
            {
                for (int i  = 1; i <= 9; i++)
                {
                    Btn[i].Enabled = false;
                }
                label1.Visible = true;
                
            }
        }
    }
}
