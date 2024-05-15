using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Nodo
    {
        public string nombre { get; set; }      // El get permite obtener el valor del nombre almacenado en el nodo,
                                                // El set permite asignar un nuevo valor al nombre almacenado en el nodo.
        public Nodo Siguiente { get; set; }     // Referencia al siguiente elemento en la lista enlazada.
                                                // Esto permite que cada nodo esté conectado al siguiente nodo en la secuencia.
                                                //El get permite obtener la referencia al siguiente nodo en la lista enlazada
                                                //El set permite asignar una nueva referencia al siguiente nodo en la lista enlazada.

    }
}
