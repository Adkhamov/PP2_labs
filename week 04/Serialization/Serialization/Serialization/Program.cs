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
        
        static void Main()
        {
            Console.WriteLine("Введите комплексное число (a/b)");
            string[] s1 = Console.ReadLine().Split('/');
            Complex a = new Complex(int.Parse(s1[0]), int.Parse(s1[1]));
            int u = 1, s = 1, n = 1;
            Console.WriteLine("Up = записать/вывод Complex.txt");
            Console.WriteLine("Down = (де)сериализация файла Data.xml");
            Console.WriteLine("Left = двоичная (де)сериализация файла Data.txt");
            Console.WriteLine("Нажмите 'Escape', чтобы выйти");
            Console.WriteLine("Нажмите 'Enter', чтобы изменить комплексное число\n");
            while (true)
            {
                
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    
                    Console.WriteLine("Write");
                    WorkWithComplex.ComplexWrite(a, u);
                    Console.WriteLine("Read");
                    WorkWithComplex.ComplexRead(u);
                    u++;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine("Serialization");
                    WorkWithComplex.ComplexFileStreamIn(a,s);
                    Console.WriteLine("Deserialization");
                    WorkWithComplex.ComplexFileStreamOut(s);
                    s++;
                }

                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("Binary Serialization");
                    WorkWithComplex.ComplexBinaryFormIn(a, n);
                    Console.WriteLine("Binary Deserialization");
                    WorkWithComplex.ComplexBinaryFormOut(n);
                    n++;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Введите комплексное число (a/b)");
                    s1 = Console.ReadLine().Split('/');
                    a = new Complex(int.Parse(s1[0]), int.Parse(s1[1]));
                    Console.WriteLine("Up = записать/вывод Complex.txt");
                    Console.WriteLine("Down = (де)сериализация файла Data.xml");
                    Console.WriteLine("Left = двоичная (де)сериализация файла Data.txt");
                    Console.WriteLine("Нажмите 'Escape', чтобы выйти");
                    Console.WriteLine("Нажмите 'Enter', чтобы изменить комплексное число\n");
                }
                Console.ReadKey();
            }
        }
    }
}
