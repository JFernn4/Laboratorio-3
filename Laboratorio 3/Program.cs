using Laboratorio_3;

int opcion;
bool menu = true;
List<Cliente> listaClientes = new List<Cliente>();
while (menu)
{
    MostrarMenu();
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            {
                break;
            }
        case 2:
            {
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
        case 8:
            {
                break;
            }
        case 9:
            {
                break;
            }
        case 10:
            {
                break;
            }
        case 11:
            {
                break;
            }
        case 12:
            {
                break;
            }
        case 13:
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
    Console.WriteLine("1. Registrar Cliente Regular.");
    Console.WriteLine("2. Registar Cliente VIP.");
    Console.WriteLine("3. Registrar Cliente Corporativo.");
    Console.WriteLine("4. Registrar Vehículo Personal.");
    Console.WriteLine("5. Registrar Vehículo Corporativo.");
    Console.WriteLine("6. Registrar Pedido.");
    Console.WriteLine("7. Mostrar Detalles de Clientes.");
    Console.WriteLine("8. Mosrar Detalles de Vehículos.");
    Console.WriteLine("9. Mostrar Detalles de Pedidos.");
    Console.WriteLine("10. Buscar Cliente por Nombre.");
    Console.WriteLine("11. Buscar Vehículo por Matrícula.");
    Console.WriteLine("12. Buscar Pedido por Número.");
    Console.WriteLine("13. Salir.");
}