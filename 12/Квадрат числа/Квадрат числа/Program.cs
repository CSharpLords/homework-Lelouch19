using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поиск_квадратов
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double n = 0.1; n <= 0.9; n = n + 0.1)
            {
                Console.WriteLine(Math.Sqrt(n));
            }
            Console.ReadLine();
        }
    }
}