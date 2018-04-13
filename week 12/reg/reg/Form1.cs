using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reg
{
    public partial class Form1 : Form
    {
        public bool emailOK = false;
        public static int k = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email1.Text.Length >= 1 && pass1.Text.Length >= 1)
            {
                for (int i = 0; i < email1.Text.Length; i++)
                {
                    if (email1.Text[i] == '@')
                    {
                        emailOK = true;
                        break;
                    }
                }
            }
            if (emailOK)
            {
                lid Lid = new lid(email1.Text, pass1.Text);
                lid.lidFileStreamIn(Lid, k);
                emailOK = false;
                k++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            if (email2.Text.Length >= 1 && pass2.Text.Length >= 1)
            {
                for (int i = 0; i < email2.Text.Length; i++)
                {
                    if (email1.Text[i] == '@')
                    {
                        emailOK = true;
                        break;
                    }
                }
            }
            if (emailOK)
            {
                emailOK = false;
                lid Lid1 = new lid(email2.Text, pass2.Text);
                lid Lid2 = new lid();
                for (int i = 1; i < k; i++)
                {
                    Lid2 = lid.lidFileStreamOut(k - 1);
                    if(Lid1 == Lid2)
                    {
                        ok.Visible = true;
                        wrong.Visible = false;
                    }
                    else
                    {
                        ok.Visible = false;
                        wrong.Visible = true;
                    }
                }
            }
        }
    }
}
