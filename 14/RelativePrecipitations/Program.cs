using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativePrecipitations {
	class Program {
		static void Main(string[] args)
        {
            int changes = 0;
			int[] precipitations = { 23, 4545, 45, 2, -16, 765, 341, 1, -3, 0 };

			for (int i = 0; i < precipitations.Length; i++)
            {
				changes = precipitations[i] - precipitations[0];
				Console.WriteLine(changes);
			}
			Console.ReadLine();
		}
	}
}
