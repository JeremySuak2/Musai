using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDominio
{
    class factura
    {
        private string Producto;

        public string Producto1
        {
            get { return Producto; }
            set { Producto = value; }
        }
        private string cantidad;

        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private string precio;

        public string Precio
        {
            get { return precio; }
            set { precio = value; }
        }



    }
}
