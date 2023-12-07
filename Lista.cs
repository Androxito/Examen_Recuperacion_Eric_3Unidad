using Examen_Recuperacion_Eric_3Unidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Recuperacion_Eric_3Unidad
{
    public class Lista
    {
        //Clase Lista 
        private Nodo primero;
        private Nodo ultimo;
        public Lista()
        {
            primero = ultimo = null;
        }
        public bool Esnulo()
        {
            return primero == null;
        }
        public void InsertarAlInicio(Producto producto)
        {
            if (Esnulo())
            {
                primero = ultimo = new Nodo(producto);
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    if (actual.gSiguiente == null)
                    {
                        actual = actual.gSiguiente = new Nodo(producto);
                        break;
                    }
                    else
                    {
                        actual = actual.gSiguiente;
                    }
                }
            }
        }
        public void InsertarAlFinal(Producto producto)
        {
            if (Esnulo())
            {
                ultimo = primero = new Nodo(producto);
            }
            else
            {
                Nodo actual = ultimo;
                while (actual != null)
                {
                    if(actual.gSiguiente == null)
                    {
                        actual = actual.gSiguiente = new Nodo(producto);
                        break;
                    }
                    else
                    {
                        actual = actual.gSiguiente;
                    }
                }
                
            }
        }
        public void BuscarNodo(int precio)
        {
            if (Esnulo())
            {
                Console.WriteLine("No tiene valores la lista");
                return;
            }
            else
            {
                Nodo actual = ultimo;
                bool Bandera = false;
                int cont = 0;
                while (actual != null)
                {
                    cont++;
                    if (actual.gProducto.Precio == precio)
                    {
                        Console.WriteLine($"El producto {actual.gProducto.Nombre} tiene como precio {actual.gProducto.Precio}");
                        actual = actual.gSiguiente;
                        Bandera = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"No se encuentra el precio de: {actual.gProducto.Precio} en la lista");
                    }
                }
                if (!Bandera)
                {
                    Console.WriteLine("El nombre no se encuentra en la lista");
                    return;
                }
            }
        }
        public void MostrarLista()
        {
            if (Esnulo())
            {
                Console.WriteLine("La lista se enceuntra vacia");
                return;
            }
            else
            {

                Nodo actual = ultimo;
                while (actual != null)
                {
                    Console.WriteLine($"El nombre es: {actual.gProducto.Nombre} y el precio es: {actual.gProducto.Precio} Pesos");
                    actual = actual.gSiguiente;
                }
            }
        }
    }
}


       