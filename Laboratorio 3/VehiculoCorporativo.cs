using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class VehiculoCorporativo : Vehiculo
    {
        public VehiculoCorporativo(string matricula, string modelo, string combustible) : base(matricula, modelo, combustible)
        {
        }
        public static void RegistrarVehiculoCorporativo(List<Vehiculo> listaVehiculos)
        {
            Console.Clear();
            Console.WriteLine("Ingrese la matrícula del vehículo.");
            string matricula= Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del vehículo.");
            string modelo= Console.ReadLine();
            Console.WriteLine("Ingrese el tipo de combustible del vehículo.");
            string combustible= Console.ReadLine();
            VehiculoCorporativo vehiculoCorporativo= new VehiculoCorporativo(matricula, modelo, combustible);
            listaVehiculos.Add(vehiculoCorporativo);
        }
    }
}
