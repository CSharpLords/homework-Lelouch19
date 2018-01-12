using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_соседних_элементов
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = {-11, 67, -78, 9, -89, -34, -89, 98, -61};

            for(int n = 0; n < Numbers.Length; n = n + 1)
            {
                if (n + 1 < Numbers.Length)
                {

                    if (Numbers[n] < 0 && Numbers[n + 1] < 0 || Numbers[n] > 0 && Numbers[n + 1] > 0)
                    {
                        if (Numbers[n + 1] != Numbers.Length - 1)
                        {
                            Console.WriteLine(Numbers[n] + " " + Numbers[n + 1]);
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();

        }
    }
}
