﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Pedido
    {
        public int Numero { get; set; }
        public string Fecha { get; set; }
        public List<Producto> Productos { get; set; }
        public Cliente Cliente { get; set; }
        public Pedido(int numero, string fecha, Cliente cliente)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Productos = new List<Producto>();
        }

        public static void RegistrarPedido(List<Pedido> listaPedidos, List<Cliente> listaClientes)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el número de pedido:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha del pedido:");
            string fecha = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del cliente:");
            string nombreCliente = Console.ReadLine();

            Cliente cliente = listaClientes.Find(p => p.Nombre == nombreCliente);

            if (cliente == null)
            {
                Console.WriteLine("No se ha encontrado al cliente.");
                Console.ReadKey();
            }
            else
            {
                Pedido pedido = new Pedido(numero, fecha, cliente);
                Console.WriteLine("¿Cuántos productos desea agregar a este pedido?");
                int cantidadProductos = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < cantidadProductos; i++)
                {
                    Console.WriteLine($"Ingrese el nombre del producto {i + 1}");
                    string nombreProducto = Console.ReadLine();
                    Console.WriteLine($"Ingrese el precio del producto {i + 1}");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    Producto producto = new Producto(nombreProducto, precio);
                    pedido.Productos.Add(producto);
                }
                listaPedidos.Add(pedido);
            }
        }
        public static double CalcularTotal(Pedido pedido)
        {
            double descuento= 0;
            double total= pedido.Productos.Sum(producto => producto.Precio);
            if (pedido.Cliente is ClienteVIP) 
            {
                descuento = total* 0.1;
                total= total-descuento;
            }
            else if (pedido.Cliente is ClienteCorporativo)
            {
               descuento= total * 0.15;
               total= total-descuento;
            }
            return total;
        }
        public static void MostrarDetalles(List<Pedido> listaPedidos)
        {
            Console.Clear();
            foreach (Pedido pedido in listaPedidos)
            {
                Console.WriteLine($"-Número de pedido:{pedido.Numero}. Fecha: {pedido.Fecha} Cliente:{pedido.Cliente.Nombre} Dirección: {pedido.Cliente.Direccion}.");
                Console.WriteLine("Lista de productos:");
                foreach (Producto producto in pedido.Productos)
                {
                    Console.WriteLine($"*Nombre: {producto.NombreProducto}. Precio: Q. {producto.Precio}.");
                }
                if (pedido.Cliente is ClienteRegular)
                {
                    Console.WriteLine($"Total: Q.{CalcularTotal(pedido)}.");
                }
                else if (pedido.Cliente is ClienteVIP)
                {
                    Console.WriteLine($"Total: Q.{CalcularTotal(pedido)} (10% de descuento aplicado).");
                }
                else if (pedido.Cliente is ClienteCorporativo)
                {
                    Console.WriteLine($"Total: Q.{CalcularTotal(pedido)} (15% de descuento aplicado).");
                }
            }
            Console.ReadKey();
        }
        public static void BuscarPedido(List<Pedido> listaPedidos, List<Cliente> listaClientes)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el número del pedido que desea buscar.");
            int buscarPedido= Convert.ToInt32(Console.ReadLine());
            Pedido buscar= listaPedidos.Find(p=>p.Numero == buscarPedido);
            if ( buscar == null )
            {
                Console.WriteLine("No se ha encontrado el pedido.");
            }
            else
            {
                Console.WriteLine($"-Número de pedido:{buscar.Numero}. Fecha: {buscar.Fecha}. Cliente:{buscar.Cliente.Nombre}. Dirección: {buscar.Cliente.Direccion}.");
                Console.WriteLine("Lista de productos:");
                foreach (Producto producto in buscar.Productos)
                {
                    Console.WriteLine($"Nombre: {producto.NombreProducto}. Precio: Q. {producto.Precio}.");
                }
                if (buscar.Cliente is ClienteRegular)
                {
                    Console.WriteLine($"Total: Q.{CalcularTotal(buscar)}.");
                }
                else if (buscar.Cliente is ClienteVIP)
                {
                    Console.WriteLine($"Total: Q.{CalcularTotal(buscar)} (10% de descuento aplicado).");
                }
                else if (buscar.Cliente is ClienteCorporativo)
                {
                    Console.WriteLine($"Total: Q.{CalcularTotal(buscar)} (15% de descuento aplicado).");
                }

            }
            Console.ReadKey();
        }
    }
}
