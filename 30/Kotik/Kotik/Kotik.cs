using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Kotik
    {
        public int lives = 9;
        public Lapka[] lapki = new Lapka[5];
        public Kotik()
        {
            for (int i = 0; i < lapki.Length; i++)
            {
                lapki[i] = new Lapka();
            }
        }
        public void Meow()
        {
            Console.WriteLine("Мяуууууууууууууууууууууууу");
        }
        public void Walk()
        {
            for (int i = 0; i < lapki.Length; i++)
            {
                lapki[i].Move();
            }
            Console.WriteLine("Я хожу....!");
        }
    }
}
