using System.Collections.Generic;

namespace Examen_Recuperacion_Eric_3Unidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            Producto producto = new Producto();
            int opcion = 0;
            string opcionS = "";
            string nombre = "";
            int precio = 0;
            while (opcion != 4)
            {
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("1 Insertar Nodo al Inicio\n" +
                    "2 Insertar Nodo al Final\n" +
                    "3 Buscar\n" +
                    "4 Mostrar\n" +
                    "5 Salir");
                opcionS = Console.ReadLine();
                if (opcionS == "")
                {
                    Console.WriteLine("Ingrese un valor, intente de nuevo");
                }
                else
                {
                    switch (opcionS)
                    {
                        case "1":
                            Console.WriteLine("Ingresa un nombre del Producto");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la precio");
                            precio = Convert.ToInt32(Console.ReadLine());
                            producto = new Producto
                            {
                                Nombre = nombre,
                                Precio = precio
                            };
                            lista.InsertarAlInicio(producto);
                            break;
                        case "2":
                            Console.WriteLine("Ingresa un nombre del producto");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la precio del producto");
                            precio = Convert.ToInt32(Console.ReadLine());
                            producto = new Producto
                            {
                                Nombre = nombre,
                                Precio = precio
                            };
                            lista.InsertarAlFinal(producto);
                            break;
                        case "3":
                            Console.WriteLine("Ingrese el precio del producto que desea buscar busca");
                            nombre = Console.ReadLine();
                            lista.BuscarNodo(precio);
                            break;
                        case "4":
                            lista.MostrarLista();
                            break;
                        case "5":
                            opcion = Convert.ToInt32(opcionS);
                            break;
                        default:
                            Console.WriteLine("No contemplado");
                            break;
                    }
                }
            }


        }
    }
}