using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostNumerousPenguin {
	class Program 
    {
		static void Main(string[] args) 
        {
			string mostNumerous1 = GetMostNumerous(new string[] { "Emperor Penguin", "Macaroni Penguin", "Emperor Penguin", "Little Penguin" });
			string mostNumerous2 = GetMostNumerous(new string[] { "Emperor Penguin", "Macaroni Penguin", "Little Penguin", "Emperor Penguin", "Macaroni Penguin", "Macaroni Penguin", "Little Penguin" });
			Console.WriteLine(mostNumerous1);
			Console.WriteLine(mostNumerous2);

			Console.ReadLine();
		}

        static string GetMostNumerous(string[] penguins) 
        {
            int ep = 0;
            int mp = 0;
            int lp = 0;
            for(int x = 0; x < penguins.Length;x ++)
            {
                if (penguins[x] == "Emperor Penguin")
                {
                    ep = ep + 1;
                }
                if (penguins[x] == "Macaroni Penguin")
                {
                    mp = mp + 1;
                }
                if (penguins[x] == "Little Penguin")
                {
                    lp = lp + 1;
                }
            }
            if(ep > mp && ep > lp)
            {
                return "Emperor Penguin";
            }
            if (mp > ep && mp > lp)
            {
                return "Macaroni Penguin";
            }
            if (lp > mp && lp > ep)
            {
                return "Little Penguin";
            }
            return "";

		}
	}
}
