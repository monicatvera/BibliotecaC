using System;
using System.Windows.Forms;

namespace Biblioteca.VistaBuscarEliminar
{
    class BuscarVista
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Buscar());

        }
    }
}
