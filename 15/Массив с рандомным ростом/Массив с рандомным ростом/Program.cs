using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массив_с_рандомным_ростом
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] growth = {0};
            for(int n = 0; n < growth.Length; n = n + 1)
            {
                for (int y = 0; y <= 12; y = y + 1)
                {
                    int r = rand.Next(163, 190);
                    growth[n] = r;
                    Console.WriteLine(growth[n]);
                }
            }
            Console.ReadLine();
        }
    }
}
