using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Vehiculo
    {
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public string Combustible { get; set; }

        public Vehiculo(string matricula, string modelo, string combustible)
        {
            Matricula = matricula;
            Modelo = modelo;
            Combustible = combustible;
        }
    }
}
