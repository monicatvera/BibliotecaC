using System;

namespace Biblioteca.Main
{
    class Inicio
    {
        //<summary>
        // Punto de entrada principal para la aplicación.
        // </summary>
        [STAThread]
		static void Main()
        {
            Controlador.Controlador inicio = new Controlador.Controlador();
        }
	}
}
