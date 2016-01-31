using juzgado.Vistas.Login;
using juzgado.Vistas.Usuarios_crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using juzgado.Vistas.Procesos_crud;
using juzgado.Vistas.Mensajes;
namespace juzgado
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmProcesosJudiciales());
        }
    }
}
