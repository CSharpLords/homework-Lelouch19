using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_элемента_массива
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Massif = { 1, 5, 89, -67, 0 };
            for(int n = 0; n < Massif.Length; n = n + 1)
            {
                Console.WriteLine();
                Console.WriteLine("Введите номер массива.В массиве всего 5 чисел.");
                int a = int.Parse(Console.ReadLine());
                if (Massif[a] > 0)
                {
                    Console.WriteLine("Число положительное!");
                }
                else if (Massif[a] == 0)
                {
                    Console.WriteLine("Число равно нулю!");
                }
                else
                {
                    Console.WriteLine("Число отрицательное!");
                }
            }
            Console.ReadLine();
        }
    }
}
