using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool Is_pol(string a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != a[a.Length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }
            string s = Console.ReadLine();
            int pol = 0, cnt = 0;
            string[] words = new string[100];
            int k = 0;
            words[cnt] = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    words[cnt] += s[i];
                    k++;
                    continue;
                }
                else if (k != 0)
                {
                    cnt++;
                    k = 0;
                    continue;
                }
                else
                {
                    k = 0;
                    continue;
                }
            }
            if (k != 0)
            {
                cnt++;
                k = 0;
            }

            for (int i = 0; i < cnt; i++)
            {
                //Console.WriteLine(words[i]);
                if (Is_pol(words[i]))
                {
                    pol++;
                }
            }
            Console.WriteLine(cnt);
            Console.WriteLine(pol);
            Console.ReadKey();
        }
    }
}
