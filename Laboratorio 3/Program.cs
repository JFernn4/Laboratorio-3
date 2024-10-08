﻿using Laboratorio_3;

int opcion;
bool menu = true;
List<Cliente> listaClientes = new List<Cliente>();
List<Vehiculo> listaVehiculos= new List<Vehiculo>();
List <Pedido> listaPedidos= new List<Pedido>();
while (menu)
{
    try
    {
        MostrarMenu();
        opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                {
                    bool menuClientes = true;
                    int opcionClientes;
                    while (menuClientes)
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("¿Qué tipo de cliente desea registrar?");
                            Console.WriteLine("1. Cliente Regular.");
                            Console.WriteLine("2. Cliente VIP.");
                            Console.WriteLine("3. Cliente Corporativo.");
                            Console.WriteLine("4. Salir.");
                            opcionClientes = Convert.ToInt32(Console.ReadLine());
                            switch (opcionClientes)
                            {
                                case 1:
                                    {
                                        ClienteRegular.RegistrarClienteRegular(listaClientes);
                                        break;
                                    }
                                case 2:
                                    {
                                        ClienteVIP.RegistrarClienteVIP(listaClientes);
                                        break;
                                    }
                                case 3:
                                    {
                                        ClienteCorporativo.RegistrarClienteCorporativo(listaClientes);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Clear();
                                        menuClientes = false;
                                        break;
                                    }
                            }
                        }
                        catch (Exception ex) { Console.WriteLine("Ingrese un número del 1 al 4." +ex.Message); Console.ReadKey(); }
                    }
                    break;
                }
            case 2:
                {
                    Vehiculo.Registrar(listaVehiculos, listaClientes);
                    break;
                }
            case 3:
                {
                    Pedido.RegistrarPedido(listaPedidos, listaClientes);
                    break;
                }
            case 4:
                {
                    Cliente.MostrarDetalles(listaClientes);
                    break;
                }
            case 5:
                {
                    Vehiculo.MostrarDetalles(listaVehiculos);
                    break;
                }
            case 6:
                {
                    Pedido.MostrarDetalles(listaPedidos);
                    break;
                }
            case 7:
                {
                    Cliente.BuscarCliente(listaClientes);
                    break;
                }
            case 8:
                {
                    Vehiculo.BuscarVehiculos(listaVehiculos);
                    break;
                }
            case 9:
                {
                    Pedido.BuscarPedido(listaPedidos, listaClientes);
                    break;
                }
            case 0:
                {
                    Console.Clear();
                    menu = false;
                    break;
                }

        }
    }
    catch (Exception ex) { Console.WriteLine($"Ingrese un número del 0 al 9. "+ex.Message); Console.ReadKey(); }
}
static void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("1. Registrar Cliente");
    Console.WriteLine("2. Registrar Vehículo.");
    Console.WriteLine("3. Registrar Pedido.");
    Console.WriteLine("4. Mostrar Detalles de Clientes.");
    Console.WriteLine("5. Mosrar Detalles de Vehículos.");
    Console.WriteLine("6. Mostrar Detalles de Pedidos.");
    Console.WriteLine("7. Buscar Cliente por Nombre.");
    Console.WriteLine("8. Buscar Vehículo por Matrícula.");
    Console.WriteLine("9. Buscar Pedido por Número.");
    Console.WriteLine("0. Salir.");
}