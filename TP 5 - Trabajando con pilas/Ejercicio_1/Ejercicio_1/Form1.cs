using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        // Declara una instancia de la clase `PilaPrincipal`, que será utilizada como la pila principal.
        PilaPrincipal _pila = new PilaPrincipal();

        // Constructor de la clase Form1, donde se inicializan los componentes del formulario.
        public Form1()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta cuando el formulario se carga. No hace nada en este caso.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Evento que se ejecuta al hacer clic en el botón "push" (btn_push). 
        // Aquí se añade un nuevo nodo a la pila.
        private void btn_push_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase Nodo.
            Nodo newNodo = new Nodo();

            // Asigna el valor del textbox (textBox1) como ID del nodo, convirtiéndolo de texto a entero.
            newNodo.ID = int.Parse(textBox1.Text);

            // Añade el nodo recién creado a la pila.
            _pila.Push(newNodo);

            // Llama al método `ShowStack` para actualizar la vista de la pila.
            ShowStack();
        }

        // Evento que se ejecuta cuando se selecciona algo en la lista de la pila (LV_Pila_1), pero no está implementado.
        private void LV_Pila_1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Método que muestra el contenido de la pila en la interfaz de usuario.
        void ShowStack()
        {
            // Limpia los elementos actuales de la lista visual `LV_Pila_1`.
            LV_Pila_1.Items.Clear();

            // Verifica si el nodo en la cima de la pila no es nulo.
            if (_pila.GetTop() != null)
            {
                // Si la cima no es nula, llama al método `ShowNode` para mostrar ese nodo.
                ShowNode(_pila.GetTop());
            }
        }

        // Método recursivo que agrega el nodo actual a la lista visual y luego sigue con el siguiente nodo.
        void ShowNode(Nodo nodo)
        {
            // Añade el ID del nodo actual a la lista visual en formato de texto.
            LV_Pila_1.Items.Add(nodo.ID.ToString());

            // Si el nodo tiene un nodo siguiente, vuelve a llamar a `ShowNode` con el nodo siguiente, continuando recursivamente.
            if (nodo.Siguiente != null)
            {
                ShowNode(nodo.Siguiente);
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "pop" (btn_pop). 
        // Aquí se quita el nodo en la cima de la pila.
        private void btn_pop_Click(object sender, EventArgs e)
        {
            // Llama al método `Pop` de la pila, que elimina el nodo en la cima.
            _pila.Pop();

            // Actualiza la vista de la pila tras eliminar el nodo.
            ShowStack();
        }

        private void btn_addFinal_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase Nodo.
            Nodo newNodo = new Nodo();

            // Asigna el valor del textbox (textBox1) como ID del nodo, convirtiéndolo de texto a entero.
            newNodo.ID = int.Parse(textBox1.Text);

            // Añade el nodo recién creado a la pila.
            _pila.AgregarAlFinal(newNodo);

            // Llama al método `ShowStack` para actualizar la vista de la pila.
            ShowStack();
        }
    }
}
