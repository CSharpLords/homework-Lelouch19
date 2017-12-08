using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Расстояние_от_Москвы_до_города_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maximum = 0;
            for(int Number = 1; Number <= 10; Number = Number + 1)
            {
                Console.WriteLine("Введите расстояние до города № " + Number);
                int Distance = int.Parse(Console.ReadLine());
                if(Maximum < Distance)
                {     
                        Maximum = Distance;     
                }
            }
            Console.WriteLine("Максимальное расстояние - " + Maximum);
            Console.ReadLine();
        }
    }
}
