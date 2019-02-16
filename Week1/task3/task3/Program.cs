
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        private static void dublicate(string[] s, int n) // Метод дублирования с 2 параметрами
        {
            string[] str = new string[n * 2]; // Массив строк
            for (int i = 0, j = 0; i < n; i++)
            {
                str[j++] = s[i]; // удвоение
                str[j++] = s[i];
            }
            for (int i = 0; i < 2 * n; ++i)
                Console.Write(s[i] + " ");
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // чтение первой строки и преобразование в int
            string[] d = Console.ReadLine().Split(); // чтение второй строки массив строк путем разделения
            dublicate(d, n); // Метод, который дублирует каждый элемент
            Console.ReadKey();
        }
    }
}