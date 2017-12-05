using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Все_целые_числа_от_100_до_200__кратные_семи
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 100;
            while (Number <= 200)
            {  
                int Rest = Number % 7;                                      //Остаток от деления на 7.
                if(Rest == 0)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(Number);
                    
                }
                Number = Number + 1;
            }
            Console.ReadLine();

        }
    }
}
