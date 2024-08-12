using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Producto
    {
        public string NombreProducto { get; set; }  
        public double Precio { get; set; }

        public Producto(string nombreProducto, double precio)
        {
            NombreProducto = nombreProducto;
            Precio = precio;
        }
    }
}
