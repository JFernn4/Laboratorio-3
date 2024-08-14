using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class VehiculoPersonal : Vehiculo
    {
        public VehiculoPersonal(string matricula, string modelo, string combustible, Cliente cliente) : base(matricula, modelo, combustible, cliente)
        {
        }
        public static void RegistrarVehiculoPersonal(List<Vehiculo> listaVehiculos, Cliente cliente)
        {
            Console.WriteLine("Ingrese la matrícula del vehículo.");
            string matricula = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del vehículo.");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese el tipo de combustible del vehículo.");
            string combustible = Console.ReadLine();
            VehiculoPersonal vehiculoPersonal = new VehiculoPersonal(matricula, modelo, combustible, cliente);
            listaVehiculos.Add(vehiculoPersonal);
        }
    }
}
