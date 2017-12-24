using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Изменение_элементов_в_массиве
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Massif = { 1, 56, 89, -10, 97 };
            while (true)
            {
                Console.WriteLine("Введите номер элемента.");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число,на которое хотите заменить число в массиве.");
                int a = int.Parse(Console.ReadLine());
                Massif[n] = a;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
