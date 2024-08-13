using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Cliente(string nombre, string correo, string direccion)
        {
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
        }
        public static void MostrarDetalles(List<Cliente> listaClientes)
        {
            Console.Clear();
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente is ClienteRegular clienteRegular)
                {
                    Console.WriteLine("CLIENTE REGULAR.");
                    Console.WriteLine($"Nombre:{clienteRegular.Nombre}. Correo: {clienteRegular.Correo}. Dirección: {clienteRegular.Direccion}.");
                }
                else if (cliente is ClienteVIP clienteVIP)
                {
                    Console.WriteLine("CLIENTE VIP.");
                    Console.WriteLine($"Nombre:{clienteVIP.Nombre}. Correo: {clienteVIP.Correo}. Dirección: {clienteVIP.Direccion}.");
                }
                else if (cliente is ClienteCorporativo clienteCorporativo)
                {
                    Console.WriteLine("CLIENTE CORPORATIVO.");
                    Console.WriteLine($"Nombre:{clienteCorporativo.Nombre}. Correo: {clienteCorporativo.Correo}. Dirección: {clienteCorporativo.Direccion}.");
                }
            }
            Console.ReadKey();
        }
        public static void BuscarCliente(List<Cliente> listaClientes)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente que busca.");
            string nombreBuscar= Console.ReadLine();
            Cliente buscar= listaClientes.Find(p=>p.Nombre==nombreBuscar);
            if ( buscar == null )
            {
                Console.WriteLine("No se encontró al cliente.");
            }
            else
            {
                if (buscar is ClienteRegular clienteRegular)
                {
                    Console.WriteLine("CLIENTE REGULAR");
                    Console.WriteLine($"Nombre:{clienteRegular.Nombre}. Correo:{clienteRegular.Correo}. Dirección: {clienteRegular.Direccion}.");
                }
                else if (buscar is ClienteVIP clienteVIP)
                {
                    Console.WriteLine("CLIENTE VIP");
                    Console.WriteLine($"Nombre:{clienteVIP.Nombre}. Correo:{clienteVIP.Correo} . Dirección:  {clienteVIP.Direccion}.");
                }
                else if (buscar is ClienteCorporativo clientecorporativo)
                {
                    Console.WriteLine("CLIENTE CORPORATIVO");
                    Console.WriteLine($"Nombre:{clientecorporativo.Nombre}. Correo:{clientecorporativo.Correo}  . Dirección:   {clientecorporativo.Direccion}.");
                }
            }
            Console.ReadKey();
        }
    }
}
