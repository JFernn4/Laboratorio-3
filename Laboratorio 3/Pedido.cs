using System;
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
        public List<Producto> Productos { get; set; } //Lista de productos

        public Pedido(int numero, string fecha)
        {
            Numero = numero;
            Fecha = fecha;
            Productos = new List<Producto>();
        }
        public static void RegistrarPedido(List<Pedido> listaPedidos)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el número de pedido.");
            int numero= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la fecha.");
            string fecha = Console.ReadLine();
            Pedido pedido= new Pedido(numero, fecha);
            Console.WriteLine("¿Cuántos productos desea agregar a este pedido?");
            int cantidadProductos= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.WriteLine($"Ingrese el nombre del producto {i+1}");
                string nombreProducto= Console.ReadLine();
                Console.WriteLine($"Ingrese el precio del producto {i+1}");
                double precio= Convert.ToDouble(Console.ReadLine());
                Producto producto= new Producto(nombreProducto, precio);
                pedido.Productos.Add(producto); //Añadir a la lista de productos de Pedidos
            }
            listaPedidos.Add(pedido);
        }
        public static void MostrarDetalles(List<Pedido> listaPedidos)
        {
            Console.Clear();
            foreach (Pedido pedido in listaPedidos)
            {
                Console.WriteLine($"-Número de pedido:{pedido.Numero}. Fecha: {pedido.Fecha}.");
                Console.WriteLine("Lista de productos:");
                foreach (Producto producto in pedido.Productos)
                {
                    Console.WriteLine($"Nombre: {producto.NombreProducto}. Precio: Q. {producto.Precio}.");
                }
            }
            Console.ReadKey();
        }
    }
}
