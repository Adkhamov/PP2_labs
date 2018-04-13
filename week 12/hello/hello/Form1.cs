using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello
{
    public partial class Form1 : Form
    {
        public TextBox[] arr = new TextBox[10];
        public static int k = 1;
        public static int cntArr = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void move(object sender, MouseEventArgs e)
        {
            if (k % 2 == 0)
            {
                Button btn = new Button();
                btn.Size = new Size(50, 50);
                btn.Name = k.ToString();
                btn.Location = new Point(e.X, e.Y);
                btn.Click += button_Click;
                Controls.Add(btn);
                k++;
            }

            else
            {
                TextBox text = new TextBox();
                text.Name = k.ToString();
                text.Size = new Size(50, 30);
                text.Location = new Point(MousePosition.X, MousePosition.Y);
                arr[cntArr] = text;
                Controls.Add(text);
                cntArr++;
                k++;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int n = int.Parse(btn.Name);
            for (int i = 0; i < cntArr; i++)
            {
                if (int.Parse(arr[i].Name) == n - 1)
                {
                    arr[i].Text = "Hello";
                }
            }
        }
    }
}
