using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    // Define una clase interna llamada `PilaPrincipal`, que representa la estructura de una pila.
    internal class PilaPrincipal
    {
        // Declara una variable de tipo `Nodo` que almacenará el nodo que está en la cima de la pila.
        Nodo _top;
        // Método que devuelve el nodo en la cima de la pila.
        public Nodo GetTop()
        {
            // Retorna la referencia al nodo que está en la cima de la pila.
            return _top;
        }

        public Nodo GetLast( Nodo nodo)
        {
            if (nodo.Siguiente == null)
            { return nodo; }
            else { return GetLast(nodo.Siguiente); }
            
        }


        // Método que añade un nodo nuevo a la pila (operación "Push").
        public void Push(Nodo nodo)
        {
            // Si la pila está vacía (no hay nodo en la cima), el nuevo nodo se convierte en el primero de la pila.
            if (_top == null)
            {
                _top = nodo;
            }
            // Si la pila ya tiene nodos, inserta el nuevo nodo en la cima.
            else
            {
                // Guarda el nodo que actualmente está en la cima en una variable auxiliar.
                Nodo aux = _top;
                // Coloca el nuevo nodo como la nueva cima de la pila.
                _top = nodo;
                // El nuevo nodo ahora apunta al nodo que estaba previamente en la cima.
                _top.Siguiente = aux;
            }
        }
        // Método que elimina el nodo en la cima de la pila (operación "Pop").
        public void Pop()
        {
            // Verifica si hay algún nodo en la pila.
            if (_top != null)
            {
                // Si hay un nodo en la cima, lo elimina haciendo que la cima apunte al siguiente nodo.
                _top = _top.Siguiente;
            }
        }
        public void AgregarAlFinal(Nodo nodo)
        {
            if (_top == null)
            {
                _top = nodo;
            }
            else
            {
                Nodo aux = GetLast(_top);
                aux.Siguiente = nodo;
            }
        }
    }
}

