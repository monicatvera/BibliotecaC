using System;
using System.Windows.Forms;

namespace Biblioteca.VistaListaAlumnos
{
    class VistaLista
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lista());

        }
    }
}
