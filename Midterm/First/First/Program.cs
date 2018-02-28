using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int ans = 1;
            for (int i = 0; i < n; i++)
            {
                ans *= 2;
            }
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
