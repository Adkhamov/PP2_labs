using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamicButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Button[] arr = new Button[64];
        int k = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button btn = new Button();
                    btn.Text = k.ToString();
                    btn.ForeColor = Color.White;
                    btn.BackColor = Color.White;
                    btn.Size = new Size(50, 50);
                    btn.Location = new Point(15 + j * 51, 15 + i * 51);
                    btn.Click += button_Click;
                    Controls.Add(btn);
                    arr[k] = btn;
                    k++;
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            for (int i = 0; i < 64; i++)
            {
                if (int.Parse(btn.Text) / 8 == int.Parse(arr[i].Text) / 8)
                {
                    arr[i].BackColor = Color.Black;
                    arr[i].ForeColor = Color.Black;
                }
                else if (int.Parse(btn.Text) % 8 == int.Parse(arr[i].Text) % 8)
                {
                    arr[i].BackColor = Color.Black;
                    arr[i].ForeColor = Color.Black;
                }
                else
                {
                    arr[i].BackColor = Color.White;
                    arr[i].ForeColor = Color.White;
                }
            }
           
            
        }
    }
}
