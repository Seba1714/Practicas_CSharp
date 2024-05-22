using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{      
    public partial class Form1 : Form
    {
        Pila _miPila = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNodo_Click(object sender, EventArgs e)
        {
            Nodo nuevoNodo = new Nodo();                    // Creamos un nuevo Nodo.
            nuevoNodo.Nombre = txtNombreNodo.Text;          // Al nuevo nodo le asignamos el nombre que ingresamos en el TextBox.
            _miPila.Apilar(nuevoNodo);                      // Añade el nuevo nodo a la pila.
            MostrarPila();                                  // Actualiza la visualización de la pila.
        }

        void MostrarPila()                                  // Método para mostrar los elementos de la pila.
        {
            listPila.Items.Clear();                         // Limpia completamente la pila antes de mostrar la nueva configuración de la pila.

            if(_miPila.Tope() != null)                      // Comprueba que la lista no esté vacía.
            {
                MostrarNodoLista(_miPila.Tope());           // Muestra el nodo superior de la pila.
            }
            

        }

        void MostrarNodoLista(Nodo unNodo)
        {
            
            if (unNodo != null)                                 // Comprueba que el nodo no sea nulo.
            {
                listPila.Items.Add(unNodo.Nombre);              // Añade el nombre del nodo al ListBox.

                if (unNodo.SiguienteNodo != null)
                {
                    
                    MostrarNodoLista(unNodo.SiguienteNodo);     // Si existe un siguiente nodo entonces vuelve a ejecutar MistrarNodoLista.
                        
                    
                }
            }
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            _miPila.Desapilar();
            MostrarPila();
        }
    }
}
