using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string readPath = @"C:\Users\1\Desktop\AE\PP2\C#\week 02\2\2\input.txt";
            string writePath = @"C:\Users\1\Desktop\AE\PP2\C#\week 02\2\2\output.txt";

            /*try
            {
                Console.WriteLine("READ FILE");
                using (StreamReader sr = new StreamReader(readPath))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
                Console.WriteLine();
                Console.WriteLine("READ STRING");
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            finally
            {

            }
            */
            
            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                /*using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Дозапись");
                    sw.Write(4.5);
                }
                */
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
