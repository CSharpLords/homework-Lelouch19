﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Числа_кратные_3
{
    class Program
    {
        static void Main(string[] args)
        {           
            int[] Numbers = {0};
            for(int n = 0; n < Numbers.Length; n = n + 1)
            {

                for(int y = 60; y >= 10;y = y - 1)
                {

                    int Remainder = y % 3;
                    if (Remainder == 0)
                    {
                        Numbers[n] = y;
                        Console.WriteLine(Numbers[n]);
                    }

                }

            }
            Console.ReadLine();
        }
    }
}
