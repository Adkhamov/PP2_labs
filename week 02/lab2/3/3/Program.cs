using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3
{
    public class Prime
    {
        public static bool Is_prime(int a)
        {
            if (a == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if(a % i == 0)
                    return false;
                
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string readPath = @"C:\Users\1\Desktop\Асхат\AE\PP2\C#\week 02\lab2\3\3\input.txt";
            string writePath = @"C:\Users\1\Desktop\Асхат\AE\PP2\C#\week 02\lab2\3\3\output.txt";
            string text1;
            int mi = 0;
            bool ok = false;
            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    text1 = sr.ReadToEnd();
                }
                string[] text = text1.Split();
                
                for (int i = 0; i < text.Length; i++)
                {
                    if (Prime.Is_prime(int.Parse(text[i])))
                    {
                        mi = int.Parse(text[i]);
                        ok = true;
                        break;
                       
                    }
                }
                
                if (mi != 0)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (Prime.Is_prime(int.Parse(text[i])))
                        {
                            if (int.Parse(text[i]) < mi)
                            {
                                mi = int.Parse(text[i]);
                                ok = true;
                            }
                        }
                    }
                }
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    if (ok)
                        sw.WriteLine("Minimal prime is " + mi);
                    else
                        sw.WriteLine("No primes");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
