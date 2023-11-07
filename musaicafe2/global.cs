using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDominio
{
    class global
    {
        private static string v_variable1 = "";

        public static string variable1
        {

            get { return v_variable1; }
            set {v_variable1 = value;}
        }

        private string toña;

        public string Toña
        {
            get { return toña; }
            set { toña = value; }
        }

    }
}
