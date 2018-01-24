using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите комплексное число №1 (a/b)");
            string[] s1 = Console.ReadLine().Split('/');
            Console.WriteLine("Введите оператора (+ - * /)");
            //string ch = Console.ReadLine();
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите комплексное число №1 (c/d)");
            string[] s2 = Console.ReadLine().Split('/'); 
            Complex a = new Complex(int.Parse(s1[0]), int.Parse(s1[1]));
            Complex b = new Complex(int.Parse(s2[0]), int.Parse(s2[1]));
            Complex c = new Complex(0, 0);
            if (ch == '+')
            {
                c = a + b;
            }
                
            if (ch == '-')
            {
                c = a - b;
            }
                
            if (ch == '*')
            {
                c = a * b;
            }

            if (ch == '/')
            {
                c = a / b;
            }
            

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
