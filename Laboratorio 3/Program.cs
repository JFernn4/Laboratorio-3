using Laboratorio_3;

int opcion;
bool menu = true;
List<Cliente> listaClientes = new List<Cliente>();
List<Vehiculo> listaVehiculos= new List<Vehiculo>();
while (menu)
{
    MostrarMenu();
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            {
                bool menuClientes = true;
                int opcionClientes;
                while (menuClientes )
                {
                    Console.Clear();
                    Console.WriteLine("¿Qué tipo de cliente desea registrar?");
                    Console.WriteLine("1. Cliente Regular.");
                    Console.WriteLine("2. Cliente VIP.");
                    Console.WriteLine("3. Cliente Corporativo.");
                    Console.WriteLine("4. Salir.");
                    opcionClientes =Convert.ToInt32(Console.ReadLine());
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
                                menu=false;
                                break;
                            }
                    }
                }
                break;
            }
        case 2:
            {
                bool menuVehiculos=true;
                int opcionVehiculos;
                while (menuVehiculos )
                {
                    Console.Clear();
                    Console.WriteLine("¿Qué tipo de vehículo desea registrar?");
                    Console.WriteLine("1. Vehículo Personal.");
                    Console.WriteLine("2. Vehículo Corporativo.");
                    Console.WriteLine("3. Salir.");
                    opcionVehiculos= Convert.ToInt32(Console.ReadLine());
                    switch (opcionVehiculos)
                    {
                        case 1:
                            {
                                VehiculoPersonal.RegistrarVehiculoPersonal(listaVehiculos);
                                break;
                            }
                        case 2:
                            {
                                VehiculoCorporativo.RegistrarVehiculoCorporativo(listaVehiculos);
                                break;
                            }
                        case 3:
                            {
                                menuVehiculos = false;
                                break;
                            }
                    }
                }
                break;
            }
        case 3:
            {
                break;
            }
        case 4:
            {
                break;
            }
        case 5:
            {
                break;
            }
        case 6:
            {
                break;
            }
        case 7:
            {
                break;
            }
        case 0:
            {
                Console.Clear();
                menu= false;
                break;
            }

    }
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