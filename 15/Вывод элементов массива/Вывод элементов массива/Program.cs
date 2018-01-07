using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вывод_элементов_массива
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = {245, 8, 1987, -56, 6789, 0};
            for(int n = 1; n < Numbers.Length; n = n + 1)                 //Элемент с индексом "0" не выводим,поэтому начинаем с элемента с индексом "1"
            {
                if(Numbers[n] > Numbers[n - 1])
                {
                    Console.WriteLine(Numbers[n]);
                }
            }
            Console.ReadLine();
        }
    }
}
