using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число,которое загадал Валера");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Пришло время угадывать!");
            Console.WriteLine();
            int a = 1; //Количество попыток

            while (true) 
            {
                
                Console.WriteLine("Введите число.");
                int n = int.Parse(Console.ReadLine());
                if (n < Number)
                {  
                    Console.WriteLine("Число меньше загадонного.");
                    a = a + 1;
                }
                else if (n > Number)
                {
                    Console.WriteLine("Число больше загадонного.");
                    a = a + 1;
                }
                else if (n == Number)
                {
                    
                    Console.WriteLine("Вы отгадали число!");
                    Console.WriteLine("Количество попыток " + a);
                    Console.ReadLine();
                    Environment.Exit(0);
                   
                }
            }


    
        }
    }
}
