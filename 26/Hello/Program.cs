using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello {
	class Program 
    {
        static Random numbers = new Random();
		static void Main(string[] args) 
        {
			SayHello("Маша");
			SayHello("Женя");
			SayHello("Петя");

			Console.ReadLine();
		}

		static void SayHello(string name) 
        {
            int privet = numbers.Next(0, 3);
            if (privet == 0)
            {
                Console.WriteLine("Добрый день, " + name);
            }
            if (privet == 1)
            {
                Console.WriteLine("Здравствуй, " + name);
            }
            if (privet == 2)
            {
                Console.WriteLine("Привет, " + name);
            }
		}
	}
}
