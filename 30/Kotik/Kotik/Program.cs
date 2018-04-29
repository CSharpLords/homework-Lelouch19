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
            Kotik cat = new Kotik();
            cat.Meow();
            cat.Walk();
            Console.ReadLine();
        }
    }
}
