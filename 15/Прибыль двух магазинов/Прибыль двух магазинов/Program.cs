using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прибыль_двух_магазинов
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;
            int sum = 0;

            Random rand = new Random();
            int[] FirstShop = new int [61];
            for(int n = 0; n < FirstShop.Length; n = n + 1)
            {             
                    int r = rand.Next(0, 10000);
                    sum1 = sum1 + r;            
            }

            int[] SecondShop = new int[61];
            for(int y = 0; y < SecondShop.Length; y = y + 1)
            {            
                    int R = rand.Next(0, 100000);
                    sum2 = sum2 + R;
            }

            sum = sum1 + sum2;
            Console.WriteLine("Прибыль за все дни - " + sum + " рублей.");
            Console.ReadLine();
        }
    }
}
