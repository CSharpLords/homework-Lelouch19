using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPasteHell {
	class Program {
		static void Main(string[] args) {
			float[] numbers = { 765, 341, 1, -3, 0, 13, -200, 23, 44 };
            for(int n = 0; n < numbers.Length; n = n + 1)
            {
                numbers[n] = numbers[n] / 5;
                Console.WriteLine(numbers[n]);
            }
			
			Console.ReadLine();
		}
	}
}
