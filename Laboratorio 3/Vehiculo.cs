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
        public Cliente Cliente { get; set; }

        public Vehiculo(string matricula, string modelo, string combustible, Cliente cliente)
        {
            Matricula = matricula;
            Modelo = modelo;
            Combustible = combustible;
            Cliente = cliente;
        }
        public static void Registrar(List<Vehiculo> listaVehiculos, List<Cliente> listaClientes)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente.");
            string clienteNombre=Console.ReadLine();
            Cliente cliente = listaClientes.Find(p => p.Nombre == clienteNombre);
            if (cliente == null)
            {
                Console.WriteLine("No se ha encontrado al cliente.");
                Console.ReadKey();
            }
            else
            {
                if (cliente is ClienteVIP)
                {
                    VehiculoPersonal.RegistrarVehiculoPersonal(listaVehiculos, cliente);
                }
                else if (cliente is ClienteRegular)
                {
                    VehiculoPersonal.RegistrarVehiculoPersonal(listaVehiculos, cliente);
                }
                else if (cliente is ClienteCorporativo)
                {
                    VehiculoCorporativo.RegistrarVehiculoCorporativo(listaVehiculos, cliente);
                }
            }
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
