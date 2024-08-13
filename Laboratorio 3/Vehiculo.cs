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
        public static void MostrarDetalles(List<Vehiculo> listaVehiculos)
        {
            Console.Clear();
            foreach (Vehiculo vehiculo in listaVehiculos)
            {
                if (vehiculo is  VehiculoPersonal vehiculoPersonal)
                {
                    Console.WriteLine("VEHÍCULO PERSONAL");
                    Console.WriteLine($"Matrícula: {vehiculoPersonal.Matricula}. Modelo: {vehiculoPersonal.Modelo}. Combustible: {vehiculoPersonal.Combustible}.");
                }
                else if (vehiculo is VehiculoCorporativo vehiculoCorporativo)
                {
                    Console.WriteLine("VEHÍCULO CORPORATIVO");
                    Console.WriteLine($"Matrícula: {vehiculoCorporativo.Matricula}. Modelo: {vehiculoCorporativo.Modelo}. Combustible: {vehiculoCorporativo.Combustible}.");
                }
            }
            Console.ReadKey();
        }
        public static void BuscarVehiculos(List<Vehiculo> listaVehiculos)
        {
            Console.Clear();
            Console.WriteLine("Ingresa la mattrícula del vehículo que desea buscar.");
            string vehiculoBuscar= Console.ReadLine();
            Vehiculo buscar= listaVehiculos.Find(p=>p.Matricula==vehiculoBuscar);
            if ( buscar == null )
            {
                Console.WriteLine("No se ha encontrado el vehículo.");
            }
            else
            {
                if (buscar is VehiculoPersonal vehiculoPersonal)
                {
                    Console.WriteLine("VEHÍCULO PERSONAL");
                    Console.WriteLine($"Matrículo: {vehiculoPersonal.Matricula}. Modelo: {vehiculoPersonal.Modelo}. Combustible: {vehiculoPersonal.Combustible}.");
                }
                else if  (buscar is VehiculoCorporativo vehiculoCorporativo)
                {
                    Console.WriteLine("VEHÍCULO CORPORATIVO");
                    Console.WriteLine($"Matrículo: {vehiculoCorporativo.Matricula}. Modelo: {vehiculoCorporativo.Modelo}. Combustible: {vehiculoCorporativo.Combustible}.");
                }
            }
            Console.ReadKey();
        }
    }
}
