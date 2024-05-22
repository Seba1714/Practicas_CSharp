using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class Pila
    {
        Nodo _tope;
        public Nodo Tope()
        { 
            return _tope; 
        }

        public void Apilar(Nodo unNodo)
        {
            if (_tope == null)
            {                                         // Si la pila está vacía, el nuevo nodo se convierte en el tope.
                _tope = unNodo;
            }
            else
            {                                        // Si la pila no está vacía, el nuevo nodo se coloca en la cima.

                Nodo auxiliar = _tope;              // Guarda el nodo actual del tope en un auxiliar.
                _tope = unNodo;                     // Asigna el nuevo nodo como el tope.
                _tope.SiguienteNodo = auxiliar;     // El nuevo tope apunta al antiguo tope.
                //_tope.SiguienteNodo = unNodo;
            }
        }

        public void Desapilar()
        {
            if (_tope != null)
            {
                _tope = _tope.SiguienteNodo;        // Si la pila no está vacía, el tope se mueve al siguiente nodo.
            }
        }


    }
}
