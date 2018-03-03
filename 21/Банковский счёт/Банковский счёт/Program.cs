using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Банковский_счёт
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Money = { 56700, 8999, 76, 1090, -145000, 9000, 567, 890, 6578, 9 };
            int x = 0;
            for (int n = 0; n < Money.Length;n ++)
            {
                if (Money[n] < 0)
                {
                    x = x + 1;
                    break;
                }
      
            }
            if (x == 1)
            {
                Console.WriteLine("Задолжники есть!");
            }
            else
            {
                Console.WriteLine("Задолжников нет!");
            }
            Console.ReadLine();
        }
    }
}
