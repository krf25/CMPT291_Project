using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT291_Project
{
    internal class IDtracker
    {
        private static string CID = "";

        public static string CustomerID
        { 
            get { return CID; } 
            set { CID = value; }
        }

        private static string EID = "";

        public static string EmployeeID
        {
            get { return EID; }
            set { EID = value; }
        }
    }
}
