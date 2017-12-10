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
            Console.WriteLine("У тебя есть компьютер?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "нет") 
            {
                Console.WriteLine("Ну ок, тогда нам не о чем говорить");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (answer == "да")
            {
                Console.WriteLine("Сколько часов в неделю ты проводишь за ним?");            
            }

            int answer2 = int.Parse(Console.ReadLine());

            if (answer2 < 14)
            {

                Console.WriteLine("А большую часть этого времени ты работаешь или отдыхаешь?");
                string answer4 = Console.ReadLine().ToLower();

                if (answer4 == "работаю")
                {
                    Console.WriteLine("Ты и отдохнуть не забывай");
                    Console.ReadLine();
                }
                else if (answer4 == "отдыхаю")
                {
                    Console.WriteLine("Хорошо, что ты знаешь меру");
                    Console.ReadLine();
                }
               
            }


            else if (answer2 >= 14)
            {
                Console.WriteLine("А большую часть этого времени ты работаешь или отдыхаешь?");
                
                string answer3 = Console.ReadLine().ToLower();

                if (answer3 == "работаю")
                {
                    Console.WriteLine("Пожалей себя!!");
                    Console.ReadLine();
                }
                else if (answer3 == "отдыхаю")
                {
                    Console.WriteLine("Хватит портить своё здоровье!");
                    Console.ReadLine();
                }
            }

        }
    
    }
}
