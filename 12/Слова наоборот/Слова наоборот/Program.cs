using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Слова_наоборот
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите слово.");
            string Word = Console.ReadLine().ToLower();

            for(int letter = 0; letter < Word.Length; letter = letter + 1)
            {
                int End = Word.Length - 1;
                Console.WriteLine(Word[End - letter]);
            }
            Console.ReadLine();
        }
    }
}
