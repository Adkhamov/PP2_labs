using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace forth
{
    class Program
    {
        
        static void Main(string[] args)
        {
            void Func1()
            {
                Console.Clear();
                for (int i = 0; i < 4; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("********");
                }
                Console.WriteLine(" ");
                for (int i = 0; i < 4; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("********");
                }
                Console.WriteLine(" ");
                for (int i = 0; i < 4; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("********");
                }


            }
            void Func2()
            {
                Console.Clear();
                for (int i = 0; i < 4; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("********");
                }
                Console.WriteLine(" ");
                for (int i = 0; i < 4; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("********");
                }
                Console.WriteLine(" ");
                for (int i = 0; i < 4; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("********");
                }


            }
            void Func3()
            {
                Console.Clear();
                for (int i = 0; i < 4; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("********");
                }
                Console.WriteLine(" ");
                for (int i = 0; i < 4; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("********");
                }
                Console.WriteLine(" ");
                for (int i = 0; i < 4; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("********");
                }
            }
            Func3();
            ThreadStart st = new ThreadStart()


            Thread thread = new Thread();



        }
    }
}
