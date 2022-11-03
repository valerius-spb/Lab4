using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых чисел, для окончания ввода последовательности введите 0:");

            int a = 0, k1 = 0, k2 = 0;

            do
            {
                a = Convert.ToInt32(Console.ReadLine());//Ввод чисел последовательности
                if (a > 0)
                {
                    k1++; //Количество положительных чисел
                   
                }
                else if (a < 0)
                {
                    k2++; //Количество отрицательных чисел
                    
                }
            } while (a != 0);
            Console.WriteLine("Количество положительных чисел = " + k1);
            Console.WriteLine("Количество отрицательных чисел = " + k2);
            Console.ReadKey();
        }
    }
}
