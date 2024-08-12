using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class ClienteVIP : Cliente
    {
        public ClienteVIP(string nombre, string correo, string direccion) : base(nombre, correo, direccion)
        {
        }
        public static void RegistrarClienteVIP (List<Cliente> listaClientes)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente.");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el correo del cliente.");
            string correo = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección del cliente.");
            string direccion = Console.ReadLine();
            ClienteVIP clienteVIP = new ClienteVIP(nombre, correo, direccion);
            listaClientes.Add(clienteVIP);
        }
    }
}
