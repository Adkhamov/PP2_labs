using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public bool isDouble = false;
        public double a = 0, b = 0, res = 0;
        public string operation = "";
        public bool firstOperation = true;
        public bool divideByZero = false;
        public double Memery = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!firstOperation)
            {
                display.Text = "0";
                firstOperation = true;
            }
            Button btn = sender as Button;
            if (btn.Text == "," && !isDouble)
            {
                isDouble = true;
                display.Text += btn.Text;
            }
            else if (display.Text == "0" && btn.Text != ",")
            {
                display.Text = btn.Text;
            }
            else if (display.Text != "0" && btn.Text != ",")
            {
                display.Text += btn.Text;
            }
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void delete(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "⇐" && display.Text != "0")
            {
                if (display.Text.Substring(display.Text.Length - 1) == ",")
                {
                    isDouble = false;
                }
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
                if (display.Text == "")
                {
                    display.Text = "0";
                }
            }
            else if (display.Text == "С")
            {
                display.Text = "0";
                a = 0;
                b = 0;
                res = 0;
                operation = "";
                isDouble = false;
                firstOperation = true;
            }
            else if (display.Text != "CE")
            {
                display.Text = "0";
                isDouble = false;
            }
            
        }

        private void operator2(object sender, EventArgs e)
        {
           
            Button btn = sender as Button;
            a = double.Parse(display.Text);
            display.Text = "0";
            operation = btn.Text;

        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (!firstOperation)
            {
                a = double.Parse(display.Text);
                switch (operation)
                {
                    case "+":
                        res = a + b;
                        break;
                    case "-":
                        res = a - b;
                        break;
                    case "*":
                        res = a * b;
                        break;
                    case "/":
                        if (b == 0)
                        {
                            divideByZero = true;
                        }
                        else 
                            res = a / b;
                        break;
                    case "mod":
                        res = a % b;
                        break;
                    case "X^y":
                        res = 1;
                        for (int i = 0; i < b; i++)
                        {
                            res *= a;
                        }
                        break;
                    case "X^1/y":
                        if (b == 0)
                        {
                            divideByZero = true;
                        }
                        else
                            res = Math.Pow(a, 1 / b);
                        break;
                }
                if (divideByZero)
                {
                    display.Text = "can not divide by zero";
                    divideByZero = false;
                }
                else
                    display.Text = res.ToString();
            }
            else { 

                b = double.Parse(display.Text);
                switch (operation)
                {
                    case "+":
                        res = a + b;
                        break;
                    case "-":
                        res = a - b;
                        break;
                    case "*":
                        res = a * b;
                        break;
                    case "/":
                        if (b == 0)
                        {
                            divideByZero = true;
                        }
                        else
                            res = a / b;
                        break;
                    case "mod":
                        res = a % b;
                        break;
                    case "X^y":
                        res = 1;
                        for (int i = 0; i < b; i++)
                        {
                            res *= a;
                        }
                        break;
                    case "X^1/y":
                        if (b == 0)
                        {
                            divideByZero = true;
                        }
                        else
                            res = Math.Pow(a, 1 / b);
                        break;
                }
            }
            if (divideByZero)
            {
                display.Text = "can not divide by zero";
                divideByZero = false;
            }
            else
                display.Text = res.ToString();
            firstOperation = false;
        }

        private void swap(object sender, EventArgs e)
        {

        }

        private void operator1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            a = double.Parse(display.Text);
            operation = btn.Text;
            switch (operation)
            {
                case "X!":
                    res = 1;
                    for (int i = 1; i <= a; i++)
                    {
                        res *= i;
                    }
                    break;
                case "+/-":
                    res = -a;
                    break;
                case "X^2":
                    res = a * a;
                    break;
                case "√":
                    res = Math.Sqrt(a);
                    break;
                case "sin":
                    a = (a * Math.PI) / 180; 
                    res = Math.Sin(a);
                    break;
                case "cos":
                    a = (a * Math.PI) / 180;
                    res = Math.Cos(a);
                    break;
                case "tan":
                    a = (a * Math.PI) / 180;
                    res = Math.Tan(a);
                    break;
                case "cat":
                    a = (a * Math.PI) / 180;
                    res = Math.Cos(a)/ Math.Sin(a);
                    break;
                case "log":
                    res = Math.Log(a);
                    break;
                case "E^x":
                    res = Math.Pow(Math.E, a);
                    break;
                case "10^x":
                    res = Math.Pow(10, a);
                    break;
                case "1/X":
                    if (a == 0) {
                        divideByZero = true;
                    }
                    else 
                        res = 1 / a;
                    break;
            }
            if (divideByZero)
            {
                display.Text = "can not divide by zero";
                divideByZero = false;
            }
            else 
                display.Text = res.ToString();
            firstOperation = false;
        }

        private void memery(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            operation = btn.Text;
            switch (operation)
            {
                case "MS":
                    Memery = double.Parse(display.Text);
                    firstOperation = false;
                    break;
                case "MC":
                    display.Text = "";
                    Memery = 0;
                    break;
                case "M+":
                    Memery += double.Parse(display.Text);
                    firstOperation = false;
                    break;
                case "M-":
                    Memery -= double.Parse(display.Text);
                    firstOperation = false;
                    break;
                case "MR":
                    display.Text = Memery.ToString();
                    firstOperation = false;
                    break;
            }
        }
    }
}
