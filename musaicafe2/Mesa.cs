using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDominio
{
    public class Mesa
    {
        public int Numero { get; set; }
        public int Capacidad { get; set; }
        public string NombreCliente { get; set; }
        public List<Producto> Productos { get; set; }
        // Otras propiedades según tus necesidades

        public Mesa()
        {
            Productos = new List<Producto>();
        }
    }
}
