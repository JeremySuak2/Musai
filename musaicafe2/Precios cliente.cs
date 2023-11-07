using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDominio
{
    class Precios_cliente
    {
        private string cliente;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private int toña;

        public int Toña
        {
            get { return toña; }
            set { toña = value; }
        }

        private int frost;

        public int Frost
        {
            get { return frost; }
            set { frost = value; }
        }
        private int clasica;

        public int Clasica
        {
            get { return clasica; }
            set { clasica = value; }
        }
        private int miller;

        public int Miller
        {
            get { return miller; }
            set { miller = value; }
        }


    }
}
