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
                    Console.WriteLine($"Nombre:{clienteRegular.Nombre} Correo: {clienteRegular.Correo} Dirección: {clienteRegular.Direccion}");
                }
                if (cliente is ClienteVIP clienteVIP)
                {
                    Console.WriteLine("CLIENTE VIP.");
                    Console.WriteLine($"Nombre:{clienteVIP.Nombre} Correo: {clienteVIP.Correo} Dirección: {clienteVIP.Direccion}");
                }
                if (cliente is ClienteCorporativo clienteCorporativo)
                {
                    Console.WriteLine("CLIENTE CORPORATIVO.");
                    Console.WriteLine($"Nombre:{clienteCorporativo.Nombre} Correo: {clienteCorporativo.Correo} Dirección: {clienteCorporativo.Direccion}");
                }
            }
            Console.ReadKey();
        }
    }
}
