using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.cs 
{

   

    class Program
    {
        static void Main(string[] args)
        {

            //string arr = Console.ReadLine();       // ввод строки, содержащей числа и пробелы
            string[] arr = Console.ReadLine().Split(' ');         // запись строки в массив без пробелов
            
            
            for (int i = 0; i < arr.Length; i++)    // пробегаемся по масиву
            {
                bool ok = true;                     // создаем переменную, отвечающую за простоту числа
                if (int.Parse(arr[i]) == 1)
                {
                    continue;                       // если значение arr[i] = 1, то это не простое числа, пропускаем его
                }
                else for (int j = 2; j <= Math.Sqrt(int.Parse(arr[i])); j++) // пробегаемя по возможным множителям цифры с 2 до корня числа 
                {
                    
                    if (int.Parse(arr[i]) % j == 0)
                    {
                        ok = false;                 // если число делит на j без остатка, оно не простое. пропускам его
                        break;
                    }
                 
                }
                if (ok == true)                     // если значение ok не поменялось за все время, то число простое
                {
                    Console.Write(arr[i] + " ");    // выводим простые числа через пробел
                }
                
            }
            Console.Write("\nНажмите любую клавишу");
            Console.ReadKey();                      // задержка экрана до нажатия любой кнопки
        }
    }
}