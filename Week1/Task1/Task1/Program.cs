using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //строку преобразуем на целое число
            int[] a = new int[n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());// вводим цифры массива по колонку ReadLine
            }
            for (int i = 0; i < n; i++)
            {
                if (isprime(a[i]))
                {
                    k++;
                }
            }
            Console.WriteLine(k);// число прайм намберс
            for (int i = 0; i < n; i++)
            {
                if (isprime(a[i]))
                {
                    Console.Write(a[i] + " ");// выводим прайм намбер по строку Write
                }

            }
            Console.ReadKey();// программа запустится пока я сам не измену что нибудь
        }
        static bool isprime(int x)
        {
            if (x < 2) return false;// если меньше 2 то это не простое 
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }

}
