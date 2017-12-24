using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумма_первых_шести_чисел_в_массиве
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] Massif = { 1, 567, 785, 896, -98, 0, 987, 456 };
            for(int n = 0; n < 6; n  = n + 1)
            {
                sum = sum + Massif[n];
            }
            Console.WriteLine("Сумма - " + sum);
            Console.ReadLine();
        }
    }
}
