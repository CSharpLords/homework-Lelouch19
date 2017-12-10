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
            Console.WriteLine("Введите загаданное слово.");
            string Word = Console.ReadLine().ToLower();
            int Letter = 0;
            int End = Word.Length - 1;

            for (int attempt = 0; attempt <= 9; attempt = attempt + 1)
            {
                Console.WriteLine("Введите букву.");
                char Letter2 = char.Parse(Console.ReadLine());

                if (Letter2 == Word[Letter])
                {
                    Console.WriteLine("Вы угадали букву!");
                    Console.WriteLine();
                    Letter = Letter + 1;

                    if (Letter2 == Word[Word.Length - 1])
                    {
                        attempt = 10;
                    }
                }

                else
                {
                    Console.WriteLine("Вы не угадали букву.");
                    
                }
              

            }
            Console.WriteLine("Вы угадали слово!");
            Console.ReadLine();

        }
    }
}
