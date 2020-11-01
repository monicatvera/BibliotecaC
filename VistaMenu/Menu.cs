using System;
using System.Windows.Forms;

namespace Biblioteca.VistaMenu
{
    class Menu
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());

        }
    }
}
