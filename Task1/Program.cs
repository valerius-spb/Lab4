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
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int kv = 0;
            Console.WriteLine("Квадраты чисел от 1 до {0}:", n);
            //for (int i = 1; i <= 2*n-1; i+=2)
            //цикл выведения квадрата "n"чисел 
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}^2 = {1}", i, kv += i * 2 - 1);
            }
            Console.ReadKey();
        }
    }
}