using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fianl_2
{
    class Program
    {
        static bool Is_Prime(int a)
        {
            if (a == 1) return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if(a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            bool havePrime = false;
            DirectoryInfo directoryInfo = new DirectoryInfo(@"\\Mac\Home\Documents\PP2_labs\Final\fianl_2\fianl_2\bin\1");
            FileInfo[] fs = directoryInfo.GetFiles();
            foreach (FileSystemInfo f in fs)
            {
                StreamReader sr = new StreamReader(f.FullName);
                string s = sr.ReadToEnd();
                int[] d = new int[s.Length];
                string vrem = "";
                int cnt_dig = 0, k = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != ' ')
                    {
                        vrem += s[i];
                        k++;
                    }
                    else if (k != 0)
                    {
                            if (Is_Prime(int.Parse(vrem)))
                            {
                                Console.WriteLine(f.Name);
                                break;
                                vrem = "";
                            }
                        k = 0;
                        
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
