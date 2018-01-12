using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Числа_кратные_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[17];
            int a = 60;
            for (int n = 0; n < Numbers.Length; n = n + 1)
            {
                int Remainder = a % 3;
                if (Remainder == 0)
                {
                    Numbers[n] = a;
                    Console.WriteLine(Numbers[n]);
                    a = a - 3;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < Numbers.Length; i = i + 1)
            {
                Console.WriteLine("Numbers[" + i + "] = " + Numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
