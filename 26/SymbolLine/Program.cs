using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolLine 
{
	class Program 
    {
		static void Main(string[] args)
        {
			PrintSymbols("*", 10);
			PrintSymbols("+", 5);

			Console.ReadLine();
		}
        static void PrintSymbols(string symbol,int dlina)
        {
            string symbols = "";
            for (int x = 0; x < dlina; x++)
            {
                symbols = symbols + symbol;
            }
            Console.WriteLine(symbols);
        }
	}
}
