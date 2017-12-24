using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_элементов_на_чётность
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] Massif = {1, 78, 89, -156, 0};
            for(int n = 0; n < Massif.Length; n = n + 1)
            {
               sum = sum + Massif[n];
            }
            int Rest = sum % 2;
            if(Rest == 0)
            {
                Console.WriteLine("Сумма элементов в массиве является чётным числом!");
            }
            else
            {
                Console.WriteLine("Сумма элементов в массиве является нечётным числом!");
            }
            Console.ReadLine();
        }
    }
}
