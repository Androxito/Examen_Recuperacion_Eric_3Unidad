using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Recuperacion_Eric_3Unidad
{
    public class Nodo
    {

        //Clase Nodo
        private Producto _producto;
        private Nodo _Siguiente;

        public Nodo(Producto producto)
        {
            _producto = producto;
            _Siguiente = null;
        }
        public Nodo(Producto producto, Nodo siguiente)
        {
            _producto = producto;
            _Siguiente = siguiente;
        }
        public Nodo gSiguiente
        {
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }
        public Producto gProducto
        {
            get { return _producto; }
            set { _producto = value; }
        }
    }
}
