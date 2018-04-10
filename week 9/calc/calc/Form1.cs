using System;
using System.Collections;
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
        public bool Operator = false;
        public bool haveargs = false;
        public bool readString = false;
        public bool priority(string a, string b) // a = элемент сторки, b = элемент стэка
        {
            if ((a == "+" || a == "-") && (b == "+" || b == "-"))
                return true;
            if ((a == "+" || a == "-") && (b == "*" || b == "/"))
                return true;
            return false;

        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (Operator)
            {
                Operator = false;
                display.Text = "0";
                if (!firstOperation)
                {
                    display.Text = "0";
                    firstOperation = true;
                }

                if ((btn.Text == "," && !isDouble) && (display.Text[display.Text.Length - 1] >= '0' && display.Text[display.Text.Length - 1] <= '9'))
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
            else
            {
                if (!firstOperation)
                {
                    display.Text = "0";
                    firstOperation = true;
                }
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
        }

        private void display_TextChanged(object sender, EventArgs e)
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
                if (display.Text.Substring(display.Text.Length - 1) == ")")
                {
                    BracketsOpen = true;
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
            if (readString)
            {
                if ((display.Text[display.Text.Length - 1] >= '0' && display.Text[display.Text.Length - 1] <= '9') || display.Text[display.Text.Length - 1] == ')')
                {
                    if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/")
                    display.Text += btn.Text;
                }

            }
            else
            {  
                if (haveargs)
                {
                    Operator = false;
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
                    if (divideByZero)
                    {
                        display.Text = "can not divide by zero";
                        divideByZero = false;
                    }
                    else
                        display.Text = res.ToString();
                    firstOperation = false;
                }
                a = double.Parse(display.Text);
                operation = btn.Text;
                Operator = true;
                haveargs = true;
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (readString)
            {
                res = stringCalc.Calculate(display.Text);
                display.Text = res.ToString();
            }
            else { 
            Operator = false;
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
                else if (firstOperation)
                {
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

        private void ReadString(object sender, EventArgs e)
        {
            if (!readString)
            {
                button27.ForeColor = Color.Gray;
                button22.ForeColor = Color.Gray;
                button25.ForeColor = Color.Gray;
                button30.ForeColor = Color.Gray;
                button28.ForeColor = Color.Gray;
                button29.ForeColor = Color.Gray;
                button17.ForeColor = Color.Gray;
                button18.ForeColor = Color.Gray;
                button19.ForeColor = Color.Gray;
                button20.ForeColor = Color.Gray;
                button26.ForeColor = Color.Gray;
                button31.ForeColor = Color.Gray;
                button33.ForeColor = Color.Gray;
                button34.ForeColor = Color.Gray;
                button23.ForeColor = Color.Gray;
                button24.ForeColor = Color.Gray;
                button36.ForeColor = Color.Gray;
                button37.ForeColor = Color.Gray;
                button38.ForeColor = Color.Gray;
                button39.ForeColor = Color.Gray;
                button40.ForeColor = Color.Gray;
                display.Text = "0";
                isDouble = false;
                a = 0;
                b = 0;
                res = 0;
                operation = "";
                firstOperation = true;
                divideByZero = false;
                Memery = 0;
                Operator = false;
                haveargs = false;
                readString = true;
    }
            else
            {
                button27.ForeColor = Color.Black;
                button22.ForeColor = Color.Black;
                button25.ForeColor = Color.Black;
                button30.ForeColor = Color.Black;
                button28.ForeColor = Color.Black;
                button29.ForeColor = Color.Black;
                button17.ForeColor = Color.Black;
                button18.ForeColor = Color.Black;
                button19.ForeColor = Color.Black;
                button20.ForeColor = Color.Black;
                button26.ForeColor = Color.Black;
                button31.ForeColor = Color.Black;
                button33.ForeColor = Color.Black;
                button34.ForeColor = Color.Black;
                button23.ForeColor = Color.Black;
                button24.ForeColor = Color.Black;
                button36.ForeColor = Color.Black;
                button37.ForeColor = Color.Black;
                button38.ForeColor = Color.Black;
                button39.ForeColor = Color.Black;
                button40.ForeColor = Color.Black;
                display.Text = "0";
                readString = false;
                isDouble = false;
            }
        }
        public bool BracketsOpen = false;
        private void Brackets(object sender, EventArgs e)
        {
            if (readString)
            {   Operator = false;
                if (BracketsOpen)
                {
                    if (display.Text[display.Text.Length - 1] >= '0' && display.Text[display.Text.Length - 1] <= '9')
                    {
                        display.Text += ')';
                        BracketsOpen = false;
                    }
                }
                else if(!BracketsOpen)
                {
                    
                    if ((display.Text[display.Text.Length - 1] >= '0' && display.Text[display.Text.Length - 1] <= '9') || display.Text[display.Text.Length - 1] == ')')
                    {

                    }
                        
                    else if (display.Text == "0" && display.Text[display.Text.Length - 1] != ',')
                    {
                        BracketsOpen = true;
                        display.Text = "(";
                    }
                    else if (display.Text != "0" && display.Text[display.Text.Length - 1] != ',')
                    {
                        BracketsOpen = true;
                        display.Text += '(';
                    }
                }
            }
        }

        private void operator1(object sender, EventArgs e)
        {
            if (!readString)
            {
                Button btn = sender as Button;
                a = double.Parse(display.Text);
                operation = btn.Text;
                switch (operation)
                {
                    case "X^3":
                        res = a * a * a;
                        break;
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
                        res = Math.Cos(a) / Math.Sin(a);
                        break;
                    case "log":
                        res = Math.Log(a, 10);
                        break;
                    case "E^x":
                        res = Math.Pow(Math.E, a);
                        break;
                    case "10^x":
                        res = Math.Pow(10, a);
                        break;
                    case "1/X":
                        if (a == 0)
                        {
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
                    display.Text = "0";
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
