using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что потеряли на этот раз?");
            string Answer = Console.ReadLine().ToLower();

            if(Answer == "носки")
            {
                Console.WriteLine("Под кроватью.");
                Console.ReadLine();
            }
            else if (Answer == "тапочки")
            {
                Console.WriteLine("Под кошкой.");
                Console.ReadLine();
            }
            else if (Answer == "портфель")
            {
                Console.WriteLine("В школе.");
                Console.ReadLine();
            }
            else if (Answer == "xbox")
            {
                Console.WriteLine("В тумбочке.");
                Console.ReadLine();
            }
            else if (Answer == "телефон")
            {
                Console.WriteLine("В кармане.");
                Console.ReadLine();
            }
            else if (Answer == "записка с паролем от dota2")
            {
                Console.WriteLine("В мусорке.Ваша мать выкинула,чтобы вы больше учились.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Такую вещь я не знаю.");
                Console.ReadLine();
            }
        }
    }
}
