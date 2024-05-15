using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    //PASO 2:
    class Cola
    {
        Nodo _inicio;       // Representa el pirmer nodo en la cola.
        public void Encolar(Nodo unNodo)
        {           
            if (_inicio == null)        // Si la cola está vacía asigna el nodo como el primer elemento de la cola.
            {
                _inicio = unNodo;
            }
            else      // Si la cola ya tiene elementos, busca el último nodo en la cola y establece el siguiente nodo del último como el nodo proporcionado.
            {
                Nodo aux = BuscarUltimo(_inicio);       //Recorre la cola para encontrar el último nodo
                aux.Siguiente = unNodo;
            }
        }

        private Nodo BuscarUltimo(Nodo unNodo)          //Elimina el primer elemento de la cola al asignar el siguiente nodo del primer nodo como el nuevo primer nodo.
        { 
            if(unNodo.Siguiente  == null)
            {
                return unNodo;
            }
            else 
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }

        public void Desencolar()
        {
            _inicio = _inicio.Siguiente;
        }

        public Nodo Inicio
        {                                   //permite acceder al primer nodo de la cola.
            get { 
                return _inicio; 
            } 
        }

        public bool Vacia()                     //devuelve un valor booleano indicando si la cola está vacía o no, basado en si _inicio es nulo o no.
        {
            return (_inicio == null);
        }
    }
}
