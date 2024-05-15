using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    internal class Program
    {
        //PASO 1: COMPLETAR ESTA SENTENCIA
        //CON ESTA SENTENCIA INICIALIZAMOS EL FORMULARIO/////////////
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();                   
            Application.SetCompatibleTextRenderingDefault(false);   
            Application.Run(new Form1());
        }
        //////////////////////////////////////////////////
    }
}
//PASO 2: ARMAR CLASE COLA.
//PASO 3: ARMAR CLASE NODO. (GET;SET)
//PASO 4: ARMAR FORMULARIO CON OBJETOS.
//PASO 5: CONFIGURAR OBJETOS.