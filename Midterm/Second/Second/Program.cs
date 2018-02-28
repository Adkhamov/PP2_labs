using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";

            string readPath = @"C:\Users\1\Desktop\Асхат\AE\PP2\C#\Midterm\Second\Second\input.txt";
            string writePath = @"C:\Users\1\Desktop\Асхат\AE\PP2\C#\Midterm\Second\Second\output.txt";
            string text1 = "";

            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }
                string[] arr = text.Split(' ');
                int mi = int.Parse(arr[0]);
                int min2 = int.Parse(arr[1]);
                for (int i = 1; i < arr.Length; i++)
                {
                    if (int.Parse(arr[i]) < mi)
                    {
                        mi = int.Parse(arr[i]);
                    }
                }

                for (int i = 1; i < arr.Length; i++)
                {
                    if (int.Parse(arr[i]) < min2 && int.Parse(arr[i]) != mi)
                    {
                        min2 = int.Parse(arr[i]);
                    }
                }

                /* using (StreamWriter sw = new StreamWriter(writePath, System.Text.Encoding.Default))
                 {
                     sw.WriteLine(min2);
                 }
                 */
                Console.WriteLine(min2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();


            
            Console.ReadKey();
            




        }
    }
}
