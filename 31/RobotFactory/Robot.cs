using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory 
{
	class Robot 
    {
        int iD = 0;
		private static int lastID = 0;
		public Robot() 
        {  
            iD = lastID;
			lastID ++;
		}

		public int GetID()
        {
			return iD;
		}
	}
}
