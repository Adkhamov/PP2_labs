using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void ComplexWrite()
        {
            Complex c1 = new Complex(1, 2);
            StreamWriter sw = new StreamWriter(@"Complex.txt");
            sw.WriteLine(c1.a);
            sw.WriteLine(c1.b);
            sw.WriteLine(c1.volue);
            sw.Close();
        }

        static void ComplexRead()
        {
            StreamReader sr = new StreamReader(@"Complex.txt");
            Complex c2 = new Complex();
            int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            c2.a = a;
            c2.b = b;
            sr.Close();
            Console.WriteLine(c2.a + "/" + c2.b);
            Console.ReadKey();
        }

        static void ComplexFileStream1()
        {
            FileStream fs = new FileStream(@"data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));

            Complex a = new Complex(1, 2);
            try
            {
                xs.Serialize(fs, a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                fs.Close();
            }
        }

        static void ComplexFileStream2()
        {
            FileStream fs = new FileStream(@"data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            Complex b = xs.Deserialize(fs) as Complex;
            b.ToString();
            Console.ReadKey();
        }

        static void ComplexBinaryForm()
        {
            BinaryFormatter bf = new BinaryFormatter();
            Complex c2 = new Complex();
            int a = 1;
            int b = 2;
            c2.a = a;
            c2.b = b;

            FileStream fs = new FileStream(@"data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fs, a);
            fs.Close();
        }

        static void F6()
        {
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Complex b = bf.Deserialize(fs) as Complex;
            b.ToString();
            Console.ReadKey();
        }

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
