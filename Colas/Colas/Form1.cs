using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        Cola miCola = new Cola();               //Declara una instancia de la clase Cola, que será usada para manejar una estructura de datos tipo cola.
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (txtNombreNodo.Text.Length == 0)                     //Verifica si el campo de texto txtNombreNodo no está vacío.
            {
                MessageBox.Show("Debe ingresar un nombre valido.");
            }
            else
            {
                Nodo nuevoNodo = new Nodo();                //Si el campo no está vacío, crea un nuevo nodo, 
                nuevoNodo.nombre = txtNombreNodo.Text;      //le asigna el texto del campo y lo agrega a la cola (miCola).
                miCola.Encolar(nuevoNodo);
                MostrarCola();              //actualiza la interfaz de usuario con el contenido actual de la cola.
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if(miCola.Vacia())                      //Verifica si el campo de texto txtNombreNodo no está vacío.
            {
                MessageBox.Show("La cola está vacia");
            }
            else 
            {
                miCola.Desencolar();  //Si no está vacía, elimina el primer nodo de la cola 
                MostrarCola();        //y actualiza la interfaz de usuario llamando a MostrarCola.
            }
        }

        private void MostrarCola()
        {
            lstCola.Items.Clear();                      // limpia la lista 'lstCola'
            MostrarNodoEnPantalla(miCola.Inicio);       //llama a MostrarNodoEnPantalla comenzando desde el nodo inicial de la cola.
        }

        private void MostrarNodoEnPantalla(Nodo unNodo)
        {
            if(unNodo != null)
            {
                lstCola.Items.Add(unNodo.nombre);               //se agrega el nombre del nodo (unNodo.nombre) a la lista lstCola.

                if (unNodo.Siguiente != null)                   //Recursión para el Siguiente Nodo:
                {
                    MostrarNodoEnPantalla(unNodo.Siguiente);    //llama recursivamente al método MostrarNodoEnPantalla pasando el siguiente nodo como parámetro.
                                                                //hasta que llega a un nodo que no tiene un nodo siguiente, lo que significa que se ha alcanzado el final de la cola.
                }
            }

            
        }

        private void Form1_Load(object sender, EventArgs e) //Este método se ejecuta cuando el formulario se carga por primera vez. Actualmente, está vacío.
        {

        }
    }
}
